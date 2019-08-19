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
        Invoice GetSingleInvoiceDetail(string id);
        void WipeInvoiceProduct(string id);
        InvoiceType getPrefix(int typeId);
        void UpdatePrefix(InvoiceType invoiceType);
        List<Invoice> GetPendingInvoice(int typeId);
        List<Invoice> GetAllHistory();
        List<ProductList> GetProductInvoiceDetail(string id);
        bool CheckInvoiceDupp(Invoice invoice);
        void AddInvoice(Invoice invoice);
        void AddInvoice_Product(Invoice_Product ip);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoiceOnCancel(string id);
        void DeleteInvoiceOnAction(string id);
        SelectList GetSelectList();
<<<<<<< HEAD
        User findUserById(int? user);
=======
        int findUserByName(int? user);
        int findUserIdByName(string username);
>>>>>>> dev_test5
    }
}
