using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        //Jonathan Douglas
        public InvItem() { }

        //Jonathan Douglas
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        // Jonathan Douglas
        public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
