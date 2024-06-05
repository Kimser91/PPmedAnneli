using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedAnneli
{
   
    internal class Cars
    {
        public List<Cars> CarsAtDealer { get; private set; }
        public string Make {  get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Milage { get; private set; }
        
        

        public Cars(string make, string model, int year, int milage )
        {
            Make = make;
            Model = model;
            Year = year;
            Milage = milage;

        }

        public Cars()
        {
            CarsForSale();
        }

        public void CarsForSale() 
        {
            Console.WriteLine();

            CarsAtDealer = new List<Cars>()
           {
            new Cars("Nissan", "Sunny", 1994, 1900000000 ),
            new Cars("BMW", "X5", 2020, 12000),
            new Cars("RollsRoyce", "Phantome", 2024, 1)
           };

            foreach (Cars cars in CarsAtDealer)
            {
                Console.WriteLine($"{cars.Make}");
            }

        }
        public void CarDealerMain()
        {

            



        }
    }
    

}
