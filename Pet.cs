using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsimulatorGUI
{
    class Pet
    {
        public string name;
        public int battery = 100;
        private Mood mood;
        public Pet(string Name, int battery)
        {
            this.name = Name;
            this.battery = battery;
            this.mood = new Mood(battery);
        }
        public Pet(string Name) : this(Name, 100)
        { }
        public string checkmood()
        {
            mood = new Mood(battery);
            return name + " is " + mood.GetMood() + "!";
        }
        virtual public string toeat()
        {
            battery += 10;
            if (battery > 100)
                battery = 100;
            return name + " " + "is eating now!";
        }
        virtual public string toplay()
        {
            battery -= 10;
            if (battery < 0)
                battery = 0;
            return name + " " + "is playing now!";
        }
        virtual public string sound()
        {
            return name + " " + "is making a sound";
        }

    }




    class Mood
    {
        private int batteryLevel;

        public Mood(int batteryLevel)
        {
            this.batteryLevel = batteryLevel;
        }

        public string GetMood()
        {
            if (batteryLevel > 80)
                return "Energetic";
            else if (batteryLevel > 60)
                return "Happy";
            else if (batteryLevel > 40)
                return "Okay";
            else if (batteryLevel > 20)
                return "Tired";
            else if (batteryLevel > 5)
                return "Almost Dead";
            else
                return "Dead";
        }
    }




    class Mammal : Pet
    {
        public Mammal(string Name, int battery) : base(Name, battery)
        { }
        public Mammal(string Name) : this(Name, 100)
        { }
        public string sit()
        {
            return name + " is sitting!";
        }
    }





    class Dog : Mammal
    {
        public Dog(string Name, int battery) : base(Name, battery) { }
        public Dog(string Name) : this(Name, 100)
        { }

        public override string sound()
        {
            return name + " " + "is barking!";
        }
        public string tail()
        {
            if (battery == 100 || battery > 50)
            {
                return name + " is waving its tail!";
            }
            return name + " is too tired to wave its tail.";

        }


    }




    class Cat : Pet
    {
        public Cat(string Name, int battery) : base(Name, battery)
        { }
        public Cat(string Name) : this(Name, 100)
        { }
        public override string sound()
        {
            return name + " " + "is meowing!";
        }
        public string purr()
        {
            if (battery == 100 || battery > 50)
            {
                return name + " " + "is purring!";
            }
            return name + " " + "is too tired now.";

        }



    }





    class Bird : Pet
    {
        public Bird(string Name, int battery) : base(Name, battery)
        { }
        public Bird(string Name) : this(Name, 100)
        { }
        public override string sound()
        {
            return name + " " + "is singing!";
        }
        public string Fly()
        {
            if (battery == 100 || battery > 50)
            {
                return name + "  is flying away!";
            }
            return name + " is too tired now.";

        }
    }





    class Fish : Pet
    {
        public Fish(string name, int battery) : base(name, battery)
        { }
        public Fish(string Name) : this(Name, 100)
        { }
        public string bubbles()
        {
            return name + " is making bubbles!";
        }
    }

}




