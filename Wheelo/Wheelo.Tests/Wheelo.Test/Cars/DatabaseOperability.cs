using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelo.Nfs.Database.Persistence.Models;

namespace Wheelo.Test.Cars
{
    class DatabaseOperability
    {



        protected void createCarEntity(CarEntity carek)
        {

            Carsbrand c = new Carsbrand();

            c.Brand = carek.make;



            // {"year": 2016, "id": 1, "horsepower": 201, "make": "acura", "model": "ilx", "price": 31890.0, "img_url": "http://ts2.mm.bing.net/th?id=OIP.M7656c6f6aaa4d51c3ddee4b1192adeeeH0&pid=15.1"}





            /*
                public Carsbrand()
                {
                    Cars = new HashSet<Car>();
                    Carsmodels = new HashSet<Carsmodel>();
                }

                public int Id { get; set; }
                public string Brand { get; set; }

                public virtual ICollection<Car> Cars { get; set; }
                public virtual ICollection<Carsmodel> Carsmodels { get; set; }
            */
        }




    }
}
