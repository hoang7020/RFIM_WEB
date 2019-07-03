using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using RFIM_Web.Utils;

namespace RFIM_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDbContext ctx;
        public ProductController(MyDbContext db)
        {
            ctx = db;
        }

        public IActionResult ListAllProduct()
        {
            var dsProduct = ctx.Products.Include(p => p.Category).ToList();
            return View(dsProduct);
        }
        //Return view create product
        public IActionResult CreateProduct()
        {
            //ViewBag.CategorySelect = new CategorySelect
            //{
            //    Data = ctx.Categories.ToList()
            //};
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName");
            ViewData["VendorId"] = new SelectList(ctx.Vendors, "VendorId", "VendorName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(Product product, IFormFile fHinh)
        {
            //check model validation 
            if (ModelState.IsValid)
            {
                //check if product id already existed 
                bool productIdExist = ctx.Products.Any(p => p.ProductId == product.ProductId);
                bool productNameExist = ctx.Products.Any(p => p.ProductName == product.ProductName);
                //if product id is not existed
                if (!productIdExist)
                {
                    if (!productNameExist)
                    {
                        if (fHinh != null)
                        {
                            product.Image = UploadImageTool.UploadImage(fHinh, "product");
                        }
                        ctx.Add(product);
                        await ctx.SaveChangesAsync();
                        return RedirectToAction(nameof(ListAllProduct));
                    } else
                    {
                        ViewBag.ProductNameExisted = "Product Name is already existed !!!";
                        return View(product);
                    }
                }
                //product id is existed
                else
                {
                    ModelState.AddModelError("", "Product Id already existed !!!");
                }
            }
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(ctx.Vendors, "VendorId", "VendorName", product.VendorId);
            //if validation is error return view with error messages
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> EditProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            //ViewBag.CategorySelect = new CategorySelect
            //{
            //    Data = ctx.Categories.ToList(),
            //    Select = product.ProductId
            //};
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(ctx.Vendors, "VendorId", "VendorName", product.VendorId);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(string id, Product product, IFormFile fHinh)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    bool productNameExist = ctx.Products.Any(p => p.ProductName == product.ProductName);
                    if (!productNameExist)
                    {
                        if (fHinh != null)
                        {
                            product.Image = UploadImageTool.UploadImage(fHinh, "product");
                        }
                        ctx.Update(product);
                        await ctx.SaveChangesAsync();
                    }
                    else
                    {
                        ViewBag.ProductNameExisted = "Product Name is already existed !!!";
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
            ViewData["CategoryId"] = new SelectList(ctx.Categories, "CategoryId", "CategoryName", product.CategoryId);
            ViewData["VendorId"] = new SelectList(ctx.Vendors, "VendorId", "VendorName", product.VendorId);
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.Include(p => p.Category).Include(p=>p.Vendor)
                .SingleOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return PartialView("DeleteProduct", product);
        }
        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var product = await ctx.Products.FindAsync(id);
            ctx.Products.Remove(product);
            await ctx.SaveChangesAsync();
            return RedirectToAction(nameof(ListAllProduct));
        }

        private bool ProductExist(string id)
        {
            return ctx.Products.Any(p => p.ProductId == id);
        }

        public IActionResult BackToProductList()
        {
            return RedirectToAction(nameof(ListAllProduct));
        }

        public async Task<IActionResult> DetailProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await ctx.Products.Include(p => p.Category).Include(p => p.Vendor).FirstOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            var packages = await ctx.Packages.Where(p => p.ProductId == id).ToListAsync();

            ViewBag.PackageSelectFromProduct = packages;
            
            return View(product);
        }
        public IActionResult ExportProduct()
        {
            var data = ctx.Products.Include(p => p.Category).Include(p => p.Vendor).Select(p => new ProductExcelView
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Weight = p.Weight.Value,
                Category = p.Category.CategoryName,
                Vendor = p.Vendor.VendorName,
                Height = p.Height.Value,
                Width = p.Width.Value,
                Lenght = p.Lenght.Value,
                QuantityPerBox = p.QuantityPerBox.Value
            }).ToList();

            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("Product");
                sheet.Cells.LoadFromCollection(data, true);
                package.Save();
            }
            stream.Position = 0;
            string fileName = $"Product_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        public IActionResult ExampleFile()
        {
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("Product");
                //set chiều dài cho columm
                sheet.DefaultColWidth = 15;
                //set tự xuống dòng nếu text dài quá
                sheet.Cells.Style.WrapText = true;
                sheet.Cells[1, 1].Value = "Product Id";
                sheet.Cells[1, 2].Value = "Product Name";
                sheet.Cells[1, 3].Value = "Weight";
                sheet.Cells[1, 4].Value = "Image";
                sheet.Cells[1, 5].Value = "Description";
                sheet.Cells[1, 6].Value = "Height";
                sheet.Cells[1, 7].Value = "Width";
                sheet.Cells[1, 8].Value = "Length";
                sheet.Cells[1, 9].Value = "Quantity Per Box";
                sheet.Cells[1, 10].Value = "Category";
                sheet.Cells[1, 11].Value = "Vendor";
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
            if (fImport == null || fImport.Length <= 0)
            {
                ViewBag.EmptyFileMessage = "File is not existed or fail to upload";
                return View();
            }
            List<Product> productImports = new List<Product>();
            //tạo stream giữ file upload lên
            using(var stream = new MemoryStream())
            {
                fImport.CopyTo(stream);

                //Map stream với Excel file
                using(var package = new ExcelPackage(stream))
                {
                    var sheet = package.Workbook.Worksheets[0];
                    int rowCount = sheet.Dimension.Rows;

                    //duyệt qua từng dòng của sheet Excel bóc tách dữ liệu ra
                    for(int i = 2; i <= rowCount; i++)
                    {
                        productImports.Add(new Product
                        {
                            ProductId = sheet.Cells[i, 1].Value.ToString(),
                            ProductName = sheet.Cells[i, 2].Value.ToString(),
                            Weight = double.Parse(sheet.Cells[i, 3].Value.ToString()),
                            Image = sheet.Cells[i, 4].Value.ToString(),
                            Description = sheet.Cells[i, 5].Value.ToString(),
                            Height = double.Parse(sheet.Cells[i, 6].Value.ToString()),
                            Width = double.Parse(sheet.Cells[i, 7].Value.ToString()),
                            Lenght = double.Parse(sheet.Cells[i, 8].Value.ToString()),
                            QuantityPerBox = int.Parse(sheet.Cells[i, 9].Value.ToString()),
                            CategoryId = int.Parse(sheet.Cells[i, 10].Value.ToString()),
                            VendorId = int.Parse(sheet.Cells[i, 11].Value.ToString())
                        });
                    }
                }
            }
            if(productImports.Count > 0)
            {
                //tiến hành update hoặc insert
                foreach (Product product in productImports)
                {
                    var item = ctx.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                    var itemNameExist = ctx.Products.Any(p => p.ProductName == product.ProductName);
                    if (item != null)//đã có --> update
                    {
                        if (!itemNameExist)
                        {
                            item.ProductId = product.ProductId;
                            item.ProductName = product.ProductName;
                            item.Weight = product.Weight;
                            item.Image = product.Image;
                            item.Description = product.Description;
                            item.Height = product.Height;
                            item.Width = product.Width;
                            item.Lenght = product.Lenght;
                            item.QuantityPerBox = product.QuantityPerBox;
                            item.CategoryId = product.CategoryId;
                            item.VendorId = product.VendorId;
                        } else
                        {
                            ViewBag.ProductNameExist = "Product name is already existed !!!!";
                            return View();
                        }
                    }
                    else
                    {
                        if (!itemNameExist)
                        {
                            ctx.Add(product);
                        } else
                        {
                            ViewBag.ProductNameExist = "Product name is already existed !!!!";
                            return View();
                        }
                    }
                }
                ctx.SaveChanges();
            }
            ViewBag.SuccessMessage = "Import successfully";
            return View();
        }
    }
}