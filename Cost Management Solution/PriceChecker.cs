using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class PriceChecker
    {
        private String manufactureId;
        private Double unitPrice;
        private Double avgUnitPrice;
        private Double minPrice;
        private Double maxPrice;
        private Double minUOMPrice;
        private Double avgUOMPrice;
        private Double maxUOMPrice;
        private Double quantity;
        private String unitOfMeasure;
        public PriceChecker(String line, BroadJumpMap head)
        {
            string[] col = line.Split(new char[] { ',' });
            manufactureId = col[head.SkuCol];
            unitPrice = Double.Parse(col[head.MyUnitPriceCol]);
            avgUnitPrice = Double.Parse(col[head.AvgUnitPriceCol]);
            minPrice = Double.Parse(col[head.LowestPriceCol]);
            maxPrice = Double.Parse(col[head.HighestPriceCol]);
            minUOMPrice = Double.Parse(col[head.LowestUOMPriceCol]);
            avgUOMPrice = Double.Parse(col[head.MeanUOMPriceCol]);
            maxUOMPrice = Double.Parse(col[head.HighestUOMPriceCol]);
            quantity = Double.Parse(col[head.InputQtyCol]);
            unitOfMeasure = col[head.InputUOMCol];
        }
        public string ManufactureId { get => manufactureId; set => manufactureId = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double AvgUnitPrice { get => avgUnitPrice; set => avgUnitPrice = value; }
        public double MinPrice { get => minPrice; set => minPrice = value; }
        public double MaxPrice { get => maxPrice; set => maxPrice = value; }
        public double MinUOMPrice { get => minUOMPrice; set => minUOMPrice = value; }
        public double AvgUOMPrice { get => avgUOMPrice; set => avgUOMPrice = value; }
        public double MaxUOMPrice { get => maxUOMPrice; set => maxUOMPrice = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public String UnitOfMeasure { get => unitOfMeasure; set => unitOfMeasure = value; }
    }
}
