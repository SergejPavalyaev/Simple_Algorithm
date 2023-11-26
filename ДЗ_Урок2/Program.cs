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
            // System.Console.WriteLine(number);
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

    }
}