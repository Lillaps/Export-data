using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ExportToExcel : Export
    {
        public void ExportToFile(User user, List<User> ListUsers)
        {

            string excelFile = @"usersE.xls";
            FileInfo fileInf = new FileInfo(excelFile);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            int k = ListUsers.Count;
            for (int i = 1; i <= k; i++)
            {
                workSheet.Cells[i, 1].Value = ListUsers[i - 1].Date;
                workSheet.Cells[i, 2].Value = ListUsers[i - 1].FirstName;
                workSheet.Cells[i, 3].Value = ListUsers[i - 1].LastName;
                workSheet.Cells[i, 4].Value = ListUsers[i - 1].SurName;
                workSheet.Cells[i, 5].Value = ListUsers[i - 1].City;
                workSheet.Cells[i, 6].Value = ListUsers[i - 1].Country;
            }
            //FileInfo fileInf = new FileInfo(excelFile);
            //fileInf.Delete();
            //if (fileInf.Exists)
            //{
            //    workBook.Save();
            //}
            //else workBook.SaveAs(excelFile);
            workBook.SaveAs(excelFile);
            //workBook.Save();

            //вывод в окне
            //excelApp.Visible = true;
            //excelApp.UserControl = true;
        }
    }
}
