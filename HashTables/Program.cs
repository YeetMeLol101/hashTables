namespace HashTables
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int HashNum = 150;
            const int numberOfInt = 100;
            const int repeats = 5;

            int[] Integers = new int[100];
            int[] Collisions = new int[HashNum];

            int totalCollisions = 0;

            for (int numRepeat = 0; numRepeat < repeats; numRepeat++)
            {
                for (int i = 0; i < numberOfInt; i++)
                {
                    int RandomInt = rnd.Next(100000, 10000000);

                    Integers[i] = RandomInt;
                }

                foreach (int num in Integers)
                {
                    int HashPointer = num % HashNum;

                    Collisions[HashPointer]++;
                }


                int CollisionNum = 0;
                foreach (int value in Collisions)
                {

                    if (value != 0 && value != 1)
                    {
                        CollisionNum += value;
                    }

                }
                Console.WriteLine("Number Of Collisions: {0}", CollisionNum);
                totalCollisions += CollisionNum;
            }
            int Average = totalCollisions / repeats;
            Console.WriteLine(Average);
        }
    }




}