using System;

namespace einsteins_Riddle
{
    class Program
    {
        bool result = true;
        static void Main(string[] args)
        {
            string nationality = "";
            string drink = "";
            string cigarette = "";
            string pet = "";
            int number = 0;
            string color = "";
            int numberRight = 0;
            string colorRight = "";
            int numberLeft = 0;
            string colorLeft = "";
            var House = new House(number, color);
            var HouseRight = new House(numberRight, colorRight);
            var HouseLeft = new House(numberLeft, colorLeft);
            var Person = new Person(nationality, drink, cigarette, pet);
            

             int Verify()
            {
                int points = 0;
                if (Person.Nationality != null)
                {
                    if ((House.Color == "Red") && (Person.Nationality == "Brit"))
                    {
                        points += 1;
                    }
                }
                else if((Person.Nationality == "Swede") && (Person.Pet == "Dogs"))
                {
                    points += 1;
                }
                return points;
            }
            var result = Verify();
            string print = "";
            if (result == 0)
            {
                print = "Failed";
            }
            else if(result == 15)
            {
                print = "Passed";
            }
            else
            {
                print = "Fair";
            }
            Console.WriteLine(print);
        }
    }
}
