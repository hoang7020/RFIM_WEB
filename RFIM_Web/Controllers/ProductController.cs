using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using RFIM_Web.Utils;

namespace RFIM_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository context;
        public ProductController(IProductRepository _context)
        {
            context = _context;
        }

        public IActionResult ListAllProduct()
        {
            var dsProduct = context.GetAllProduct();
            return View(dsProduct);
        }
        //Return view create product
        public IActionResult CreateProduct()
        {
            ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName");
            ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(Product product, IFormFile fHinh)
        {
            //check model validation 
            if (ModelState.IsValid)
            {
                //check if product id already existed 
                bool productIdExist = context.ProductIdExists(product.ProductId);
                bool productNameExist = context.ProductNameExists(product.ProductName);
                //if product id is not existed
                if (!productIdExist)
                {
                    if (!productNameExist)
                    {
                        if (fHinh != null)
                        {
                            product.Image = UploadImageTool.UploadImage(fHinh, "product");
                        }
                        product.Status = true;
                        context.AddProduct(product);
                        return RedirectToAction(nameof(ListAllProduct));
                    }
                    else
                    {
                        ViewBag.ProductNameExisted = "Product Name is already existed !!!";
                        ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName", product.CategoryId);
                        ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName", product.VendorId);
                        return View(product);
                    }
                }
                //product id is existed
                else
                {
                    ViewBag.ProductIdExistMessage = "Product Id already existed !!!";
                }
            }
            ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName", product.VendorId);
            return View(product);
        }
        [HttpGet]
        public IActionResult EditProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = context.FindProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName", product.VendorId);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(string id, Product product, IFormFile fHinh)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {

                    bool productNameExist = context.ProductNameExistExceptId(product.ProductId, product.ProductName);
                    if (!productNameExist)
                    {
                        if (fHinh != null)
                        {
                            product.Image = UploadImageTool.UploadImage(fHinh, "product");
                        }
                        product.Status = true;
                        context.UpdateProduct(product);
                    }
                    else
                    {
                        ViewBag.ProductNameExisted = "Product Name is already existed !!!";
                        ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName", product.CategoryId);
                        ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName", product.VendorId);
                        return View(product);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExist(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAllProduct));
            }
            ViewData["CategoryId"] = new SelectList(context.GetAllCategory(), "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(context.GetAllVendor(), "VendorId", "VendorName", product.VendorId);
            return View(product);
        }
        [HttpGet]
        public IActionResult DeleteProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = context.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            var productExistInPackage = context.ProductExistInPackage(id);
            if (productExistInPackage)
            {
                return PartialView("DeactiveFail", product);
            }
            else
            {
                return PartialView("DeleteProduct", product);
            }
        }
        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(string id)
        {
            var product = context.FindProductById(id);
            context.DeactiveProduct(product);
            return RedirectToAction(nameof(ListAllProduct));
        }
        [HttpGet]
        public IActionResult ActiveProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = context.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return PartialView("ActiveProduct", product);
        }
        [HttpPost, ActionName("ActiveProduct")]
        [ValidateAntiForgeryToken]
        public IActionResult ActiveConfirm(string id)
        {
            var product = context.FindProductById(id);
            context.ActiveProduct(product);
            return RedirectToAction(nameof(ListAllProduct));
        }

        private bool ProductExist(string id)
        {
            return context.ProductIdExists(id);
        }

        public IActionResult BackToProductList()
        {
            return RedirectToAction(nameof(ListAllProduct));
        }

        public IActionResult DetailProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = context.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            var packages = context.GetAllPackageById(id);
            ViewBag.PackageSelectFromProduct = packages;

            return View(product);
        }

        public IActionResult ExampleFile()
        {
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("Product");

                //Add a List validation to A column. Values should be in a list
                var valA = sheet.DataValidations.AddListValidation("A:A");
                valA.AllowBlank = false;
                //Shows error message when the input doesn't match the accepted values
                valA.ShowErrorMessage = true;
                valA.ErrorStyle = OfficeOpenXml.DataValidation.ExcelDataValidationWarningStyle.information;
                //Title of the error mesage box
                valA.ErrorTitle = "Warning !!!";
                valA.Error = "This field is required, please check and input !!!";
                valA.ShowInputMessage = true;
                valA.PromptTitle = "Warning !!!";
                valA.Prompt = "This field is required";
                //Define the accepted values
                valA.Formula.Values.Add("Id can't be duplicated");

                var valBText = sheet.DataValidations.AddTextLengthValidation("B:B");
                valBText.ShowErrorMessage = true;
                valBText.Formula.Value = 1;
                valBText.Formula2.Value = 256;
                valBText.AllowBlank = true;

                sheet.DefaultColWidth = 20;
                sheet.Cells.Style.WrapText = true;

                sheet.Cells[1, 1].Value = "Product Id";
                sheet.Cells[1, 2].Value = "Product Name";
                sheet.Cells[1, 3].Value = "Quantity Per Box";
                sheet.Cells[1, 4].Value = "Category";
                sheet.Cells[1, 5].Value = "Vendor";
                package.Save();
            }
            stream.Position = 0;
            string fileName = $"Product_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        [HttpGet]
        public IActionResult ImportProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ImportProduct(IFormFile fImport)
        {
            try
            {
                if (fImport == null || fImport.Length <= 0)
                {
                    ViewBag.EmptyFileMessage = "File is not existed or fail to upload";
                    return View();
                }
                List<Product> productImports = new List<Product>();
                var supportedTypes = new[] { "xls", "xlsx" };
                var fileExt = System.IO.Path.GetExtension(fImport.FileName.ToString()).Substring(1);
                if (!supportedTypes.Contains(fileExt))
                {
                    ViewBag.WrongType = "Please choose any file with .xls or .xlsx extension!!!";
                    return View();
                }
                else
                {
                    //tạo stream giữ file upload lên
                    using (var stream = new MemoryStream())
                    {
                        fImport.CopyTo(stream);

                        //Map stream với Excel file
                        using (var package = new ExcelPackage(stream))
                        {
                            var sheet = package.Workbook.Worksheets[0];
                            int rowCount = sheet.Dimension.Rows;

                            //duyệt qua từng dòng của sheet Excel bóc tách dữ liệu ra
                            for (int i = 2; i <= rowCount; i++)
                            {
                                productImports.Add(new Product
                                {
                                    ProductId = sheet.Cells[i, 1].Value.ToString(),
                                    ProductName = sheet.Cells[i, 2].Value.ToString(),
                                    Weight = 0.0,
                                    Image = "",
                                    Description = "",
                                    Height = 0.0,
                                    Width = 0.0,
                                    Length = 0.0,
                                    QuantityPerBox = int.Parse(sheet.Cells[i, 3].Value.ToString()),
                                    CategoryId = int.Parse(sheet.Cells[i, 4].Value.ToString()),
                                    VendorId = int.Parse(sheet.Cells[i, 5].Value.ToString()),
                                    Status = true
                                });
                            }
                        }
                    }
                }
                if (productImports.Count > 0)
                {
                    //tiến hành update hoặc insert
                    foreach (Product product in productImports)
                    {
                        var item = context.GetProductById(product.ProductId);
                        var itemNameExist = context.ProductNameExists(product.ProductName);
                        if (item != null)//đã có --> update
                        {
                            ViewBag.ProductIdExist = "Product Id is already existed !!!";
                            return View();
                        }
                        else
                        {
                            if (!itemNameExist)
                            {
                                context.AddProduct(product);
                            }
                            else
                            {
                                ViewBag.ProductNameExist = "Product name is already existed !!!!";
                                return View();
                            }
                        }
                    }
                }
                ViewBag.SuccessMessage = "List of products was imported successfully!";
            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}