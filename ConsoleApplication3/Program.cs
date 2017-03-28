using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {// Prints the menu and its planets\\
            double ratio = 0.0;
            Console.WriteLine("Menu of Planets");
            Console.WriteLine("==== == =======");
            Console.WriteLine("1.Jupiter, 2.Mars, 3.Mercury");
            Console.WriteLine("4.Neptune, 5.Pluto, 6.Saturn");
            Console.WriteLine("7.Uranus, 8.Venus, 9. <Quit>");
            Console.WriteLine();
            // Created int to store weight and choose their planet 
            int weight = 0;
            //Console.Write("Please enter your weight: ");
            //weight = int.Parse(Console.ReadLine());

            int Enterplanet = 0;
            

            string planets = "";
            // Created a while loop so that if the number is not equal to 9 they would have to go back to choosing their planet.
            while (Enterplanet != 9)
            {
                Console.Write("Choose your planet: ");
                Enterplanet = Convert.ToInt32(Console.ReadLine()); 
                while (Enterplanet > 9) // Created another while loop because the user must know that if the number that they choose is greater than 9 they will be redirected back to choosing a valid planet
                {
                    Console.WriteLine("BRRUUUHHHHHH");  
                    Console.WriteLine("Choose a valid planet");
                    Enterplanet = Convert.ToInt32(Console.ReadLine()); // This line is to let the program know that it needs to show the line above ( showing the output)
                }
                // This puts a number to the enterplanet and the switch checks which case to follow
                switch (Enterplanet)
                {

                    case 1:

                        Console.Write(" Enter your weight ");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1) //  weight is less than 1 then the user is notified that your weight cannot be less than 1.
                        {                  //They are then redirected to choose a accurate weight size ( This applies to each case number), besides case 9
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 0.37;
                        planets = "mercury";
                        break;

                    case 2:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Your weight can't be less than 1");
                        ratio = 2.64;
                        planets = "jupiter";
                        break;

                    case 3:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 1.12;
                        planets = "neptune";
                        break;

                    case 4:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 0.88;
                        planets = "venus";
                        break;

                    case 5:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 1.15;
                        planets = "Saturn";
                        break;

                    case 6:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 0.04;
                        planets = "pluto";
                        break;

                    case 7:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 0.38;
                        planets = "mars";
                        break;

                    case 8:
                        Console.Write("enter your weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        while (weight < 1)
                        {
                            Console.WriteLine("Your weight can't be less than 1");
                            Console.Write("Please your weight : ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        ratio = 1.15;
                        planets = "uranus";
                        break;

                    case 9:
                        Console.WriteLine("This program will quit"); // Lets the user know that the program will quit if 9 is slected

                        break; // Breaks are put at the end of these cases so that it is able to move onto the next step if they do not choose that case number ex. if they do not chose case 5 the program will skip case 1,2,3,4 and give you the results for 5.

                        // Below is where the user will be rerouted to choose a planet again 
                    default:
                        Console.WriteLine("Please Choose a planet");
                        Enterplanet = Convert.ToInt32(Console.ReadLine());

                        break;
                }
                 
                 // created an if statement to let the user know if your weight is greater than 1000 then its invalid
                //Prompted user to enter there weight once again
                double answer;
                if (weight >1000)
                {
                    Console.WriteLine("Your weight can not be over 1000 pounds ");
                    Console.WriteLine(" PLEASE ENTER YOUR WEIGHT");
                    weight = Convert.ToInt32(Console.ReadLine());

                     // Here is where it tells the user how much there weight would be on the planet
                }   //Created an if statment so that if its = to 9 then it will not show the answer screen
                    // Calculated the users weight by multiplying it by the ratio
                if (Enterplanet !=9) {
                    answer = weight * ratio;
                    Console.WriteLine("Your weight on " + planets + " will be " + answer);
                }

            }


            
        }
    }
}
 