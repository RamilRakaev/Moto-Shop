using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public ModelMotorcycle Model { get; set; }
        public int ModelID { get; set; }

        public string Manufacturer { get; set; }
        public string LongDesc { get; set; }
        public string ShortDesc { get; set; }
        public string Image { get; set; }
        public ushort Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Avialable { get; set; }

        public string Color { get; set; }
        public int Mileage { get; set; }
        public string State { get; set; }
    }
}
