using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    internal class Plant : InvItem
    {
        Plant() { }

        public Plant(int itemNo, string description, decimal price, string size): base(itemNo, description, price)
        {
            this.Size = size;
        }

        public string Size { get; set; }

        public override string GetDisplayText() => $"{ItemNo} {Size} {Description} ({Price:c})";

    }
}
