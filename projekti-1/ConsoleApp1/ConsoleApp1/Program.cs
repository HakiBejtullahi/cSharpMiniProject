namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to mini project 1");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            int arrayLength;
            double[] userList;
            double tempNum;

            Console.Write("Please enter the length of the array: ");
            if (!int.TryParse(Console.ReadLine(), out arrayLength)) {
                Console.WriteLine();
                Console.WriteLine("Please only provide full intiger numbers");
                Console.WriteLine("Restart app to try again");
                Console.WriteLine();
                return;
            };
            userList= new double[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter number: ");
                if(!double.TryParse(Console.ReadLine(), out tempNum))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please provide only number values (ex 1,2,3.33,4.88)");
                    Console.WriteLine("Restart app to try again");
                    Console.WriteLine();
                    return;
                }
                userList[i] = tempNum;

            }


            ArrayMin newList = new ArrayMin(userList);

            Console.WriteLine();
            Console.WriteLine($" Smallest Number in list is : {newList.Min()}");

            Console.ReadKey();
        }
    }
    class ArrayMin
    {
        public double[] numbersList;

        public ArrayMin(double[] numbersList)
        {
            this.numbersList = numbersList;
        }
        public double Min ()
        {
            double tempSmallesNum = this.numbersList[0];
            for(int i =0; i < this.numbersList.Length; i++)
            {
                if(tempSmallesNum < numbersList[i])
                {
                    continue;
                }
                else
                {
                    tempSmallesNum = numbersList[i];                    
                }
            }

            return tempSmallesNum;
        }
    }
}