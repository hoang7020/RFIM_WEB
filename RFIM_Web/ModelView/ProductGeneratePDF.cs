using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class ProductGeneratePDF
    {
        public static string GetHTMLString()
        {
            var ctx = new MyDbContext();
            var products = ctx.Products.ToList();
            
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>PRODUCT LIST</h1></div>
                                <table align='center' border='1'>
                                    <tr>
                                        <th>Product ID</th>
                                        <th>Product Name</th>
                                        <th>Quantity Box</th>
                                        <th>Quantity Per Box</th>
                                        <th>Weight</th>
                                        <th>Height</th>
                                        <th>Width</th>
                                        <th>Length</th>
                                        <th>Cell</th>
                                    </tr>");

            foreach (var pro in products)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                    <td>{6}</td> 
                                    <td>{7}</td>
                                    <td>{8}</td>
                                  ", pro.ProductId, pro.ProductName, BoxCount(pro.ProductId), pro.QuantityPerBox ,pro.Weight, pro.Height, pro.Width
                                  ,pro.Lenght, CellList(pro.ProductId));
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }

        public static int BoxCount(string productId)
        {
            var ctx = new MyDbContext();
            int boxCount = ctx.Boxes.Count(p => p.ProductId == productId);
            return boxCount;
        }

        public static string CellList(string productId)
        {
            var ctx = new MyDbContext();
            var packages = ctx.Packages.Where(p => p.ProductId == productId).ToList();
            string cell_string = "";
            packages.ForEach(item =>
            {
                cell_string += item.CellId;
                cell_string += "<br/>";
            });
            return cell_string;
        }
    }
}
