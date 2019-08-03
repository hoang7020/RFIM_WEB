using Microsoft.EntityFrameworkCore;
using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public static class InvoiceGeneratePDF
    {
        public static string GetReceiveHTMLString()
        {
            var ctx = new MyDbContext();
            var receives = ctx.Invoices
                .Where(p => p.InvoiceTypeId == 1 && (p.StatusId == 1 || p.StatusId == 2)).ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                                <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css'>
                            </head>
                            <body>
                                <div class='header'><h1>GOOD RECEIPT LIST</h1></div>
                                <table class='table table-bordered'>
                                    <thead>
                                        <tr>
                                            <th>Invoice ID</th>
                                            <th>Date</th>
                                            <th>Description</th>
                                            <th>Status</th>
                                        </tr>
                                    </thead>");
            foreach (var receive in receives)
            {
                sb.AppendFormat(@"<tbody>
                                    <tr>
                                        <td>{0}</td>
                                        <td>{1}</td>
                                        <td>{2}</td>
                                        <td>{3}</td>
                                    </tr>
                                   </tbody>
                                  ", receive.InvoiceId, receive.Date, receive.Description, GetStatusReceive(receive.StatusId));
            }
            sb.Append(@"
                                </table>
                            </body>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js'></script
                            <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js'></script>
                        </html>");
            return sb.ToString();
        }

        public static string GetStatusReceive(int id)
        {
            var ctx = new MyDbContext();
            string status = (id == 1) ? "Pending" : "Processing";
            return status;
        }

        public static string GetIssueHTMLString()
        {
            var ctx = new MyDbContext();
            var issues = ctx.Invoices
                .Where(p => p.InvoiceTypeId == 2 && (p.StatusId == 1 || p.StatusId == 2)).ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                                <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css'>
                            </head>
                             <body>
                                <div class='header'><h1>GOOD ISSUE LIST</h1></div>
                                <table class='table table-bordered'>
                                    <thead>
                                        <tr>
                                            <th>Invoice ID</th>
                                            <th>Date</th>
                                            <th>Description</th>
                                            <th>Status</th>
                                        </tr>
                                    </thead>");
            foreach (var issue in issues)
            {
                sb.AppendFormat(@"<tbody>
                                    <tr>
                                        <td>{0}</td>
                                        <td>{1}</td>
                                        <td>{2}</td>
                                        <td>{3}</td>
                                    </tr>
                                   </tbody>
                                  ", issue.InvoiceId, issue.Date, issue.Description, GetStatusIssue(issue.StatusId));
            }
            sb.Append(@"
                                </table>
                            </body>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js'></script
                            <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js'></script>
                        </html>");
            return sb.ToString();
        }
        public static string GetStatusIssue(int id)
        {
            var ctx = new MyDbContext();
            string status = (id == 1) ? "Pending" : "Processing";
            return status;
        }
    }
}

