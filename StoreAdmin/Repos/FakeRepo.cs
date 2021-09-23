using StoreAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAdmin.Repos
{
    class FakeRepo
    {
        public List<Car> cars { get; set; }

        public FakeRepo()
        {

            cars = new List<Car>
            {
                new Car{
                Id = 2,
                Vendor = "BMW",
                Model = "X5",
                Year = 2021
                },
                new Car{
                Id = 1,
                Vendor = "Kia",
                Model = "Sorento",
                Year = 2012
                },
                new Car{
                Id = 3,  
                Vendor = "Audi",
                Model = "Quadro",
                Year = 2020
                },
            };
        }
    }
}
