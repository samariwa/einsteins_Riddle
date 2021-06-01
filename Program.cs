using System;

namespace einsteins_Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int result = 0;
            string print = "";
            int counter = 0;
            object[][] grid = new object[5][];
            Console.WriteLine("Please enter your choices for the houses");
            while (counter <= 4)
            {
                int _number = counter + 1;
                Console.WriteLine("\nHouse " +_number);
                Console.Write("\nEnter House Color: ");
                string _color = Console.ReadLine();
                Console.Write("\nEnter Nationality: ");
                string _nationality = Console.ReadLine();
                Console.Write("\nEnter Drink: ");
                string _drink = Console.ReadLine();
                Console.Write("\nEnter Cigarette: ");
                string _cigarette = Console.ReadLine();
                Console.Write("\nEnter Pet: ");
                string _pet = Console.ReadLine();
                Person Obj_Person = new Person(_color, _nationality, _drink, _cigarette, _pet);
                House Obj_House = new House(_number);
                object[] values = new object[6] { Obj_House.Number, Obj_Person.Color, Obj_Person.Nationality, Obj_Person.Drink, Obj_Person.Cigarette, Obj_Person.Pet };
                grid[counter] = values;
                int Verify()
                {
                    if (Obj_Person.Nationality != null)
                    {
                        if ((Obj_Person.Nationality == "Brit") && (Obj_Person.Color == "Red"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Swede") && (Obj_Person.Pet == "Dogs"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Dane") && (Obj_Person.Drink == "Tea"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Norwegian") && (Obj_House.Number == 1))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "German") && (Obj_Person.Cigarette == "Prince"))
                        {
                            points += 1;
                        }
                    }
                     if (Obj_Person.Color != null)
                    {
                        if ((Obj_Person.Color == "White") && (counter > 0) && (grid[counter - 1][1].ToString() == "Green"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Green") && (Obj_Person.Drink == "Coffee"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Yellow") && (Obj_Person.Cigarette == "Dunhill"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Blue") && (counter > 0) && (grid[counter - 1][2].ToString() == "Norwegian"))
                        {
                            points += 1;
                        }
                    }
                    if (Obj_Person.Cigarette != null)
                    {
                        if ((Obj_Person.Cigarette == "Pall Mall") && (Obj_Person.Pet == "Birds"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blue Master") && (Obj_Person.Drink == "Beer"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blend") && (grid[counter - 1][5].ToString() == "Cats"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blend") && (counter > 0) && (grid[counter - 1][3].ToString() == "Water"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Dunhill") && (counter > 0) && (grid[counter - 1][5].ToString() == "Horses"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blends") && (counter > 0) && (grid[counter - 1][3].ToString() == "Water"))
                        {
                            points += 1;
                        }
                    }
                    if (Obj_Person.Pet != null)
                    {
                         if ((Obj_Person.Pet == "Horses") && (counter > 0) && (grid[counter - 1][4].ToString() == "Dunhill"))
                        {
                            points += 1;
                        }
                    }
                    if (Obj_Person.Drink != null)
                    {
                       if ((Obj_Person.Drink == "Milk") &&  (Obj_House.Number == 3))
                        {
                            points += 1;
                        }
                    }
                        return points;
                 }
                   result = Verify();
                   counter++;
                 }
                 if (result == 0)
                 {
                     print = "Failed";
                 }
                 else if(result == 14)
                 {
                     print = "Passed";
                 }
                 else
                 {
                     print = "Fair";
                 }
            Console.WriteLine("Points scored: "+result);
            Console.WriteLine("Result: "+print);
        }
    }
}
