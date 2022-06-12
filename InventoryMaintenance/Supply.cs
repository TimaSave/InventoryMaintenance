using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Supply:InvItem
    {

        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) :
            base(itemNo, description, price)
        {
            this.Manufacturer = manufacturer;
        }
        public string Manufacturer { get; set; }
        

        public override string GetDisplayText()
        {
           return (base.ItemNo + " " + Manufacturer + " " + base.Description + " "
                + "(" + base.Price + ")");
        }
            
    }
}
