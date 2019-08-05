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
        List<ProductExtendAttr> GetProductInvoiceListStockOut();
        List<ProductExtendAttr> GetProductInvoiceListStockIn();
        List<ProductExtendAttr> FindProductInvoiceListStockIn(string id);
        List<ProductExtendAttr> FindProductInvoiceListStockOut(string id);
        ProductExtendAttr FindSingleProductInvoiceStockIn(string id);
        ProductExtendAttr FindSingleProductInvoiceStockOut(string id);
        Invoice FindInvoice(string id);
        Invoice GetSingleInvoiceDetail(string id);
        void WipeInvoiceProduct(string id);
        List<Invoice> GetAllInvoice();
        List<ProductList> GetProductInvoiceDetail(string id);
        bool CheckInvoiceDupp(Invoice invoice);
        void AddInvoice(Invoice invoice);
        void AddInvoice_Product(Invoice_Product ip);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoiceOnCancel(string id);
        void DeleteInvoiceOnAction(string id);
        SelectList GetSelectList();
        int findUserByName(string user);
    }
}
