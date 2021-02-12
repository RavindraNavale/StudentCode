using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int n = 3;
            //int m = 5;
            //int[,] arr = { { 75, 76, 65, 87, 87 }, { 78, 76, 68, 56, 89 }, { 67, 87, 78, 77, 65 } };

            Console.Write("input1: Number of students:\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("input2: Number of subjects:\n");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];

            Console.Write("Please Enter per Student per subject Marks:\n\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[Student:{0},Subject:{1}] Marks = ", i + 1, j + 1);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            using (Student std = new Student())
            {
                string str = std.GetScoreOfStudents(arr, n, m);
                Console.Write("students total marks after deducting the score for one subject. :\n");
                Console.Write(str);
                Console.ReadLine();
            }

        }
    }
}
