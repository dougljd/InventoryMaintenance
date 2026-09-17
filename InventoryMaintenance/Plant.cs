using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        // The Plant class demonstrates inheritance because it inherits from the InvItem
        // base class using ": InvItem". This allows Plant to use InvItem's properties
        // and methods while also adding its own Size property and overriding GetDisplayText().

        //Jonathan Douglas
        public Plant() { }

        //Jonathan Douglas
        public Plant(int itemNo, string description, decimal price, string size): base(itemNo, description, price)
        {
            this.Size = size;
        }

        public string Size { get; set; }

        //Jonathan Douglas
        public override string GetDisplayText() => $"{ItemNo} {Size} {Description} ({Price:c})";

    }
}
