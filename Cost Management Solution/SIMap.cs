using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class SIMap
    {
        private int quantityColumn;
        private int priceColumn;
        private int productIdColumn;
        private int manufactureNameColumn;
        private int manufactureIdColumn;
        private int descriptionColumn;
        private int contractIdColumn;
        private int unitOfMeasureColumn;
        private int packagingColumn;
        private int glAccountColumn;
        private int vendorNameColumn;
        private int unspscCodeColumn;
        private int poDateColumn;
        private int facNameColumn;
        private string[] col;

        public SIMap(string[] inputCol)
        {
            quantityColumn = 0;
            priceColumn = 0;
            productIdColumn = 0;
            manufactureNameColumn = 0;
            manufactureIdColumn = 0;
            descriptionColumn = 0;
            contractIdColumn = 0;
            unitOfMeasureColumn = 0;
            packagingColumn = 0;
            glAccountColumn = 0;
            vendorNameColumn = 0;
            unspscCodeColumn = 0;
            poDateColumn = 0;
            facNameColumn = 0;
            col = inputCol;
            mapHeaders();
        }

        public int QuantityColumn { get => quantityColumn; set => quantityColumn = value; }
        public int PriceColumn { get => priceColumn; set => priceColumn = value; }
        public int ProductIdColumn { get => productIdColumn; set => productIdColumn = value; }
        public int ManufactureNameColumn { get => manufactureNameColumn; set => manufactureNameColumn = value; }
        public int ManufactureIdColumn { get => manufactureIdColumn; set => manufactureIdColumn = value; }
        public int DescriptionColumn { get => descriptionColumn; set => descriptionColumn = value; }
        public int ContractIdColumn { get => contractIdColumn; set => contractIdColumn = value; }
        public int UnitOfMeasureColumn { get => unitOfMeasureColumn; set => unitOfMeasureColumn = value; }
        public int PackagingColumn { get => packagingColumn; set => packagingColumn = value; }
        public int GlAccountColumn { get => glAccountColumn; set => glAccountColumn = value; }
        public int VendorNameColumn { get => vendorNameColumn; set => vendorNameColumn = value; }
        public int UnspscCodeColumn { get => unspscCodeColumn; set => unspscCodeColumn = value; }
        public int PoDateColumn { get => poDateColumn; set => poDateColumn = value; }
        public int FacNameColumn { get => facNameColumn; set => facNameColumn = value; }
        public string[] Col { get => col; set => col = value; }

        public void mapHeaders()
        {

            for (int i = 0; i < col.Length; i++)
            {
                switch (col[i])
                {
                    case Constants.SIHeaders.FACILITY_ITEM_NUMBER:
                        productIdColumn = i;
                        break;
                    case Constants.SIHeaders.DETAIL_GL_ACCOUNT:
                        glAccountColumn = i;
                        break;
                    case Constants.SIHeaders.MANUFACTURER_NAME:
                        manufactureNameColumn = i;
                        break;
                    case Constants.SIHeaders.MANUFACTURER_CATALOG_NUMBER:
                        manufactureIdColumn = i;
                        break;
                    case Constants.SIHeaders.PO_DATE:
                        poDateColumn = i;
                        break;
                    case Constants.SIHeaders.PO_QUANTITY:
                        quantityColumn = i;
                        break;
                    case Constants.SIHeaders.PO_PRICE:
                        priceColumn = i;
                        break;
                    case Constants.SIHeaders.INVOICE_PRICE:
                        priceColumn = i;
                        break;
                    case Constants.SIHeaders.ITEM_DESCRIPTION:
                        descriptionColumn = i;
                        break;
                    case Constants.SIHeaders.MANAGED_CONTRACT_NUMBER:
                        contractIdColumn = i;
                        break;
                    case Constants.SIHeaders.PO_UM:
                        unitOfMeasureColumn = i;
                        break;
                    case Constants.SIHeaders.VENDOR_NAME:
                        vendorNameColumn = i;
                        break;
                    case Constants.SIHeaders.COMMODITY:
                        unspscCodeColumn = i;
                        break;
                    case Constants.SIHeaders.FACILITY_NAME:
                        facNameColumn = i;
                        break;
                    case Constants.SIHeaders.STANDARD_PACKAGING:
                        packagingColumn = i;
                        break;
                }
            }
        }
    }

}
