namespace ДЗ_Урок2
{
    public class Program{
        public static void Main (string [] args){
            int number;
            // System.Console.Write("Task 1. Input number => ");
            // number = InputNumber();
            // if (number % 7 == 0 & number % 23 == 0)
            // {
            //     System.Console.WriteLine($"Number {number} is divided on 7 and 23.");
            // } else
            // {
            //     System.Console.WriteLine($"Number {number} isn't divided on 7 and 23.");

            // }
            // System.Console.WriteLine("Task 2");
            // int limit = 0;
            // System.Console.Write("Input X => ");
            // int X = InputNumberNoNull(limit);
            // System.Console.Write("Input Y => ");
            // int Y = InputNumberNoNull(limit);
            // System.Console.WriteLine(CoordinateQuarter(X,Y));
            System.Console.WriteLine("Task 3");
            System.Console.Write("Input number in 10 at 99 => ");
            number = InputNumberInLimit();
            System.Console.WriteLine($"Max numeric is {MaxNumeric(number)}");
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
            Int32.TryParse(numString, out numInt);
            while (numInt == limit)
            {
                System.Console.WriteLine("Input no null, try again");
                numString = Console.ReadLine();
                Int32.TryParse(numString, out numInt);
            }
            return numInt;
        }
        public static int InputNumberInLimit() {
            string ? numString = System.Console.ReadLine();
            int numInt;
            Int32.TryParse(numString, out numInt);
            bool flag;
            if (Math.Log10(numInt) >= 1 & Math.Log10(numInt) < 2) flag = false;
            else flag = true;
            while (flag)
            {
                System.Console.WriteLine("Input isn't at [10,99], try again");
                numString = Console.ReadLine();
                Int32.TryParse(numString, out numInt);
                if (Math.Log10(numInt) >= 1 & Math.Log10(numInt) < 2) flag = false;
            }
            return numInt;
        }
        public static string CoordinateQuarter (int X, int Y){
            if (X > 0 & Y > 0) return "Dot is the I Quarter";
            if (X > 0 & Y < 0) return "Dot is the II Quarter";
            if (X < 0 & Y > 0) return "Dot is the III Quarter";
            return "Dot is the IV Quarter";
        }
        public static int MaxNumeric (int number){
            int temp1 = number / 10;
            int temp2 = number % 10;
            if (temp1 >= temp2) return temp1;
            else return temp2;
        }
    }
}