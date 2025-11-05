using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
 using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   
internal class Program //Vuyo Mhlanga(576823)
    {
        public static ArrayList TotalCost=new ArrayList(); //used to store all costs 
        public static ArrayList OrderSummary = new ArrayList(); //used to store all orders
        enum MainMenu //menu options used for the Main Menu
        {
            Starters=1,Pizzas,Salads, Pastas,Drinks,ClearCart,Exit //Menu Options
        }
        public static double StarterMenu() //method for Starters
        {
            double totalStarters=0,totalGarlicBread=0,totalGarlicSupreme=0,totalSuperSupreme=0,garlicBread=21.90,garlicSupreme=33.90,garlicSuperSupreme=44.90; //assign cost prices and declare values for calculating prices respectively
            int numGarlicBread,numGarlicSupreme,numSuperSupreme; //declare number of item variables
            string order="",finalorder="";
            Console.WriteLine("Welcome to the starter menu :)\n");
            do //begin loop
            { 
                Console.WriteLine("Please Select An Option:\n");
                Console.Write($"1.Garlic Bread(R{garlicBread})\n2.Garlic Bread Supreme(R{garlicSupreme})\n3.Garlic Bread Super Supreme(R{garlicSuperSupreme})\n"); //show user the options available in this Menu
                int option = int.Parse(Console.ReadLine()); //get user option
                
                switch (option) //switch between options selected
                {
                    case 1:
                         Console.WriteLine("How many would you like to order");
                        numGarlicBread = int.Parse(Console.ReadLine());
                        order = $"{numGarlicBread}*Garlic Bread(s)\n"; //record order made
                        totalGarlicBread = totalGarlicBread + (numGarlicBread * garlicBread); //calculate total cost

                        break;

                    case 2:
                        Console.WriteLine("How many would you like to order");
                        numGarlicSupreme = int.Parse(Console.ReadLine());
                        order = $"{numGarlicSupreme}*Garlic Bread Supreme(s)\n";
                        totalGarlicSupreme = totalGarlicSupreme + (numGarlicSupreme * garlicSupreme);
                        break;

                    case 3:
                        Console.WriteLine("How many would you like to order");
                        numSuperSupreme = int.Parse(Console.ReadLine());
                        order = $"{numSuperSupreme}*Garlic Bread Super Supreme(s)\n";
                        totalSuperSupreme = totalSuperSupreme + (numSuperSupreme * garlicSuperSupreme);

                        break;

                    default:
                        Console.WriteLine("You have entered an invalid option, please enter a number between 1 and 3");
                        break;
                }
                finalorder = finalorder+order; //assign value to the final order information
                totalStarters = totalGarlicSupreme + totalSuperSupreme + totalGarlicBread; //assign value to total cost of order

                Console.WriteLine("Do you still want to order?\nPlease type 'Y' for Yes and 'N' for No:");

            } while (Console.ReadLine().ToUpper() == "Y"); //ask whether to order again or end ordering process
            Console.WriteLine($"Your final total for Starters is \n{finalorder}\n");
            TotalCost.Add(totalStarters); //add cost to total cost of orders
            OrderSummary.Add(finalorder); //add order information to order summary information

            return totalStarters; //return cost of Starters ordered
        }
        public static double PizzaMenu() //method for Pizzas
        {
            double totalPizzas, Pepperoni = 84.90, Vegetarian = 84.90, BBQChicken = 74.90, Hawaiian = 84.90, totalPepperoni = 0, totalVegetarian = 0, totalBBQChicken = 0, totalHawaiian = 0;
            int numPepperoni, numVegetarian, numBBQChicken, numHawaiian;
            string finalorder="", order="", size;
            Console.WriteLine("Welcome to Pizza Menu :)\n");
            do
            {
                Console.WriteLine("Please Select An Option:\n");
                Console.Write($"1.Pepperoni(R{Pepperoni} for Large, R34.90 for Small)\n2.Vegetarian(R{Vegetarian} for Large, R34.90 for Small)\n3.BBQ Chicken(R{BBQChicken} for Large, R25.90 for Small)\n4.Hawaiian(R{Hawaiian} for Large,R34.90 for Small)\n");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many would you like to order");
                        numPepperoni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter The Size Of Your Pizza('S' or 'L'):");
                        size = Console.ReadLine(); //assign size of Pizza 
                        if (size.ToUpper().Equals("S")){ 
                            Pepperoni = 34.90; //assign new cost of Pizza if the size chosen was Small
                        }
                        order =order+$"{numPepperoni}*{size.ToUpper()} Pepperoni Pizza(s)\n";
                        totalPepperoni = totalPepperoni+ (numPepperoni * Pepperoni);

                        break;

                    case 2:
                        Console.WriteLine("How many would you like to order");
                        numVegetarian = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter The Size Of Your Pizza('S' or 'L'):");
                        size = Console.ReadLine();
                        if (size.ToUpper().Equals("S"))
                        {
                            Vegetarian = 34.90;
                        }
                        order = order + $"{numVegetarian}*{size.ToUpper()} Vegetarian Pizza(s)\n";
                        totalVegetarian = totalVegetarian + (numVegetarian * Vegetarian);

                        break;

                    case 3:
                        Console.WriteLine("How many would you like to order");
                        numBBQChicken = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter The Size Of Your Pizza('S' or 'L'):");
                        size = Console.ReadLine();
                        if (size.ToUpper().Equals("S"))
                        {
                            BBQChicken = 25.90;
                        }
                        order = order + $"{numBBQChicken}*{size.ToUpper()} BBQChicken Pizza(s)\n";
                        totalBBQChicken = totalBBQChicken + (numBBQChicken * BBQChicken);
                        break;

                    case 4:
                        Console.WriteLine("How many would you like to order");
                        numHawaiian = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter The Size Of Your Pizza('S' or 'L'):");
                        size = Console.ReadLine();
                        if (size.ToUpper().Equals("S"))
                        {
                            Hawaiian = 34.90;
                        }
                        order = order + $"{numHawaiian}*{size.ToUpper()} Hawaiian Pizza(s)\n";
                        totalHawaiian = totalHawaiian + (numHawaiian * Hawaiian);
                        break;

                    default:
                        Console.WriteLine("You have entered an invalid option, please enter a number between 1 and 3");
                        break;
                }
                
                finalorder = finalorder + order;
                totalPizzas = totalPepperoni + totalVegetarian + totalBBQChicken + totalHawaiian;
                Console.WriteLine("Do you still wish to order?\nPlease Enter 'Y' for Yes and 'N' for No");

            } while (Console.ReadLine().ToUpper()=="Y");
            Console.WriteLine($"Your final Pizza order is:\n{finalorder}\n");
            TotalCost.Add(totalPizzas);
            OrderSummary.Add(finalorder);
            return totalPizzas; //return cost of Pizzas ordered
        }
        public static double SaladMenu() //method for Salads Menu
        {
            double totalSalads,totalHouse=0, houseSalad = 35.90,totalChef=0, chefSalad = 63.90,totalChicken=0, chickenSalad = 66.90, totalGreek=0,greekSalad = 66.90;
            int numHouse, numChef, numChicken, numGreek;
            string finalorder = "", order = "";
            Console.WriteLine("Welcome to Salad Menu :)");
            do
            {
                Console.WriteLine("Please Select An Option:\n");
                Console.Write($"1.House Salad(R{houseSalad})\n2.Chef Salad(R{chefSalad})\n3.Chicken Salad(R{chickenSalad})\n4.Greek Salad(R{greekSalad})\n");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many would you like to order");
                        numHouse = int.Parse(Console.ReadLine());                    
                        order = order + $"{numHouse}*House Salad(s)\n";
                        totalHouse = totalHouse + (numHouse * houseSalad);
                        break;

                    case 2:
                        Console.WriteLine("How many would you like to order");
                        numChef = int.Parse(Console.ReadLine());
                        order = order + $"{numChef}*Chef Salad(s)\n";
                        totalChef = totalChef + (numChef * chefSalad);
                        break;

                    case 3:
                        Console.WriteLine("How many would you like to order");
                        numChicken = int.Parse(Console.ReadLine());
                        order = order + $"{numChicken}*Chicken Salad(s)\n";
                        totalChicken = totalHouse + (numChicken * chickenSalad);
                        break;

                    case 4:
                        Console.WriteLine("How many would you like to order");
                        numGreek = int.Parse(Console.ReadLine());
                        order = order + $"{numGreek}*Greek Salad(s)\n";
                        totalGreek = totalGreek + (numGreek * greekSalad);
                        break;

                    default:
                        Console.WriteLine("You have entered an invalid option, please enter a number between 1 and 3\n");
                        break;
                }
                finalorder = finalorder + order;
                totalSalads = totalHouse + totalChef + totalChicken + totalGreek;
                Console.WriteLine("Do you still wish to order?\nPlease Enter 'Y' for Yes and 'N' for No\n");
            } while (Console.ReadLine().ToUpper()=="Y");
            Console.WriteLine($"Your final Salad Order Is:\n{finalorder}\n");
            TotalCost.Add(totalSalads);
            OrderSummary.Add(finalorder);
            return totalSalads; //return cost of Salads ordered
        }
        public static double PastaMenu() //Method for Pasta Menu
        {
            double totalPastas=0, totalRomana = 0, chickenRomana = 66.90, totalMeatL = 0, meatLasagne = 66.90, totalChickenL = 0, chickenLasagne = 66.90, totalVegetarian = 0, vegetarianLasagne = 66.90;
            int numRomana, numMeatLasagne, numChickenLasagne, numVegetarianLasagne;
            string finalorder = "", order = "";
            Console.WriteLine("Welcome To The Pasta Menu :)");
            do
            {
                Console.WriteLine("Please Select An Option:\n");
                Console.Write($"1.Chicken Romana(R{chickenRomana})\n2.Meat Lasagne(R{meatLasagne})\n3.Chicken Lasagne(R{chickenLasagne})\n4.Vegetarian Lasagne(R{vegetarianLasagne})\n");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many would you like to order");
                        numRomana = int.Parse(Console.ReadLine());
                        order = order + $"{numRomana}*Chicken Romana(s)\n";
                        totalRomana = totalRomana + (numRomana * chickenRomana);
                        break;

                    case 2:
                        Console.WriteLine("How many would you like to order");
                        numMeatLasagne = int.Parse(Console.ReadLine());
                        order = order + $"{numMeatLasagne}*Meat Lasagne(s)\n";
                        totalMeatL = totalMeatL + (numMeatLasagne * meatLasagne);
                        break;

                    case 3:
                        Console.WriteLine("How many would you like to order");
                        numChickenLasagne = int.Parse(Console.ReadLine());
                        order = order + $"{numChickenLasagne}*Chicken Lasagne(s)\n";
                        totalChickenL = totalChickenL + (numChickenLasagne * chickenLasagne);
                        break;

                    case 4:
                        Console.WriteLine("How many would you like to order");
                        numVegetarianLasagne = int.Parse(Console.ReadLine());
                        order = order + $"{numVegetarianLasagne}*Vegetarian Lasagne(s)\n";
                        totalVegetarian = totalVegetarian + (numVegetarianLasagne * vegetarianLasagne);
                        break;

                    default:
                        Console.WriteLine("You have entered an invalid option, please enter a number between 1 and 3");
                        break;
                }
                finalorder = finalorder + order;
                totalPastas = totalRomana + totalMeatL + totalChickenL + totalVegetarian;
                Console.WriteLine("Do you still wish to order?\nPlease Enter 'Y' for Yes and 'N' for No\n");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine($"Your final Pasta order is:\n{finalorder}\n");
            TotalCost.Add(totalPastas);
            OrderSummary.Add(finalorder);
            return totalPastas; //return cost of Pasta ordered
           
        }
        public static double DrinkMenu() //method for Drinks menu
        {
            double totalDrinks, totalCokeZero = 0, cokeZero = 24.90, totalSprite = 0, sprite = 24.90, totalFantaOrange = 0, fantaOrange = 24.90, totalCremeSoda = 0, cremeSoda = 24.90,totalSparberry=0,sparberry=24.90;
            int numCokeZero, numSprite,numFantaOrange,numCremeSoda,numSparberry;
            string finalorder = "", order = "";
            Console.WriteLine("Welcome To The Drinks Menu :)");
            do
            {
                Console.WriteLine("Please Select An Option:\n");
                Console.Write($"1.Coke Zero(R{cokeZero})\n2.Sprite(R{sprite})\n3.Fanta Orange(R{fantaOrange})\n4.Creme Soda(R{cremeSoda})\n5.Sparberry(R{sparberry})\n");
                int option = int.Parse(Console.ReadLine());

                switch (option) //switch between options selected
                {
                    case 1:
                        Console.WriteLine("How many would you like to order");
                        numCokeZero = int.Parse(Console.ReadLine());
                        order = order + $"{numCokeZero}*Coke Zero(s)\n";
                        totalCokeZero = totalCokeZero + (numCokeZero * cokeZero);
                        break;

                    case 2:
                        Console.WriteLine("How many would you like to order");
                        numSprite = int.Parse(Console.ReadLine());
                        order = order + $"{numSprite}*Sprite(s)\n"; //Order Details 
                        totalSprite = totalSprite + (numSprite * sprite); //total cost of Sprites ordered
                        break;

                    case 3:
                        Console.WriteLine("How many would you like to order");
                        numFantaOrange = int.Parse(Console.ReadLine());
                        order = order + $"{numFantaOrange}*Fanta Orange(s)\n";
                        totalFantaOrange = totalFantaOrange + (numFantaOrange * fantaOrange);
                        break;

                    case 4:
                        Console.WriteLine("How many would you like to order");
                        numCremeSoda = int.Parse(Console.ReadLine());
                        order = order + $"{numCremeSoda}*Creme Soda(s)\n";
                        totalCremeSoda = totalCremeSoda + (numCremeSoda * cremeSoda);
                        break;

                    case 5:
                        Console.WriteLine("How many would you like to order");
                        numSparberry = int.Parse(Console.ReadLine());
                        order = order + $"{numSparberry}*Sparberry(s)\n";
                        totalSparberry = totalSparberry + (numSparberry * sparberry);
                        break;

                    default:
                        Console.WriteLine("You have entered an invalid option, please enter a number between 1 and 3");
                        break;
                }
                finalorder = finalorder + order;
                totalDrinks = totalCokeZero + totalFantaOrange + totalSprite+ totalCremeSoda+ totalSparberry;
                Console.WriteLine("Do you still wish to order?\nPlease Enter 'Y' for Yes and 'N' for No\n");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine($"Your final Drink order is:\n{finalorder}\n");
            TotalCost.Add(totalDrinks);
            OrderSummary.Add(finalorder);
            return totalDrinks; //return cost of Drinks ordered
      
         }
      
        static void Main(string[] args)
        {
            double totalOrders = 0,vatTotal=0; //variable for Total Cost of Orders summary, as well as VAT calculation
            string summary = ""; //variable for order summary
            Console.WriteLine("Welcome to Romans Pizza :)\n"); //Show a welcome message
            do //loop
            {
                Console.WriteLine("Please Select An Option To Proceed\n1.Starters\n2.Pizzas\n3.Salads\n4.Pastas\n5.Drinks\n6.Clear Cart\n7.Exit"); //show user options on what food is available
                int selection = int.Parse(Console.ReadLine());
                switch ((MainMenu)selection) //switch between main menu options
                {
                    case MainMenu.Starters:
                        Console.WriteLine($"Your total for Starter Menu is R{StarterMenu()}"); //call Starter method
                        break;

                    case MainMenu.Pizzas:
                        Console.WriteLine($"Your total for Pizza Menu is R{PizzaMenu()}"); //call Pizza method
                        break;

                    case MainMenu.Salads:
                        Console.WriteLine($"Your total from the Salad Menu is R{SaladMenu()}"); //call Salad method
                        break;
                   
                    case MainMenu.Pastas:
                        Console.WriteLine($"Your total from the Pasta Menu is R{PastaMenu()}"); //call Pasta method
                        break;

                    case MainMenu.Drinks:
                        Console.WriteLine($"Your total from the Drinks Menu is R{DrinkMenu()}"); //call Drink method
                        break;

                    case MainMenu.ClearCart:
                        OrderSummary.Clear(); //clear all orders made
                        TotalCost.Clear(); //clear all costs calculated
                        break;


                    case MainMenu.Exit:
                        System.Environment.Exit(0); //exit application
                        break;
                }
               
                Console.WriteLine("Do you want to checkout now?\nPlease Type 'Y' for Yes and 'N' for No\n");

            } while (Console.ReadLine().ToUpper()=="Y"); //ask whether the user still wants to order different items from different menus
           foreach(string order in OrderSummary)
            {
                summary = summary + order;       //add values stored in ordersummary to final summary variable      
            }
            foreach (double total in TotalCost)
            {               
                totalOrders = totalOrders + total; //add costs recorded to final cost variable                
            }
            vatTotal = (totalOrders) * 0.15; //calculate cost after VAT
            Console.WriteLine($"Your final order is:\n{summary}\nYour final bill is R{totalOrders}."); //display final orders with costs
            Console.WriteLine($"After VAT:\t {vatTotal}\nThank you for choosing our restaurant :)");
            TotalCost.Clear(); //clear costs recorded
            OrderSummary.Clear(); //clear orders recorded
            System.Environment.Exit(0);
        }
    }
}
