using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntro;
internal class OopApp
{
    public void Run2()
    {
        var cars = new Car[10];
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car(1, 1, 1, "A");
        }
    }
    public void Run()
    {
        var carBrands = new string[10];
        var carModels = new string[10];
        var carPlates = new string[10];
        var carMaxTanks = new int[10];
        var carCurrentTanks = new int[10];
        var carAvgConsumptions = new double[10];
        var carDistances = new double[10];

        var plate = Console.ReadLine();
        var car = new Car(50, 40, 8.5, plate);
        car.CurrentGas++;
        car.CurrentGas = 1000;

        for (int i = 0; i < carMaxTanks.Length; i++)
        {
            var brandInput = Console.ReadLine();
            carBrands[i] = brandInput;
            var modelInput = Console.ReadLine();
            carModels[i] = modelInput;
            var licenceInput = Console.ReadLine();
            carPlates[i] = licenceInput;

            var maxTank = int.Parse(Console.ReadLine());
            carMaxTanks[i] = maxTank;
            var currentGas = int.Parse(Console.ReadLine());
            if (carMaxTanks[i] >= currentGas)
            {
                carCurrentTanks[i] = currentGas;
            }
            // other arrays goes here…
        }

        bool proceed = true;
        while (proceed)
        {
            Console.WriteLine("Type licence plate");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                var index = -1;
                for (int i = 0; i < carPlates.Length; i++)
                {
                    if (carPlates[i] == input)
                    {
                        index = i;
                    }
                }

                Console.WriteLine($"Car with plate {carPlates[index]}");
                Console.WriteLine($"Brand is {carBrands[index]} model {carModels[index]}");
                Console.WriteLine($"Max gas {carMaxTanks[index]}, current gas {carCurrentTanks[index]}");
                Console.WriteLine($"Consuption is {carAvgConsumptions[index]} with {carDistances[index]}km.");
            }
            else
            {
                proceed = false;
            }
        }
    }
}
