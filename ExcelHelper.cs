using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace MathSoftCommonLib
{
   public class ExcelHelper
   {
        #region 从Excel中取出数据
        /// <summary>
        /// 永远都不要做重复性的工作
        /// 从Excel中取出数据。这个类库需要驱动程序。在个程序的驱动程序位于马良的希捷硬盘
        /// H:\软件\windows软件\开发工具（7）\office开发\驱动程序office2007下分别安装64位或者32位
        /// 
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <param name="sheetName">Sheet1页面名称</param>
        /// <returns>datatable</returns>
        public static DataTable TransExcelToTable(string fileName, string sheetName)
       {
           string connFrom = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1';";

           DataTable dt1 = new DataTable();
           using (OleDbConnection thisconnection = new OleDbConnection(connFrom))
           {
               thisconnection.Open();
               string Sql = "select * from [" + sheetName + "$]";
               OleDbDataAdapter mycommand = new OleDbDataAdapter(Sql, thisconnection);
               dt1 = new DataTable();
               mycommand.Fill(dt1);
               thisconnection.Close();
           }
           return dt1;
       }
       #endregion

   }
}
