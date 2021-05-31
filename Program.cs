using System;

namespace einsteins_Riddle
{
    class Program
    {
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
                    if ((Person.Nationality == "Brit") && (House.Color == "Red"))
                    {
                        points += 1;
                    }
                    else if ((Person.Nationality == "Swede") && (Person.Pet == "Dogs"))
                    {
                        points += 1;
                    }
                    else if ((Person.Nationality == "Dane") && (Person.Drink == "Tea"))
                    {
                        points += 1;
                    }
                    else if ((Person.Nationality == "Norwegian") && (House.Number == 1) && (HouseRight.Color == "Blue"))
                    {
                        points += 1;
                    }
                    else if((Person.Nationality == "German") && (Person.Cigarette == "Prince"))
                    {
                        points += 1;
                    }
                }
                else if (House.Color != null)
                {
                    if ((House.Color == "Green") && (HouseLeft.Color == "White") && (Person.Drink == "Coffee"))
                    {
                        points += 1;
                    }
                    else if ((House.Color == "Yellow") && (Person.Cigarette == "Dunhill"))
                    {
                        points += 1;
                    }
                }
                else if (Person.Cigarette != null)
                {
                    if((Person.Cigarette == "Pall Mall") && (Person.Pet == "Birds"))
                    {
                        points += 1;
                    }
                   /* else if ((Person.Cigarette == "Blend") )
                    {

                    }*/
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
