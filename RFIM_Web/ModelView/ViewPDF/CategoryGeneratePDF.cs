using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class CategoryGeneratePDF
    {
        public static string GetHTMLString()
        {
            var ctx = new MyDbContext();
            var categories = ctx.Categories.ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css'>
                            </head>
                            <body>
                                <div class='header'><h1>CATEGORY LIST</h1></div>
                                <table class='table table-bordered'>
<thead>
                                    <tr>
                                        <th>Category ID</th>
                                        <th>Category Name</th>
                                        <th>Description</th>
                                    </tr>
</thead>");
            foreach (var cat in categories)
            {
                sb.AppendFormat(@"<tbody><tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
 </tr>
                                   </tbody>
                                  ", cat.CategoryId, cat.CategoryName, cat.Description);
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
