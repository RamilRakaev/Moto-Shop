using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class ModelMotorcycle
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string FrontTires { get; set; }
        public string RearTires { get; set; }
        public byte FuelTank { get; set; }
        public ushort MaxSpeed { get; set; }
        public string Class { get; set; }
        public ushort EngineVolume { get; set; }
        public byte HorsePower { get; set; }
        public string FuelSupplySystem { get; set; }
        public byte Cylinders { get; set; }
        public byte Ticks { get; set; }
        public string Transmission { get; set; }
        public string DriveUnit { get; set; }


        public List<Product> Product { get; set; }

    }
}
