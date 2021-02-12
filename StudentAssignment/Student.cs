using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignment
{
    public class Student:IDisposable
    {
        public string GetScoreOfStudents(int [,] arr, int n, int m)
        {
            try
            {
                int minAvg = 0; 
                int iVal = 0;
                for (int i = 0; i < m; i++)
                {
                    int colTotal = 0; int avg = 0;
                    for (int j = 0; j < n; j++)
                    {
                        colTotal += arr[j, i];
                    }
                    avg = colTotal / n;

                    if (i == 0)
                    {
                        minAvg = avg;
                    }
                    else
                    {
                        if (avg < minAvg)
                        {
                            minAvg = avg;
                            iVal = i;
                        }
                    }

                }

                int[] Result = new int[m - 1];

                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (j != iVal)
                            sum += arr[i, j];
                    }
                    Result[i] = sum;
                }
                Array.Sort(Result);
                Array.Reverse(Result);
                string outStr = "Output: {";
                for (int i = 0; i < Result.Length - 1; i++)
                {
                    outStr += Result[i] + ",";
                }
                outStr = outStr.TrimEnd(',');
                outStr += "}";


                return outStr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
