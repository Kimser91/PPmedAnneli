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
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Milage { get; private set; }
        public Cars myCar { get; set; }



        public Cars(string make, string model, int year, int milage)
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
            Console.WriteLine("Hei! Velkommen til butikken, hvilken bil vil du se på?\n");

            CarsAtDealer = new List<Cars>()
            {
                new Cars("1. Nissan", "Sunny", 1994, 1900000000),
                new Cars("2. BMW", "X5", 2020, 12000),
                new Cars("3. RollsRoyce", "Phantome", 2024, 1)
            };

            foreach (Cars cars in CarsAtDealer)
            {
                Console.WriteLine($"{cars.Make}");
            }

            var inputBuyCar = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Cars lookAtCar = null;

            switch (inputBuyCar)
            {
                case 1:
                    lookAtCar = CarsAtDealer[inputBuyCar - 1];

                    break;
                case 2:
                    lookAtCar = CarsAtDealer[inputBuyCar - 1];
                    break;
                case 3:
                    lookAtCar = CarsAtDealer[inputBuyCar - 1];
                    break;
            }
            if (lookAtCar != null)
            {
                Console.WriteLine($"{lookAtCar.Make}");
                Console.WriteLine($"{lookAtCar.Model}");
                Console.WriteLine($"{lookAtCar.Year}");
                Console.WriteLine($"{lookAtCar.Milage}");
                Console.WriteLine("Skriv Ja, hvis du vil kjøpe denne bilen");

                var input = Console.ReadLine();
                if (input == "Ja")
                {
                    myCar = lookAtCar;
                    CarsAtDealer.RemoveAt(inputBuyCar - 1);
                }

                Console.WriteLine($"Min bil: {myCar.Make}");
                foreach (Cars cars in CarsAtDealer)
                {
                    Console.WriteLine($"{cars.Make}");
                }
            }

        }


    }
}
