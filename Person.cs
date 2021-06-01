using System;
namespace einsteins_Riddle
{
    public class Person
    {
        private string nationality;
        private string drink;
        private string cigarette;
        private string pet;
        private string color;

        public Person(string _color, string _nationality, string _drink, string _cigarette, string _pet)
        {
            Color = _color;
            Nationality = _nationality;
            Drink = _drink;
            Cigarette = _cigarette;
            Pet = _pet;
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (value == "Yellow" || value == "Blue" || value == "Red" || value == "Green" || value == "White")
                {
                    color = value;
                }
                else
                {
                    color = "Invalid color";
                }
            }
        }

        public string Nationality
        {
            get { return nationality; }
            set
            {
                if (value == "Norwegian" || value == "Dane" || value == "Brit" || value == "German" || value == "Swede")
                {
                    nationality = value;
                }
                else
                {
                    nationality = "Invalid nationality";
                }
            }
        }

        public string Drink
        {
            get { return drink; }
            set
            {
                if (value == "Water" || value == "Tea" || value == "Milk" || value == "Coffee" || value == "Beer")
                {
                    drink = value;
                }
                else
                {
                    drink = "Invalid drink";
                }
            }
        }

        public string Cigarette
        {
            get { return cigarette; }
            set
            {
                if (value == "Dunhill" || value == "Blends" || value == "Pall Mall" || value == "Prince" || value == "Blue Master")
                {
                    cigarette = value;
                }
                else
                {
                    cigarette = "Invalid cigarette";
                }
            }
        }

        public string Pet
        {
            get { return pet; }
            set
            {
                if (value == "Cats" || value == "Horses" || value == "Birds" || value == "Fish" || value == "Dogs")
                {
                    pet = value;
                }
                else
                {
                    pet = "Invalid pet";
                }
            }
        }
    }
}
