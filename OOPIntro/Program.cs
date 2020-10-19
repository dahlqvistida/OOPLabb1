using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var costumer = new Customer();        

            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("What do you want to buy?");
                    Console.WriteLine("Milk, egg or bread?");

                    Console.WriteLine("(1) - Milk");
                    Console.WriteLine("(2) - Eggs");
                    Console.WriteLine("(3) - Bread");

                    int buyProduct = Convert.ToInt32(Console.ReadLine());
                  

                    switch (buyProduct)
                    {
                        case 1:
                            Milk milk = new Milk();
                            costumer._cart.Add(milk);
                            milk.FatContent = 1;

                            break;
                        case 2:
                            Eggs egg = new Eggs();
                            costumer._cart.Add(egg);
                            egg.EggStatus = 9;

                            break;
                        case 3:
                            Bread bread = new Bread();
                            costumer._cart.Add(bread);
                            bread._productName = "bread";
                            bread.TasteOfBread = "Carrot";

                            break;
                    }
                }
                else
                    break;

                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes") {       

                    Console.WriteLine("Do you want to view specifics about you purches?");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        foreach (var product in costumer._cart)
                        {
                            //För att skriva ut något som inte finns i metod
                            if (product.GetType() == typeof(Milk))
                            {
                                Console.WriteLine("The fatcontent on the milk is: ");
                                Console.WriteLine(((Milk)product).FatContent);
                            }
                            else if (product.GetType() == typeof(Eggs))
                            {
                                Console.WriteLine("The package contains this many eggs: ");
                                Console.WriteLine(((Eggs)product).EggStatus);
                            }
                            else if (product.GetType() == typeof(Bread))
                            {
                                Console.WriteLine("The taste of the bread is: ");
                                Console.WriteLine(((Bread)product).TasteOfBread);
                            }


                        }
                    }
                    else
                    {
                        Console.WriteLine("Okej, hejdå");
                    }
                }
                else
                    Console.WriteLine("Suck a duck!");
            }
        }
    }
}
