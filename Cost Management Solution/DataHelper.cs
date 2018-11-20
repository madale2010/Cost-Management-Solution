using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel =Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace Cost_Management_Solution
{
    class DataHelper
    {
        public static string[] convertToTab(String fileName)
        {
            String fileExt = fileName.Substring(fileName.IndexOf("."));
            
            if (fileExt.Equals(".csv"))
            {
                File.WriteAllLines(fileName, File.ReadAllLines(fileName).Select(line => line.Replace("\t", ",")));
            }
            else
            {
                Logger.log("File not in the correct format. " + fileName);
                
            }
            return File.ReadAllLines(fileName);
        }
            public static string[] convertToCsv(String fileName)
        {
            //Check for file type 
            String fileExt = fileName.Substring(fileName.IndexOf("."));
            string[] results = null;
            if (fileExt.Equals(".xlsx"))
            {

                Console.WriteLine("Starting on excel");
                Excel.Application excelApp = new Excel.Application();
                String convertedFileName = fileName.Substring(0, fileName.IndexOf(".")) + ".csv";
                Excel.Workbook dataWorkbook = excelApp.Workbooks.Open(fileName);
                Excel.Worksheet dataSheet = dataWorkbook.Sheets[1];

                dataWorkbook.SaveAs(convertedFileName, Excel.XlFileFormat.xlCurrentPlatformText);

                Console.WriteLine("Finished Processing excel file");
                
                dataWorkbook.Close(false);
                ReleaseComObject(dataSheet);
                ReleaseComObject(dataWorkbook);
                excelApp.Quit();
                ReleaseComObject(excelApp);
                results = File.ReadAllLines(convertedFileName);
                File.Delete(convertedFileName);
                return results;
            }
            else
            {
                Logger.log("File not in the correct format. " + fileName);
                return results;
            }
        }
        public static void ReleaseComObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
        }
    }
}
