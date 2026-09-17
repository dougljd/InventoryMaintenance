using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {

        //Jonathan Douglas
        public Supply() { }

        //Jonathan Douglas
        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)
        {
            this.Manufacturer = manufacturer;
        }

        public string Manufacturer { get; set; }


        //Jonathan Douglas
        public override string GetDisplayText() => $"{ItemNo} {Manufacturer} {Description} ({Price:c})";
    }
}
