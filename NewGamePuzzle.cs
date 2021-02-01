using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class NewGamePuzzle
    {
        string[,] mat;
        int N; // number of columns/rows. 
        int SRN; // square root of N 
        int K; // No. Of missing digits 

        public string[,] Mat
        {
            get { return mat; }
            set { mat = value; }
        }

        // Constructor 
        public NewGamePuzzle(int N, int K)
        {
            this.N = N;
            this.K = K;

            // Compute square root of N 
            Double SRNd = Math.Sqrt(N);
            SRN = (int)SRNd;

            mat = new string[N, N];
        }

        // Sudoku Generator 
        public void fillValues()
        {
            // Fill the diagonal of SRN x SRN matrices 
            fillDiagonal();

            // Fill remaining blocks 
            fillRemaining(0, SRN);

            // Remove Randomly K digits to make game 
            removeKDigits();
        }

        // Fill the diagonal SRN number of SRN x SRN matrices 
        public void fillDiagonal()
        {

            for (int i = 0; i < N; i = i + SRN)

                // for diagonal box, start coordinates->i==j 
                fillBox(i, i);
        }

        // Returns false if given 3 x 3 block contains num. 
        public bool unUsedInBox(int rowStart, int colStart, int num)
        {
            for (int i = 0; i < SRN; i++)
                for (int j = 0; j < SRN; j++)
                    if (mat[rowStart + i, colStart + j] == num.ToString())
                        return false;

            return true;
        }

        // Fill a 3 x 3 matrix. 
        public void fillBox(int row, int col)
        {
            int num;
            for (int i = 0; i < SRN; i++)
            {
                for (int j = 0; j < SRN; j++)
                {
                    do
                    {
                        num = randomGenerator(N);
                    }
                    while (!unUsedInBox(row, col, num));

                    mat[row + i, col + j] = num.ToString();
                }
            }
        }

        // Random generator 
        public int randomGenerator(int num)
        {
            Random random = new Random();
            return (int)Math.Floor((random.NextDouble() * num + 1));
        }

        // Check if safe to put in cell 
        public bool CheckIfSafe(int i, int j, int num)
        {
            return (unUsedInRow(i, num) &&
                    unUsedInCol(j, num) &&
                    unUsedInBox(i - i % SRN, j - j % SRN, num));
        }

        // check in the row for existence 
        public bool unUsedInRow(int i, int num)
        {
            for (int j = 0; j < N; j++)
                if (mat[i, j] == num.ToString())
                    return false;
            return true;
        }

        // check in the row for existence 
        public bool unUsedInCol(int j, int num)
        {
            for (int i = 0; i < N; i++)
                if (mat[i, j] == num.ToString())
                    return false;
            return true;
        }

        // A recursive function to fill remaining  
        // matrix 
        public bool fillRemaining(int i, int j)
        {
            //  System.out.println(i+" "+j); 
            if (j >= N && i < N - 1)
            {
                i = i + 1;
                j = 0;
            }
            if (i >= N && j >= N)
                return true;

            if (i < SRN)
            {
                if (j < SRN)
                    j = SRN;
            }
            else if (i < N - SRN)
            {
                if (j == (int)(i / SRN) * SRN)
                    j = j + SRN;
            }
            else
            {
                if (j == N - SRN)
                {
                    i = i + 1;
                    j = 0;
                    if (i >= N)
                        return true;
                }
            }

            for (int num = 1; num <= N; num++)
            {
                if (CheckIfSafe(i, j, num))
                {
                    mat[i, j] = num.ToString();
                    if (fillRemaining(i, j + 1))
                        return true;

                    mat[i, j] = "0";
                }
            }
            return false;
        }

        // Remove the K no. of digits to 
        // complete game 
        public void removeKDigits()
        {
            int count = K;
            while (count != 0)
            {
                int cellId = randomGenerator(N * N);
                Random random = new Random();
                // System.out.println(cellId); 
                // extract coordinates i  and j 
                int i = (cellId / N);
                if (i == 9) i = i - 1;
                int j = cellId % 9;
                if (j != 0)
                    j = j - 1;

                int index = random.Next(9);
                int jndex = random.Next(9);

                // System.out.println(i+" "+j); 
                if (mat[index, jndex] != "0")
                {
                    count--;
                    mat[index, jndex] = "0";
                }
            }
        }

        // Print sudoku 
        public void printSudoku()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < N; j++)
                {
                    if (j == N - 1)
                    {
                        if (mat[i, j] == "0")
                            Console.Write($"\'.\'");
                        else
                            Console.Write($"\'{mat[i, j]}\'");
                    }
                    else
                    {
                        if (mat[i, j] == "0")
                            Console.Write($"\'.\', ");
                        else
                            Console.Write($"\'{mat[i, j]}\'," + " ");
                    }
                }
                Console.Write(" }");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
