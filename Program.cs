using System;
using System.Collections.Generic;
using System.IO;

namespace projects {

    class Program {
        static void Main() {

            // Robot bot = new Robot("Bot", 800, new byte[] {0, 0, 0});
            // bot.printValues();
            

            // Killer killer = new Killer("Killer", 1000, new byte[] {0, 0, 10}, 100);
            // // killer.printValues();
            // killer.Lazer();

            // Robot autobot = new Robot("Harvi");
            // autobot.Width = -100;
            // System.Console.WriteLine(autobot.Width);

            // Robot.count = 5;
            // Robot.Print();

            // List<Killer> robots = new List<Killer>();
            // robots.Add(new Killer("Alex", 400, new byte[] {0, 0, 10}, 23));
            // robots.Add(new Killer("Dave", 300, new byte[] {0, 0, 10}, 41));
            // robots.Add(new Killer("Mix", 230, new byte[] {0, 0, 10}, 25));
            // robots.Add(new Killer("Tom", 160, new byte[] {0, 0, 10}, 100));

            // Robot newRobot = null;
            // foreach(Robot obj in robots) {
            //     if(obj.Name == "Mix") {
            //         newRobot = obj as Robot;
                    
            //     }
            //     System.Console.WriteLine(obj is Robot);
            // }

            // Bot bot = new Bot("Bot", 200, new byte[] {1, 2, 3});
            // bot.printValues();

            // Killer killer = new Killer("Killer", 1240, new byte[] {1, 2, 3}, 100, Type.Enemy);
            // killer.printValues();
            // killer.Lazer();

            // Bot bot1 = new Bot();
            // bot1.Weight = -100;

            // Multiply(5.7f, 6.8f);
            
            // Bot bot = new Bot();
            // bot.setValues("Jakob");

            // Book idiot = new Book();
            // idiot.setValue("Идиот", "Достаевский");
            // idiot.printValue();

            // string name = "john_cenedy";
            

            // System.Console.WriteLine(firstLetter(name));

            // IsSquare(3);

            
            double x = 5.55d;
            object objectX = x;

            int firstNumber = (int)(double)objectX;
            System.Console.WriteLine(firstNumber + "One");

            int secondNumber = (int)objectX;
            System.Console.WriteLine(secondNumber);
        
    


         }

         public static bool IsSquare(int n) {
            //Your code goes here!
            double del = Math.Sqrt(n);
            del*= del;

            if(n == Convert.ToInt32(del)) {
                return true;
            } else {
                return false;
            }
         }
        //  public static string firstLetter(string str) {
        //      if(str.Length > 0) {
        //      return Char.ToUpper(str[0]) + str.Substring(1);}
        //      return str;
        //  }

        //  public static void Multiply(int a, int b) {
        //     int res = a * b;
        //     System.Console.WriteLine("Result: " + res);
        // }
        
        // public static void Multiply(float a, float b) {
        //     float res = a * b;
        //     System.Console.WriteLine("Result: " + res);
        // }

        // public static int Sum(int x, int y) {
        //     return x + y;
        // }
    }
}