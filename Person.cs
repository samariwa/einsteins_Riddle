using System;
namespace einsteins_Riddle
{
    public class Person
    {
        public string Nationality;
        public string Drink;
        public string Cigarette;
        public string Pet;
        public bool result = true;
        public Person(string nationality, string drink, string cigarette, string pet)
        {
            this.Nationality = nationality;
            this.Drink = drink;
            this.Cigarette = cigarette;
            this.Pet = pet;

            if ((Nationality == "Swede") && (Pet != "Dogs"))
            {
                this.result = false;
            }
        }
    }
}
