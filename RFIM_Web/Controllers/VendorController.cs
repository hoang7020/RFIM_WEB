using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFIM_Web.Interfaces;
using RFIM_Web.Models;

namespace RFIM_Web.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepository _ctx;

        public VendorController(IVendorRepository _db)
        {
            _ctx = _db;
        }

        public IActionResult ListAllVendor()
        {
            return View(_ctx.GetAllVendor());
        }

        public IActionResult CreateVendor()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateVendor(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                if (_ctx.VendorNameExists(vendor.VendorName))
                {
                    ViewBag.vendorExist = "Vendor name is already existed!";
                    return View("CreateVendor", vendor);
                }
                vendor.Status = true;
                _ctx.CreateVendor(vendor);
                return RedirectToAction(nameof(ListAllVendor));
            }
            return View(vendor);
        }
        [HttpGet]
        public IActionResult EditVendor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vendor = _ctx.FindVendorById(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditVendor(int id, Vendor vendor)
        {
            if (id != vendor.VendorId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (_ctx.VendorNameExistsExceptId(vendor.VendorId, vendor.VendorName))
                {
                    ViewBag.vendorExist = "Vendor name is already existed!";
                    return View("CreateVendor", vendor);
                }
                else
                {
                    try
                    {
                        vendor.Status = true;
                        _ctx.UpdateVendor(vendor);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!VendorExist(vendor.VendorId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return RedirectToAction(nameof(ListAllVendor));
            }
            return View(vendor);
        }

        [HttpGet]
        public IActionResult ActiveVendor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vendor = _ctx.GetVendor(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return PartialView("ActiveVendor", vendor);
        }

        [HttpPost, ActionName("ActiveVendor")]
        [ValidateAntiForgeryToken]
        public IActionResult ActiveVendorConfirmed(int id)
        {
            var vendor = _ctx.FindVendorById(id);
            _ctx.ActiveVendor(vendor);
            return RedirectToAction(nameof(ListAllVendor));
        }
        [HttpGet]
        public IActionResult DeleteVendor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vendor = _ctx.GetVendor(id);
            if (vendor == null)
            {
                return NotFound();
            }
            var vendorExistInProduct = _ctx.VendorExistsInProduct(id);
            if (vendorExistInProduct)
            {
                return PartialView("DeactiveFail", vendor);
            }
            else
            {
                return PartialView("DeleteVendor", vendor);
            }
        }

        [HttpPost, ActionName("DeleteVendor")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVendorConfirm(int id)
        {
            var category = _ctx.FindVendorById(id);
            _ctx.DeactiveVendor(category);
            return RedirectToAction(nameof(ListAllVendor));
        }

        private bool VendorExist(int id)
        {
            return _ctx.VendorExists(id);
        }

        public IActionResult BackToListVendor()
        {
            return RedirectToAction(nameof(ListAllVendor));
        }
    }
}