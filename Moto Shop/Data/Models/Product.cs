using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public ModelMotorcycle Model { get; set; }
        public string ModelName { get; set; }
        public int ModelID { get; set; }

        public string Manufacturer { get; set; }
        public string longDesc;
        public string LongDesc {
            get
            {
                return longDesc;
            }
            set
            {
                longDesc = value;
            }
        }
        private string shortDesc;
        public string ShortDesc
        {
            get
            {
                if (shortDesc.Length > 203 | shortDesc.Length < 100)
                {
                    if (longDesc.Length > 200)
                        shortDesc = longDesc.Substring(0, 200) + "...";
                    else
                        shortDesc = longDesc;
                }
                    
                return shortDesc;
            }
            set
            {
                shortDesc = value;
                if (shortDesc.Length > 203 | shortDesc.Length < 100)
                    shortDesc = longDesc.Substring(0, 200) + "...";

            }
        }
        public string Image { get; set; }
        public ushort Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Avialable { get; set; }

        public bool IsMoto { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string State { get; set; }
    }
}
