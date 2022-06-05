using System;

namespace projects {


    enum Type { Enemy, Hero, Traitor }
    class Killer : Robot {
        public int Health { get; set;}
        public Type type;
        public Killer() {}

        public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates) {
            this.Health = health;
            this.type = type;
        }

        public override void printValues() {
            System.Console.WriteLine(this.Name + " weight " + this.Weight);
            System.Console.WriteLine("Health: " + this.Health);

            if(this.type == Type.Enemy)
            System.Console.WriteLine("It`s enemy!");
        }

        public void Lazer() {
            System.Console.WriteLine("Lazer shooting!");
            this.surname = "Doe";
        }

        
    }
}