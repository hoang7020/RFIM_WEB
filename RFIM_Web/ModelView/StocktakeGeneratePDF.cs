using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class StocktakeGeneratePDF
    {
        public static string GetHTMLString()
        {
            var ctx = new MyDbContext();
            var stocktakes = ctx.StocktakeHistories.Include(p => p.Product).ToList();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>STOCKTAKE LIST</h1></div>
                                <table align='center' border='1'>
                                    <tr>
                                        <th>Stocktake ID</th>
                                        <th>Product ID</th>
                                        <th>Product Name</th>
                                        <th>Actual Quantity</th>
                                        <th>Current Stock</th>
                                        <th>Date</th>
                                        <th>Description</th>
                                    </tr>");
            foreach (var st in stocktakes)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                    <td>{6}</td>
                                  ", st.StocktakeHistoryId, st.ProductId, st.Product.ProductName,
                                  st.Quantity, QuantityOfProduct(st.ProductId),st.Date);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }

        public static int QuantityOfProduct(string productId)
        {
            var ctx = new MyDbContext();
            int proCount = ctx.Boxes.Count(p => p.ProductId == productId);
            return proCount;
        }
    }
}
