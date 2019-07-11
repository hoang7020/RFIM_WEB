using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using RFIM_Web.ModelView;

namespace RFIM_Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly IConverter _converter;

        public ReportController( IConverter con)
        {
            _converter = con;
        }

        public IActionResult GeneratePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Product Inventory Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = ProductGeneratePDF.GetHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }

        public IActionResult CategoryPDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Category Inventory Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = CategoryGeneratePDF.GetHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }

        public IActionResult VendorPDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Vendor Inventory Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = VendorGeneratePDF.GetHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }

        public IActionResult ReceivePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Good Receive Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = InvoiceGeneratePDF.GetReceiveHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }
        public IActionResult IssuePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Good Issue Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = InvoiceGeneratePDF.GetIssueHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }
        public IActionResult StocktakePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Stocktake List Report"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = StocktakeGeneratePDF.GetHTMLString(),
                WebSettings = {
                                DefaultEncoding = "utf-8",
                                UserStyleSheet = Path.Combine(
                                            Directory.GetCurrentDirectory(), "assets", "styles.css")
             },
                HeaderSettings = {
                                FontName = "Arial", FontSize = 9,
                                Right = "Trang [page]/[toPage]", Line = true
             }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");
        }
    }
}