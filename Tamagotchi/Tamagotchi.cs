using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Tamagotchi
    {
        private string Name;
        private string Gender;
        private int Fullness;
        private int Happiness;

        public Tamagotchi(string name, string gender, int fullness, int happiness)
        {
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetGender()
        {
            return Gender;
        }

        public int GetFullness()
        {
            return Fullness;
        }

        public int GetHappiness()
        {
            return Happiness;
        }

        public int Pet()
        {
            Random rnd = new Random();
            Happiness += rnd.Next(5);
            return Happiness;
        }

        public void Feed()
        {
            Random rnd = new Random();
            Fullness += rnd.Next(5);
        }

        public void DoStuff()
        {
            Random rnd = new Random();
            Fullness -= rnd.Next(5);
            Happiness -= rnd.Next(5);
        }
    }
}
