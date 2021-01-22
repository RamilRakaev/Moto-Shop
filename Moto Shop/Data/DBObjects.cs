using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data
{
    public class DBObjects
    {
        public static void Initial(MotoDBContext db)
        {
            
            if (!db.MotoModels.Any())
            {
                db.MotoModels.AddRange(MotoModels.Select(m => m.Value));
            }
            if (!db.Moto.Any())
            {
                db.Moto.AddRange(new Product() {Manufacturer="2",Name="Мотик",
                LongDesc="2",
                    Image= "/img/Honda Africa Twin.jpg",
                    Price=255,IsFavorite=true,Avialable=true,
                    Color="3",Mileage=2000,State="good",Model=MotoModels["Эндуро"]
                });
            }
            db.SaveChanges();
        }

        private static Dictionary<string, ModelMotorcycle> motoModels;
        public static Dictionary<string, ModelMotorcycle> MotoModels
        {
            get
            {
                if (motoModels == null)
                {
                    var list = new ModelMotorcycle[]
                    {
                        new ModelMotorcycle(){ModelName="Эндуро",
                        FrontTires="fsd",RearTires="22",FuelTank=24,
                        MaxSpeed=500,Class="endyro",EngineVolume=2,
                        HorsePower=24,FuelSupplySystem="gg",
                        Cylinders=4,Ticks=2,Transmission="fsdf",
                        DriveUnit="fsdf"}
                    };
                    motoModels = new Dictionary<string, ModelMotorcycle>();
                    foreach (ModelMotorcycle el in list)
                    {
                        motoModels.Add(el.ModelName, el);
                    }
                }
                return motoModels;
            }
        }
    }
}
