﻿using Microsoft.EntityFrameworkCore;
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
                .Where(p => p.InvoiceTypeId == 1).ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>GOOD RECEIPT LIST</h1></div>
                                <table align='center' border='1'>
                                    <tr>
                                        <th>Invoice ID</th>
                                        <th>Date</th>
                                        <th>Description</th>
                                    </tr>");
            foreach (var receive in receives)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  ", receive.InvoiceId, receive.Date, receive.Description);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }

        public static string GetIssueHTMLString()
        {
            var ctx = new MyDbContext();
            var issues = ctx.Invoices
                .Where(p => p.InvoiceTypeId == 2).ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>GOOD ISSUE LIST</h1></div>
                                <table align='center' border='1'>
                                    <tr>
                                        <th>Invoice ID</th>
                                        <th>Date</th>
                                        <th>Description</th>
                                    </tr>");
            foreach (var issue in issues)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  ", issue.InvoiceId, issue.Date, issue.Description);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}