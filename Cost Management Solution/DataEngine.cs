using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cost_Management_Solution
{
    class DataEngine
    {
        public static List<Product> ProcessProposalFile(String fileName)
        {
            List<Product> resultsList = new List<Product>();
            //Check for file type 
            String fileExt = fileName.Substring(fileName.IndexOf("."));
            string[] lines = fileExt.Equals(".xlsx") ? DataHelper.convertToCsv(fileName) : File.ReadAllLines(fileName);
            List<Product> productList = new List<Product>();
            //Determine where header line is
            BroadJumpMap head = new BroadJumpMap(lines);
            
            for (int i=2; i < lines.Length; i++)
            {
                 Product currentItem = new Product();
               
                PriceChecker priceData = new PriceChecker(lines[i], head);
                currentItem.ManufactureId = priceData.ManufactureId;
                currentItem.PriceCompare = priceData;
                resultsList.Add(currentItem);
                
            }

            return resultsList;
        }

        public static List<Product> ProcessDataFile(String fileName)
        {
            List<Product> resultsList = new List<Product>();
            //Check for file type 
            String fileExt = fileName.Substring(fileName.IndexOf("."));
            //TODO: YOU NEED TO ADD CORRECT LOGIC HERE SO THAT ONCE YOU SAVE THE FILE AS CSV YOU TO NEED THEN PROCESS IT
            //      RIGHT NOW ITS DOING NOTHING BECAUSE OF THE IF STATEMENTS

            string[] lines = fileExt.Equals(".xlsx") ? DataHelper.convertToCsv(fileName) : File.ReadAllLines(fileName);
                Console.WriteLine("Processing text file:");
               
                List<Product> productList = new List<Product>();
            SIMap head = new SIMap(lines[0].Split(new char[] { '\t' }));
            Boolean headerFlag = true;
            foreach (string line in lines)
                {
                if (headerFlag)
                {
                    headerFlag = false;
                } else { 

                    string[] col = line.Split(new char[] { '\t' });
                // process col[0], col[1], col[2]
                //Identify headers

                        Product currentItem = new Product();
                    currentItem.ProductId = col[head.ProductIdColumn];
                    currentItem.ManufactureId = col[head.ManufactureIdColumn];
                    currentItem.ManufactureName = col[head.ManufactureNameColumn];
                    currentItem.ContractId = col[head.ContractIdColumn];
                    currentItem.Description = col[head.DescriptionColumn];
                    currentItem.GlAccount = col[head.GlAccountColumn];
                    currentItem.Packaging = getDefaultPackaging(col[head.PackagingColumn], col[head.UnitOfMeasureColumn]);
                    currentItem.PackagingString = formatPkgString(col[head.PackagingColumn]);
                    currentItem.Quantity = Double.Parse(col[head.QuantityColumn]);
                    currentItem.UnspscCode = col[head.UnspscCodeColumn];
                    currentItem.UnitOfMeasure = col[head.UnitOfMeasureColumn];
                    currentItem.VendorName = col[head.VendorNameColumn];
                    currentItem.PoDate = DateTime.Parse(col[head.PoDateColumn]);
                    currentItem.FacilityName = col[head.FacNameColumn];
                    String formatedPrice = col[head.PriceColumn];
                    formatedPrice = formatedPrice.Replace("$", "");
                        formatedPrice = formatedPrice.Replace(",", "");
                        formatedPrice = formatedPrice.Replace("\"", "");
                        formatedPrice = formatedPrice.Replace(" ", "");
                        currentItem.Price = Double.Parse(formatedPrice);
                    int packagingNum;
                    packagingNum=int.TryParse(currentItem.Packaging, out packagingNum) ? int.Parse(currentItem.Packaging) : 1;
                    Double eachPice = currentItem.Price / packagingNum;
                    currentItem.EachPrice = eachPice;
                        productList.Add(currentItem);
                    }
                    
                }
                //Sort the list by manufacture number
                productList = productList.OrderBy(o => o.ManufactureId).ToList();
                //Now group that same list by manufacture number and loop over those items
                var groupList = productList.GroupBy(x => x.ManufactureId);
               
                foreach (var group in groupList)
                {
                    //Each group should be a new product
                    Product groupProduct = new Product();
                    foreach (Product item in group)
                    {
                    // Here is where we can make a new list that contains the consolidated values
                    // of all the products and usage on one product line.

                    //**************************
                    //Need to add validation rules such as how to get correct price
                    //***************************
                        groupProduct.ProductId = item.ProductId;
                        groupProduct.ContractId = item.ContractId;
                        groupProduct.Description = item.Description;
                        groupProduct.GlAccount = item.GlAccount;
                        groupProduct.ManufactureId = item.ManufactureId;
                        groupProduct.ManufactureName = item.ManufactureName;
                        groupProduct.Packaging = item.Packaging;
                        groupProduct.UnitOfMeasure = item.UnitOfMeasure;
                        groupProduct.PoDate = item.PoDate;
                        groupProduct.EachPrice = item.EachPrice;
                        groupProduct.Price = item.Price;
                        groupProduct.UnspscCode = item.UnspscCode;
                        groupProduct.VendorName = item.VendorName;
                        groupProduct.Quantity = item.Quantity;
                        groupProduct.FacilityName = item.FacilityName;
                        groupProduct.setFacilityUsage();
                    }
                    resultsList.Add(groupProduct);
                }
                
               
            
            return resultsList;
        }
        public static String formatPkgString(String text)
        {
            StringBuilder sb = new StringBuilder("");
            string[] items = text.Split(new char[] { ';' });
            foreach (String item in items)
            {
                if(!item.Contains("(Derived Value)") || !item.Contains("(GPO Contract)") || !item.Contains("(Vendor Provided)") || !item.Contains("(Distributor)"))
                {
                    sb.Append(item + ";");
                }
            }
           
            return sb.ToString();
        }
        public static String getDefaultPackaging(String text, String defaultText)
        {
            string[] items = text.Split(new char[] { ';' });
            String results = "";
            //if we only have one item then just take the only choice
            if (items.Length == 1)
            {
                results = getMeasure(items[0]);
            }
            else
            {
                foreach (String item in items)
                {


                    if (item.Contains(defaultText))
                    {
                        results = getMeasure(item);

                    }
                }
            }

            //Add special cases here for mismatch measurement types
            //Each is always going to be one
            if (defaultText.Equals("EA"))
            {
                results = "1";

            }
            if (defaultText.Equals("DZ"))
            {
                results = "12";

            }
            //If we have case CA then we are going to take the largest measure which
            //is last element
            if (defaultText.Equals("CA"))
            {
                results = getMeasure(items[items.Length]);
            }

            return results;
        }
        public static String getMeasure(String text)
        {
            return text.Substring(text.IndexOf("-") + 1);
        }
        public static String getValue(Excel.Worksheet sheet, int row, int column)
        {
            return sheet.Cells[row, column].Value.ToString();
        }
        public static int getColumn(Excel.Range searchRange, String name)
        {
            Excel.Range columnRange = search(searchRange, name);
            return columnRange.Column;
        }
        public static Excel.Range search(Excel.Range searchRange, String searchText)
        {
            Excel.Range resultRange = searchRange.Find(

               What: searchText,

               LookIn: Excel.XlFindLookIn.xlValues,

               LookAt: Excel.XlLookAt.xlWhole,

               SearchOrder: Excel.XlSearchOrder.xlByRows,

               SearchDirection: Excel.XlSearchDirection.xlNext

               );// search searchString in the range, if find result, return a range
            return resultRange;
        }
        public static void ExportToWorkbook(Initiative initObject)
        {

        }
    }
}

