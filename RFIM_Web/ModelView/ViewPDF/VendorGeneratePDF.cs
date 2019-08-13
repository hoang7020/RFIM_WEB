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
<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css'>
                            </head>
                            <body>
                                <div class='header'><h1>VENDOR LIST</h1></div>
                                <table class='table table-bordered'>
<thead>
                                    <tr>
                                        <th>Vendor ID</th>
                                        <th>Vendor Name</th>
                                        <th>Description</th>
                                    </tr></thead>");
            foreach (var ven in vendors)
            {
                sb.AppendFormat(@"<tbody><tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
</tr>
                                   </tbody>
                                  ", ven.VendorId, ven.VendorName, ven.Description);
            }
            sb.Append(@"
                                </table>
                            </body>
 <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js'></script
                            <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js'></script>
                        </html>");
            return sb.ToString();
        }
    }
}
