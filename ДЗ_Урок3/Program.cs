namespace ДЗ_Урок2{
    public class Program{
        public static void Main (string [] args){
            System.Console.WriteLine("Task 1");
            int limitDown = 1;
            int limitUP = 100;
            int size = 10;
            int [] array = InitArray (limitDown, limitUP, size);
            PrintArray(array);
            int searchDown = 20;
            int searchUp = 90;
            int count = CountArrayInLimit (array, searchDown, searchUp);
            System.Console.WriteLine($"{count} elements in [{searchDown},{searchUp}]");
            System.Console.WriteLine("Task 2");
            count = CountEvenNumber(array);
            System.Console.WriteLine($"{count} elemets is even");
            System.Console.WriteLine("Task 3");
            double [] doubleArray = InitDoubleArray (limitDown, limitUP, size);
            PrintDoubleArray(doubleArray);
            System.Console.WriteLine($"Substraction Max and Min = {SubtMinMax(doubleArray)}");
        }
        public static double SubtMinMax (double [] array){
            double max = array [0];
            double min = array [0];
            double result;
            foreach (double item in array)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            result = max - min;
            return result;
        }
        public static int CountEvenNumber (int [] array){
            int count = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) count++;
            }
            return count;
        }
        public static int [] InitArray (int limitDown, int limitUP, int size){
            Random rand = new Random();
            int [] array = new int [size];
            int temp;
            if (limitDown > limitUP) {
                temp = limitDown;
                limitDown = limitUP;
                limitUP = temp;
            }
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(limitDown, limitUP);
            }
            return array;
        }
        public static double [] InitDoubleArray (int limitDown, int limitUP, int size){
            Random rand = new Random();
            double [] array = new double [size];
            int temp;
            if (limitDown > limitUP) {
                temp = limitDown;
                limitDown = limitUP;
                limitUP = temp;
            }
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(limitDown, limitUP) + rand.NextDouble();
            }
            return array;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();            
        }
        public static void PrintDoubleArray (double [] array){
            foreach (double item in array)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();            
        }
        public static int CountArrayInLimit (int [] array, int searchDown, int searchUp){
            int count = 0;
            int temp;
            if (searchDown > searchUp) {
                temp = searchDown;
                searchDown = searchUp;
                searchUp = temp;
            }
            foreach (int item in array)
            {
                if (item > searchDown & item < searchUp) count++;
            }
            return count;
        }
    }
}