using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LW1
{
    public class HTMLReportBuilder
    {
        private string GetDocumentStructure(string title, string body)
        {
            return "<!DOCTYPE HTML> <html> <head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" /><title>"+
                title + "</title>" + GetStyles() + "</head><body>" + body + "</body></html>";
        }

        private string GetStyles()
        {
            return "<style>body{font-size:16px}table>caption{text-indent:1.5em;text-align:justify} table tr{text-align:center}table tr:nth-child(odd){background:rgba(68,108,179,.37)}table tr>th{background:#fff;border-top:2px solid rgba(68,108,179,1);border-bottom:2px solid rgba(68,108,179,1)}table tr:hover{background:rgba(68,108,179,.67)}table td:not(:first-child){border-left:1px solid #fff}table.values tr>td:nth-child(4n+4),table.values tr>th:nth-child(4n+4){width: 10px;background: #fff;}</style>";
        }

        private string GetTableStructure(string rows, string caption, string styleClass = "")
        {
            return "<table class=\""+styleClass+"\" cellspacing=\"0\" width=\"100%\"><caption>" + caption + "</caption>" + rows + "</table>"; ;
        }

        private string GetTableRow(params string[] columnValues)
        {
            var sb = new StringBuilder("<tr>");

            foreach (var value in columnValues)
            {
                sb.Append("<td>" + value + "</td>");
            }

            return sb.ToString();
        }

        private string GetHeadings(int headingLevel, string value, string align="center")
        {
            return String.Format("<h{0} align=\"{1}\">{2}</h{0}>", headingLevel, align, value);
        }

        public string GetDataReport(Dictionary<double, double> data, int columnsCount = 5)
        {
            int rowscount = (int)Math.Ceiling(data.Count / (double) columnsCount);
            
            var th = new StringBuilder("<tr>");
            
            for (int i = 0; i < columnsCount; i++)
            {
                th.Append("<th>№</th><th>X</th><th>Y</th>");
                if (i != columnsCount - 1) th.Append("<th>  </th>");
            }
            
            var rows = new StringBuilder(th.ToString()+"</tr>");

            for (int i = 0; i < rowscount; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < columnsCount; j++)
                {
                    int index = i + (j * rowscount);
                    row.Add(index+1+"");
                    row.Add(index < data.Count ? String.Format("{0:0.000}", data.Keys.ElementAt(index)) : "");
                    row.Add(index < data.Count ? String.Format("{0:0.000}", data.Values.ElementAt(index)) : "");
                    if (j != columnsCount-1) row.Add(" ");
                }
                rows.Append(GetTableRow(row.ToArray()));
            }

            return GetDocumentStructure("Данные", GetTableStructure(rows.ToString(), "Таблица 1 - Исходные данные", "values"));
        }
    }
}
