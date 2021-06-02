using System;

namespace einsteins_Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string print;
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
            Methods.PrintRules(rules);
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
                result = Methods.Points(result,counter,grid, Obj_House.Number, Obj_Person.Color, Obj_Person.Nationality, Obj_Person.Drink, Obj_Person.Cigarette, Obj_Person.Pet);
                fail = Methods.Failed(fail,rules,failed,grid,counter, Obj_House.Number, Obj_Person.Color, Obj_Person.Nationality, Obj_Person.Drink, Obj_Person.Cigarette, Obj_Person.Pet);
                counter++;
            }
            print = Methods.Performance(result);
            Methods.PrintPerformance(failed, fail, print,result);
        }
    }
}
