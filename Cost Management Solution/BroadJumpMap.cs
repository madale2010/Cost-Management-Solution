using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class BroadJumpMap
    {
        private int version;
        private int productIDCol;
        private int nameCol;
        private int skuCol;
        private int manufacturerCol;
        private int myUnitPriceCol;
        private int avgUnitPriceCol;
        private int belowAverageCol;
        private int categoryCol;
        private int lowestPriceCol;
        private int highestPriceCol;
        private int myUOMPriceCol;
        private int lowestUOMPriceCol;
        private int meanUOMPriceCol;
        private int highestUOMPriceCol;
        private int inputQtyCol;
        private int inputUOMCol;
        private int totalCol;
        private int isMyPriceCol;
        private int mmisNumCol;
        private int unitsPerUOMCol;
        private int annualUOMQtyCol;
        private int currentUOMWAPCol;
        private int annualVolumeCol;
        private int proposedUOMPriceCol;
        private int proposedVolumeCol;
        private int savingsAmountCol;
        private int savingsPercentCol;
        private String[] col;
        private String[] lines;

        public BroadJumpMap(string[] dataFile)
        {
            lines = dataFile;
            setHeaderLine();
            productIDCol = 0;
            nameCol = 0;
            skuCol = 0;
            manufacturerCol = 0;
            myUnitPriceCol = 0;
            avgUnitPriceCol = 0;
            belowAverageCol = 0;
            categoryCol = 0;
            lowestPriceCol = 0;
            highestPriceCol = 0;
            myUOMPriceCol = 0;
            lowestUOMPriceCol = 0;
            meanUOMPriceCol = 0;
            highestUOMPriceCol = 0;
            inputQtyCol = 0;
            inputUOMCol = 0;
            totalCol = 0;
            isMyPriceCol = 0;
            mmisNumCol = 0;
            unitsPerUOMCol = 0;
            annualUOMQtyCol = 0;
            currentUOMWAPCol = 0;
            annualVolumeCol = 0;
            proposedUOMPriceCol = 0;
            proposedVolumeCol = 0;
            savingsAmountCol = 0;
            savingsPercentCol = 0;
            col = lines[version].Split(new char[] { ',' });
            mapHeaders();
        }

        public int Version { get => version; set => version = value; }
        public int ProductIDCol { get => productIDCol; set => productIDCol = value; }
        public int NameCol { get => nameCol; set => nameCol = value; }
        public int SkuCol { get => skuCol; set => skuCol = value; }
        public int ManufacturerCol { get => manufacturerCol; set => manufacturerCol = value; }
        public int MyUnitPriceCol { get => myUnitPriceCol; set => myUnitPriceCol = value; }
        public int AvgUnitPriceCol { get => avgUnitPriceCol; set => avgUnitPriceCol = value; }
        public int BelowAverageCol { get => belowAverageCol; set => belowAverageCol = value; }
        public int CategoryCol { get => categoryCol; set => categoryCol = value; }
        public int LowestPriceCol { get => lowestPriceCol; set => lowestPriceCol = value; }
        public int HighestPriceCol { get => highestPriceCol; set => highestPriceCol = value; }
        public int MyUOMPriceCol { get => myUOMPriceCol; set => myUOMPriceCol = value; }
        public int LowestUOMPriceCol { get => lowestUOMPriceCol; set => lowestUOMPriceCol = value; }
        public int MeanUOMPriceCol { get => meanUOMPriceCol; set => meanUOMPriceCol = value; }
        public int HighestUOMPriceCol { get => highestUOMPriceCol; set => highestUOMPriceCol = value; }
        public int InputQtyCol { get => inputQtyCol; set => inputQtyCol = value; }
        public int InputUOMCol { get => inputUOMCol; set => inputUOMCol = value; }
        public int TotalCol { get => totalCol; set => totalCol = value; }
        public int IsMyPriceCol { get => isMyPriceCol; set => isMyPriceCol = value; }
        public int MmisNumCol { get => mmisNumCol; set => mmisNumCol = value; }
        public int UnitsPerUOMCol { get => unitsPerUOMCol; set => unitsPerUOMCol = value; }
        public int AnnualUOMQtyCol { get => annualUOMQtyCol; set => annualUOMQtyCol = value; }
        public int CurrentUOMWAPCol { get => currentUOMWAPCol; set => currentUOMWAPCol = value; }
        public int AnnualVolumeCol { get => annualVolumeCol; set => annualVolumeCol = value; }
        public int ProposedUOMPriceCol { get => proposedUOMPriceCol; set => proposedUOMPriceCol = value; }
        public int ProposedVolumeCol { get => proposedVolumeCol; set => proposedVolumeCol = value; }
        public int SavingsAmountCol { get => savingsAmountCol; set => savingsAmountCol = value; }
        public int SavingsPercentCol { get => savingsPercentCol; set => savingsPercentCol = value; }
        public string[] Col { get => col; set => col = value; }
        public string[] Lines { get => lines; set => lines = value; }

        private void mapHeaders()
        {
            //Determine which version file is coming in by counting col
            Console.WriteLine("Number of BroadJump Cols is " + col.Length);
            for (int i = 0; i < col.Length; i++)
            {
                switch (col[i])
                {
                    case Constants.BJHeaders.PRODUCTID:
                        productIDCol = i;
                        break;

                    case Constants.BJHeaders.NAME:
                        nameCol = i;
                        break;

                    case Constants.BJHeaders.SKU:
                        skuCol = i;
                        break;

                    case Constants.BJHeaders.MANUFACTURER:
                        manufacturerCol = i;
                        break;

                    case Constants.BJHeaders.MY_UNIT_PRICE:
                        myUnitPriceCol = i;
                        break;

                    case Constants.BJHeaders.AVG_UNIT_PRICE:
                        avgUnitPriceCol = i;
                        break;

                    case Constants.BJHeaders.BELOW_AVERAGE:
                        belowAverageCol = i;
                        break;

                    case Constants.BJHeaders.CATEGORY:
                        categoryCol = i;
                        break;

                    case Constants.BJHeaders.LOWESTPRICE:
                        lowestPriceCol = i;
                        break;

                    case Constants.BJHeaders.HIGHESTPRICE:
                        highestPriceCol = i;
                        break;

                    case Constants.BJHeaders.MYUOMPRICE:
                        myUOMPriceCol = i;
                        break;

                    case Constants.BJHeaders.LOWESTUOMPRICE:
                        lowestUOMPriceCol = i;
                        break;

                    case Constants.BJHeaders.MEANUOMPRICE:
                        meanUOMPriceCol = i;
                        break;

                    case Constants.BJHeaders.HIGHESTUOMPRICE:
                        highestUOMPriceCol = i;
                        break;

                    case Constants.BJHeaders.INPUTQTY:
                        inputQtyCol = i;
                        break;

                    case Constants.BJHeaders.INPUTUOM:                        inputUOMCol= i;
                        break;

                    case Constants.BJHeaders.TOTAL:
                        totalCol = i;
                        break;

                    case Constants.BJHeaders.ISMYPRICE_:
                        isMyPriceCol = i;
                        break;

                    case Constants.BJHeaders.MMIS_NUM:
                        mmisNumCol = i;
                        break;

                    case Constants.BJHeaders.UNITS_PER_UOM:
                        unitsPerUOMCol = i;
                        break;

                    case Constants.BJHeaders.ANNUAL_UOM_QTY:
                        annualUOMQtyCol = i;
                        break;

                    case Constants.BJHeaders.CURRENT_UOM_WAP:
                        currentUOMWAPCol = i;
                        break;

                    case Constants.BJHeaders.ANNUAL_VOLUME:
                        annualVolumeCol = i;
                        break;

                    case Constants.BJHeaders.PROPOSED_UOM_PRICE:
                        proposedUOMPriceCol = i;
                        break;

                    case Constants.BJHeaders.PROPOSED_VOLUME:
                        proposedVolumeCol = i;
                        break;

                    case Constants.BJHeaders.SAVINGS_AMOUNT:
                        savingsAmountCol = i;
                        break;

                    case Constants.BJHeaders.SAVINGS_PERCENT:
                        savingsPercentCol = i;
                        break;
                }
            }
        }
        public void setHeaderLine()
        {
            String[] tempCol = lines[0].Split(new char[] { ',' });
            version = tempCol.Contains("ProductID") ? 0 : 1;
        }
    }
}
