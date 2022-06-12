using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Plant: InvItem
    {

        public Plant() { }

        public Plant(int itemNo, string description, decimal price, string size) :
            base(itemNo, description, price)
        {
            this.Size = Size;
        }

        public string Size { get; set; }
        

        public override string GetDisplayText()
        {
            return (base.ItemNo +" "+ Size +" " + base.Description + " " 
                + "(" +base.Price+")");
        }
            
        

    }
}
