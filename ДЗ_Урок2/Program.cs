namespace ДЗ_Урок2
{
    public class Program{
        public static void Main (string [] args){
            //Task_1
            System.Console.Write("Task 1. Input number => ");
            int number = InputNumber();
            if (number % 7 == 0 & number % 23 == 0)
            {
                System.Console.WriteLine($"Number {number} is divided on 7 and 23.");
            } else
            {
                System.Console.WriteLine($"Number {number} isn't divided on 7 and 23.");

            }
            System.Console.WriteLine("Task 2");
            int limit = 0;
            System.Console.WriteLine("Input X => ");
            int X = InputNumberNoNull(limit);
            System.Console.WriteLine("Input X => ");
            int Y = InputNumberNoNull(limit);
            System.Console.WriteLine(CoordinateQuarter(X,Y));
            System.Console.WriteLine("Task 3");
            int limit1 = 10;
            int limit2 = 99;
            int number = InputNumberInLimit(limit1, limit2);
        }
        public static int InputNumber() {
            string ? numString = System.Console.ReadLine();
            int numInt;
            while (! Int32.TryParse(numString, out numInt))
            {
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            return numInt;
        }
        public static int InputNumberNoNull(int limit) {
            string ? numString = System.Console.ReadLine();
            int numInt;
            while (! Int32.TryParse(numString, out numInt))
            {
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            while (numInt == limit)
            {
                System.Console.WriteLine("Input no null, try again");
                numString = Console.ReadLine();
                Int32.TryParse(numString, out numInt);
            }
            return numInt;
        }
        public static int InputNumberInLimit(int limit1, int limit2) {
            string ? numString = System.Console.ReadLine();
            int numInt;
            while (! Int32.TryParse(numString, out numInt))
            {
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            while (numInt < limit1 & numInt > limit2)
            {
                System.Console.WriteLine("Input no null, try again");
                numString = Console.ReadLine();
                Int32.TryParse(numString, out numInt);
            }
            return numInt;
        }
        public static string CoordinateQuarter (int X, int Y){
            if (X > 0 & Y > 0) return "Dot is the I Quarter";
            if (X > 0 & Y < 0) return "Dot is the II Quarter";
            if (X < 0 & Y > 0) return "Dot is the III Quarter";
            return "Dot is the VI Quarter";
        }
    }
}