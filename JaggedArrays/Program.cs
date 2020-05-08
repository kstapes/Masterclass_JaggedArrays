using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[][] jaggedArray = new int[3][];

             jaggedArray[0] = new int[5];
             jaggedArray[1] = new int[3];
             jaggedArray[2] = new int[2];

             jaggedArray[0] = new int[] {2,3,4,5,6};
             jaggedArray[1] = new int[] { 2, 3, 4};
             jaggedArray[2] = new int[] { 2, 3};

             //Alternative way
             int[][] jaggedArray2 = new int[][] {
                 new int[] {2,3,4,5,6,7 },
                 new int[] { 1,2,3}
             };

             Console.WriteLine("First entry value {0}", jaggedArray2[0][2]);
             Console.WriteLine(jaggedArray2.Length);
             for (int x = 0; x < jaggedArray2.Length; x++)
             {
                 for (int i = 0; i < jaggedArray2[x].Length; i++)
                 {
                     Console.WriteLine(jaggedArray2[x][i]);
                 }
             }*/

            /*string[][] familyFriends = new string[][] {
                new string[] {"Trinny", "Kevin", "Marta"},
                new string[] { "Dee", "Warren", "Mars" },
                new string[] { "Barry", "John", "Dave" }
            };

            for (int x = 0; x < familyFriends.Length; x++)
            {
                Console.WriteLine("Family {0}", x+1);
                for (int i = 0; i < familyFriends[x].Length; i++)
                {

                    Console.WriteLine(familyFriends[x][i]);
                }
            }
          */
            /*int[] studentsGrades = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double averageResult = GetAverage(studentsGrades);

            Console.WriteLine("The average grade is {0}", averageResult);
            Console.ReadKey();*/

            int[] happiness = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SunIsShining(happiness);
            foreach(int x in happiness)
            {
                Console.WriteLine("New value {0}", x);
            }
            Console.ReadKey();
        }

        /*static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average; 
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }*/

        static void SunIsShining(int[] happinessArray)
        {
            for(int i = 0; i < happinessArray.Length; i++)
            {
               happinessArray[i] += 2;
            }
        }
    }
}
