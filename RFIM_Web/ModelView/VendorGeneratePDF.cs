using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class VendorGeneratePDF
    {
        public static string GetHTMLString()
        {
            var ctx = new MyDbContext();
            var vendors = ctx.Vendors.ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>VENDOR LIST</h1></div>
                                <table align='center' border='1'>
                                    <tr>
                                        <th>Vendor ID</th>
                                        <th>Vendor Name</th>
                                        <th>Description</th>
                                    </tr>");
            foreach (var ven in vendors)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  ", ven.VendorId, ven.VendorName, ven.Description);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
