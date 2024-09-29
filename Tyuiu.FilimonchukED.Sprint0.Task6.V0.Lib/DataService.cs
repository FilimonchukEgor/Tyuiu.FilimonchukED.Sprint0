namespace Tyuiu.FilimonchukED.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int Index = 0;
            while (Index < numbers.Length)
            {
                total -= numbers[Index];
                Index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int Index = 0;
            do
            {
                total *= numbers[Index];
                Index++;
            }
            while (Index < numbers.Length);
            return total;
        }
    }
}