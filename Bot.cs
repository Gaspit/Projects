using System;

namespace projects {

    class Bot : Robot {

        public Bot() {}

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates) {

        }

        public override void printValues(){
            System.Console.WriteLine(this.Name + " weight " + this.Weight + ". Coordinates: ");
            foreach(byte el in this.Coordinates)
                System.Console.WriteLine(el);
        }
    }
}