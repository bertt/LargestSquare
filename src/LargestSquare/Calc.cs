using System;

namespace LargestSquare
{
    public class Calc
    {
        public static int GetMaxSubSquare(int[,] m, int row, int cols)
        {
            // define nex matrix, same size
            var sub = new int[row,cols];

            // copy the first row
            for (int i = 0; i < cols; i++)
            {
                sub[0,i] = m[0, i];
            }

            // copy the first column
            for (int i = 0; i < row; i++)
            {
                sub[i,0] = m[i,0];
            }


            // for rest of the matrix
            // check if arrA[i][j]==1
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (m[i,j]==1)
                    {
                        sub[i,j] = Math.Min(sub[i - 1, j - 1],
                                Math.Min(sub[i, j - 1], sub[i - 1, j])) + 1;
                    }
                    else
                    {
                        sub[i, j] = 0;
                    }
                }
            }
            // find the maximum size of sub matrix
            int maxSize = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (sub[i, j] > maxSize)
                    {
                        maxSize = sub[i, j];
                    }
                }
            }
            return maxSize;
        }
    }
}

