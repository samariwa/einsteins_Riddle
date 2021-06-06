using System;
namespace einsteins_Riddle
{
     class Methods
    {
        public static int Points(int points, int counter, Object [][] grid, int number, string color, string nationality, string drink, string cigar, string pet)
        {
            if (nationality != null)
            {
                if ((nationality == "Brit") && (color == "Red"))
                {
                    points += 1;
                }
                else if ((nationality == "Swede") && (pet == "Dogs"))
                {
                    points += 1;
                }
                else if ((nationality == "Dane") && (drink == "Tea"))
                {
                    points += 1;
                }
                else if ((nationality == "Norwegian") && (number == 1))
                {
                    points += 1;
                }
                else if ((nationality == "German") && (cigar == "Prince"))
                {
                    points += 1;
                }
            }
            if (color != null)
            {
                if ((color == "White") && (counter > 0) && (grid[counter - 1][1].ToString() == "Green"))
                {
                    points += 1;
                }
                else if ((color == "Green") && (drink == "Coffee"))
                {
                    points += 1;
                }
                else if ((color == "Yellow") && (cigar == "Dunhill"))
                {
                    points += 1;
                }
                else if ((color == "Blue") && (counter > 0) && (grid[counter - 1][2].ToString() == "Norwegian"))
                {
                    points += 1;
                }
            }
            if (cigar != null)
            {
                if ((cigar == "Pall Mall") && (pet == "Birds"))
                {
                    points += 1;
                }
                else if ((cigar == "Blue Master") && (drink == "Beer"))
                {
                    points += 1;
                }
                else if ((cigar == "Blends") && (grid[counter - 1][5].ToString() == "Cats"))
                {
                    points += 1;
                }
                else if ((cigar == "Blends") && (counter > 0) && (grid[counter - 1][3].ToString() == "Water"))
                {
                    points += 1;
                }
            }
            if (pet != null)
            {
                if ((pet == "Horses") && (counter > 0) && (grid[counter - 1][4].ToString() == "Dunhill"))
                {
                    points += 1;
                }
            }
            if (drink != null)
            {
                if ((drink == "Milk") && (number == 3))
                {
                    points += 1;
                }
            }
            return points;
        }

        public static int Failed(int fail, String [] rules, String [] failed, Object[][] grid, int counter, int number, string color, string nationality, string drink, string cigar, string pet)
        {
            if (nationality != null)
            {
                if ((nationality == "Brit") && (color != "Red"))
                {
                    failed[fail] = rules[0].ToString();
                    fail += 1;
                }
                else if ((nationality == "Swede") && (pet != "Dogs"))
                {
                    failed[fail] = rules[1].ToString();
                    fail += 1;
                }
                else if ((nationality == "Dane") && (drink != "Tea"))
                {
                    failed[fail] = rules[2].ToString();
                    fail += 1;
                }
                else if ((nationality == "Norwegian") && (number != 1))
                {
                    failed[fail] = rules[8].ToString();
                    fail += 1;
                }
                else if ((nationality == "German") && (cigar != "Prince"))
                {
                    failed[fail] = rules[12].ToString();
                    fail += 1;
                }
            }
            if (color != null)
            {
                if ((color == "White") && (counter > 0) && (grid[counter - 1][1].ToString() != "Green"))
                {
                    failed[fail] = rules[3].ToString();
                    fail += 1;
                }
                else if ((color == "Green") && (drink != "Coffee"))
                {
                    failed[fail] = rules[4].ToString();
                    fail += 1;
                }
                else if ((color == "Yellow") && (cigar != "Dunhill"))
                {
                    failed[fail] = rules[6].ToString();
                    fail += 1;
                }
                else if ((color == "Blue") && (counter > 0) && (grid[counter - 1][2].ToString() != "Norwegian"))
                {
                    failed[fail] = rules[13].ToString(); ;
                    fail += 1;
                }
            }
            if (cigar != null)
            {
                if ((cigar == "Pall Mall") && (pet != "Birds"))
                {
                    failed[fail] = rules[5].ToString();
                    fail += 1;
                }
                else if ((cigar == "Blue Master") && (drink != "Beer"))
                {
                    failed[fail] = rules[11].ToString();
                    fail += 1;
                }
                else if ((cigar == "Blends") && (grid[counter - 1][5].ToString() != "Cats"))
                {
                    failed[fail] = rules[9].ToString();
                    fail += 1;
                }
                else if ((cigar == "Blends") && (counter > 0) && (grid[counter - 1][3].ToString() != "Water"))
                {
                    failed[fail] = rules[14].ToString();
                    fail += 1;
                }
            }
            if (pet != null)
            {
                if ((pet == "Horses") && (counter > 0) && (grid[counter - 1][4].ToString() != "Dunhill"))
                {
                    failed[fail] = rules[10].ToString();
                    fail += 1;
                }
            }
            if (drink != null)
            {
                if ((drink == "Milk") && (number != 3))
                {
                    failed[fail] = rules[7].ToString();
                    fail += 1;
                }
            }
            return fail;
        }

        public static void PrintRules(string [] rules)
        {
            System.Console.Write("Rules of the riddle");
            foreach (string rule in rules)
            {
                System.Console.Write("\n" + rule);
            }
            Console.WriteLine("\n\nUsing the rules above, please enter your choices for the houses");
        }

        public static void PrintInvalid(object [] Obj)
        {
            if (Obj[1].ToString() == "Invalid color" || Obj[2].ToString() == "Invalid nationality" || Obj[3].ToString() == "Invalid drink" || Obj[4].ToString() == "Invalid cigarette" || Obj[5].ToString() == "Invalid pet")
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Invalid Entries");
                Console.WriteLine("*****************************");
            }
            if (Obj[1].ToString() == "Invalid color")
            {
                Console.WriteLine("\nColor");
            }
            if (Obj[2].ToString() == "Invalid nationality")
            {
                Console.WriteLine("\nNationality");
            }
            if (Obj[3].ToString() == "Invalid drink")
            {
                Console.WriteLine("\nDrink");
            }
            if (Obj[4].ToString() == "Invalid cigarette")
            {
                Console.WriteLine("\nCigarette");
            }
            if (Obj[5].ToString() == "Invalid pet")
            {
                Console.WriteLine("\nPet");
            }
            if (Obj[1].ToString() == "Invalid color" || Obj[2].ToString() == "Invalid nationality" || Obj[3].ToString() == "Invalid drink" || Obj[4].ToString() == "Invalid cigarette" || Obj[5].ToString() == "Invalid pet")
            {
                Console.WriteLine("*****************************");
            }
        }

        public static string Performance(int result)
        {
            string print;
            if (result == 0)
            {
                print = "\nFailed";
            }
            else if (result == 14)
            {
                print = "\nPassed";
            }
            else
            {
                print = "\nFair";
            }
            return print;
        }

        public static void PrintPerformance(String [] failed, int fail, string print, int result)
        {
            Console.WriteLine("\n\nPoints scored: " + result);
            Console.WriteLine("Result: " + print);
            Console.WriteLine("\nFailed: " + fail);
            if (fail > 0)
            {
                Console.WriteLine("\nYou failed the riddles below");
                foreach (string failed_rule in failed)
                {
                    System.Console.Write("\n" + failed_rule);
                }
            }
        } 
    }
}
