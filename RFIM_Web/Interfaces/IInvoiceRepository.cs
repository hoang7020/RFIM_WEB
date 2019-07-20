using Microsoft.AspNetCore.Mvc.Rendering;
using RFIM_Web.Models;
using RFIM_Web.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Interfaces
{
    public interface IInvoiceRepository
    {
        List<ProductExtendAttr> GetProductInvoiceList();
        ProductExtendAttr FindSingleProductInvoice(string id);
        List<Invoice> GetAllInvoice();
        List<ProductList> GetProductInvoiceDetail(string id);
        Invoice GetSingleInvoiceDetail(string id);
        bool CheckInvoiceDupp(Invoice invoice);
        void AddInvoice(Invoice invoice);
        void AddInvoice_Product(Invoice_Product ip);
        void DeleteInvoiceOnCancel(string id);
        void DeleteInvoiceOnAction(string id);
        SelectList GetSelectList();
    }
}
