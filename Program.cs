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
            string[] rules = new string[15]
             {
              "#1 The Brit lives in the red house.",
              "#2 The Swede keeps dogs as pets.",
              "#3 The Dane drinks tea.",
              "#4 The green house is exactly  to the left of the white house.",
              "#5 The owner of the green house drinks coffee.",
              "#6 The person who smokes Pall Mall rears birds.",
              "#7 The owner of the yellow house smokes Dunhill.",
              "#8 The man living in the center house drinks milk.",
              "#9 The Norwegian lives in the first house.",
              "#10 The man who smokes Blends lives next to the one who keeps cats.",
              "#11 The man who keeps horses lives next to the man who smokes Dunhill.",
              "#12 The man who smokes Blue Master drinks beer.",
              "#13 The German smokes Prince.",
              "#14 The Norwegian lives next to the blue house.",
              "#15 The man who smokes Blends has a neighbour who drinks water."
             };
            object[][] grid = new object[5][];
            string [] failed = new string[14];
            int fail = 0;
            System.Console.Write("Rules of the riddle");
            foreach (string rule in rules)
            {
                System.Console.Write("\n"+rule);
            }
            Console.WriteLine("\n\nUsing the rules above, please enter your choices for the houses");
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
                        else if ((Obj_Person.Nationality == "Brit") && (Obj_Person.Color != "Red"))
                        {
                            failed[fail] = rules[0].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Nationality == "Swede") && (Obj_Person.Pet == "Dogs"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Swede") && (Obj_Person.Pet != "Dogs"))
                        {
                            failed[fail] = rules[1].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Nationality == "Dane") && (Obj_Person.Drink == "Tea"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Dane") && (Obj_Person.Drink != "Tea"))
                        {
                            failed[fail] = rules[2].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Nationality == "Norwegian") && (Obj_House.Number == 1))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "Norwegian") && (Obj_House.Number != 1))
                        {
                            failed[fail] = rules[8].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Nationality == "German") && (Obj_Person.Cigarette == "Prince"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Nationality == "German") && (Obj_Person.Cigarette != "Prince"))
                        {
                            failed[fail] = rules[12].ToString();
                            fail += 1;
                        }
                    }
                     if (Obj_Person.Color != null)
                    {
                        if ((Obj_Person.Color == "White") && (counter > 0) && (grid[counter - 1][1].ToString() == "Green"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "White") && (counter > 0) && (grid[counter - 1][1].ToString() != "Green"))
                        {
                            failed[fail] = rules[3].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Color == "Green") && (Obj_Person.Drink == "Coffee"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Green") && (Obj_Person.Drink != "Coffee"))
                        {
                            failed[fail] = rules[4].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Color == "Yellow") && (Obj_Person.Cigarette == "Dunhill"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Yellow") && (Obj_Person.Cigarette != "Dunhill"))
                        {
                            failed[fail] = rules[6].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Color == "Blue") && (counter > 0) && (grid[counter - 1][2].ToString() == "Norwegian"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Color == "Blue") && (counter > 0) && (grid[counter - 1][2].ToString() != "Norwegian"))
                        {
                            failed[fail] = rules[13].ToString(); ;
                            fail += 1;
                        }
                    }
                    if (Obj_Person.Cigarette != null)
                    {
                        if ((Obj_Person.Cigarette == "Pall Mall") && (Obj_Person.Pet == "Birds"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Pall Mall") && (Obj_Person.Pet != "Birds"))
                        {
                            failed[fail] = rules[5].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blue Master") && (Obj_Person.Drink == "Beer"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blue Master") && (Obj_Person.Drink != "Beer"))
                        {
                            failed[fail] = rules[11].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blends") && (grid[counter - 1][5].ToString() == "Cats"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blends") && (grid[counter - 1][5].ToString() != "Cats"))
                        {
                            failed[fail] = rules[9].ToString();
                            fail += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blends") && (counter > 0) && (grid[counter - 1][3].ToString() == "Water"))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Cigarette == "Blends") && (counter > 0) && (grid[counter - 1][3].ToString() != "Water"))
                        {
                            failed[fail] = rules[14].ToString();
                            fail += 1;
                        }
                    }
                    if (Obj_Person.Pet != null)
                    {
                         if ((Obj_Person.Pet == "Horses") && (counter > 0) && (grid[counter - 1][4].ToString() == "Dunhill"))
                        {
                             points += 1;
                        }
                        else if ((Obj_Person.Pet == "Horses") && (counter > 0) && (grid[counter - 1][4].ToString() != "Dunhill"))
                        {   
                            failed[fail] = rules[10].ToString();
                            fail += 1;
                        }
                    }
                    if (Obj_Person.Drink != null)
                    {
                       if ((Obj_Person.Drink == "Milk") &&  (Obj_House.Number == 3))
                        {
                            points += 1;
                        }
                        else if ((Obj_Person.Drink == "Milk") && (Obj_House.Number != 3))
                        {
                            failed[fail] = rules[7].ToString();
                            fail += 1;
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
            Console.WriteLine("\n\nPoints scored: "+result);
            Console.WriteLine("Result: "+print);

            Console.WriteLine("\nFailed: "+fail);
            if (fail > 0) {
                Console.WriteLine("\nYou failed the riddles below");
                foreach (string failed_rule in failed)
                {
                    System.Console.Write("\n" + failed_rule);
                }
            }
        }
    }
}
