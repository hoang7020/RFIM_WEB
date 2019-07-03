using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var ctx = new MyDbContext();
            var categories = ctx.Categories.ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>DANH SÁCH LOẠI</h1></div>
                                <table align='left'>
                                    <tr>
                                        <th>Mã loại</th>
                                        <th>Tên loại</th>
                                        <th>Mô tả</th>
                                    </tr>");

            foreach (var cat in categories)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  </tr>", cat.CategoryId, cat.CategoryName, cat.Description);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
