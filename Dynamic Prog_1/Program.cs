using System;
using System.Linq;
//Dynamic Programming Problems
namespace Dynamic_Prog_1
{
    /*Write an algorithm to print all ways of arranging eight queens on an 8x8 chess board 
     * so that none of them share the same row, column or diagonal. 
     * In this case, “diagonal” means all diagonals, not just the two that bisect the board.
     * 
     * N Queen Problem | Backtracking Algorithm
     * The idea is to place queens one by one in different columns, starting from the leftmost column. 
     * When we place a queen in a column, we check for clashes with already placed queens. 
     * In the current column, if we find a row for which there is no clash, we mark this row and column as part of the solution. 
     * If we do not find such a row due to clashes then we backtrack and return false.
     * 
     * 1) Start in the leftmost column
        2) If all queens are placed
            return true
        3) Try all rows in the current column.  Do following for every tried row.
            a) If the queen can be placed safely in this row then mark this [row, 
                column] as part of the solution and recursively check if placing queen here leads to a solution.
            b) If placing the queen in [row, column] leads to a solution then return 
                true.
            c) If placing queen doesn't lead to a solution then umark this [row, 
                column] (Backtrack) and go to step (a) to try other rows.
        3) If all rows have been tried and nothing worked, return false to trigger 
            backtracking.
     * */

    class Program
    {
        /* to check if a queen can be placed on board[row, col]. 
         * So we need to check only left side for attacking queens */
        static bool IsSafe(int n, int[,] board, int row, int col)
        {
            int i, j;

            /* Check this row on left side */
            for (j = 0; j < col; j++)
                if (board[row, j] == 1)
                    return false;
                
            /* Check upper diagonal on left side */
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1)
                    return false;

            /* Check lower diagonal on left side */
            for (i = row, j = col; j >= 0 && i < n; i++, j--)
                if (board[i, j] == 1)
                    return false;

            return true;
        }

        static bool ArrangingQueens(int n, int[,] board, int col)
        {
            /* base case: If all queens are placed then return true */
            if (col >= n)
                return true;

            /* Consider this column and try placing this queen in all rows one by one */
            for (int i = 0; i < n; i++)
            {
                /* Check if the queen can be placed on board[i,col] */
                if (IsSafe(n, board, i, col))
                {
                    /* Place this queen in board[i][col] */
                    board[i, col] = 1;

                    /* recur to place rest of the queens */
                    if (ArrangingQueens(n, board, col + 1))
                        return true;

                    /* If placing queen in board[i,col] doesn't lead to a solution, then 
                     * remove queen from board[i, col] */
                    board[i, col] = 0; // BACKTRACK 
                }
            }

            /* If the queen cannot be placed in any row in this colum col  then return false */
            return false;
        }

        static void Main()
        {
            const int nrows = 8;
            const int ncolumns = 8;
            int queen = 8;
            int[,] matrix = new int[nrows, ncolumns];
            //matrix[0, 0] = 0;
            //matrix[0, 1] = 0;
            //matrix[0, 2] = 0;
            //matrix[0, 3] = 0;

            //matrix[1, 0] = 0;
            //matrix[1, 1] = 0;
            //matrix[1, 2] = 0;
            //matrix[1, 3] = 0;

            //matrix[2, 0] = 0;
            //matrix[2, 1] = 0;
            //matrix[2, 2] = 0;
            //matrix[2, 3] = 0;

            //matrix[3, 0] = 0;
            //matrix[3, 1] = 0;
            //matrix[3, 2] = 0;
            //matrix[3, 3] = 0;

            matrix[0, 0] = 0;
            matrix[0, 1] = 0;
            matrix[0, 2] = 0;
            matrix[0, 3] = 0;
            matrix[0, 4] = 0;
            matrix[0, 5] = 0;
            matrix[0, 6] = 0;
            matrix[0, 7] = 0;

            matrix[1, 0] = 0;
            matrix[1, 1] = 0;
            matrix[1, 2] = 0;
            matrix[1, 3] = 0;
            matrix[1, 4] = 0;
            matrix[1, 5] = 0;
            matrix[1, 6] = 0;
            matrix[1, 7] = 0;

            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 0;
            matrix[2, 3] = 0;
            matrix[2, 4] = 0;
            matrix[2, 5] = 0;
            matrix[2, 6] = 0;
            matrix[2, 7] = 0;

            matrix[3, 0] = 0;
            matrix[3, 1] = 0;
            matrix[3, 2] = 0;
            matrix[3, 3] = 0;
            matrix[3, 4] = 0;
            matrix[3, 5] = 0;
            matrix[3, 6] = 0;
            matrix[3, 7] = 0;

            matrix[4, 0] = 0;
            matrix[4, 1] = 0;
            matrix[4, 2] = 0;
            matrix[4, 3] = 0;
            matrix[4, 4] = 0;
            matrix[4, 5] = 0;
            matrix[4, 6] = 0;
            matrix[4, 7] = 0;

            matrix[5, 0] = 0;
            matrix[5, 1] = 0;
            matrix[5, 2] = 0;
            matrix[5, 3] = 0;
            matrix[5, 4] = 0;
            matrix[5, 5] = 0;
            matrix[5, 6] = 0;
            matrix[5, 7] = 0;

            matrix[6, 0] = 0;
            matrix[6, 1] = 0;
            matrix[6, 2] = 0;
            matrix[6, 3] = 0;
            matrix[6, 4] = 0;
            matrix[6, 5] = 0;
            matrix[6, 6] = 0;
            matrix[6, 7] = 0;

            matrix[7, 0] = 0;
            matrix[7, 1] = 0;
            matrix[7, 2] = 0;
            matrix[7, 3] = 0;
            matrix[7, 4] = 0;
            matrix[7, 5] = 0;
            matrix[7, 6] = 0;
            matrix[7, 7] = 0;

            PrintMatrix(matrix, nrows, ncolumns);
            Console.WriteLine("----------------");
            if (nrows < queen && ncolumns < queen)
                Console.WriteLine("There are more queens");
            else
            {
                ArrangingQueens(queen, matrix, 0);
                Console.WriteLine();
                PrintMatrix(matrix, nrows, ncolumns);
            }
            //SolveNQueens(queen, matrix);
        }

        static void PrintMatrix(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("  " + board[i, j]);
                }
                Console.WriteLine();
            }
        }


        /*-------------------------------------------------------------------------------------------*/
        /* A Optimized function to check if a queen can be placed on board[row, col] */
        static bool IsCheck(int row, int col, int[,] slashCode,
                    int[,] backslashCode, bool[] rowLookup,
                    bool[] slashCodeLookup, bool[] backslashCodeLookup )
        {
            if (slashCodeLookup[slashCode[row, col]] ||
                backslashCodeLookup[backslashCode[row, col]] || rowLookup[row])
                return false;

            return true;
        }

        /* A recursive utility function to solve N Queen problem */
        static bool SolveNQueensUtil(int n, int[,] board, int col,
                                    int[,] slashCode, int[,] backslashCode, bool[] rowLookup,
                                    bool[] slashCodeLookup, bool[] backslashCodeLookup )
        {
            /* base case: If all queens are placed then return true */
            if (col >= n)
                return true;

            /* Consider this column and try placing this queen in all rows one by one */
            for (int i = 0; i < n; i++)
            {
                /* Check if queen can be placed on board[i, col] */
                if (IsCheck(i, col, slashCode, backslashCode, rowLookup,
                            slashCodeLookup, backslashCodeLookup))
                {
                    /* Place this queen in board[i][col] */
                    board[i, col] = 1;
                    rowLookup[i] = true;
                    slashCodeLookup[slashCode[i, col]] = true;
                    backslashCodeLookup[backslashCode[i, col]] = true;

                    /* recur to place rest of the queens */
                    if (SolveNQueensUtil(n, board, col + 1, slashCode, backslashCode,
                            rowLookup, slashCodeLookup, backslashCodeLookup))
                        return true;

                    /* If placing queen in board[i, col] doesn't lead to a solution, then backtrack */

                    /* Remove queen from board[i, col] */
                    board[i, col] = 0;
                    rowLookup[i] = false;
                    slashCodeLookup[slashCode[i, col]] = false;
                    backslashCodeLookup[backslashCode[i, col]] = false;
                }
            }

            /* If queen can not be place in any row in 
                this colum col then return false */
            return false;
        }

        /* This function solves the N Queen problem using Branch and Bound. It mainly uses solveNQueensUtil() to 
        solve the problem. It returns false if queens 
        cannot be placed, otherwise return true and 
        prints placement of queens in the form of 1s. 
        Please note that there may be more than one 
        solutions, this function prints one of the 
        feasible solutions.*/
        static bool SolveNQueens(int n, int[,] board)
        {
            // helper matrices 
            int[,] slashCode = new int[n, n]; 
            int[,] backslashCode = new int[n, n]; 
  
            // arrays to tell us which rows are occupied 
            bool[] rowLookup = new bool[n];
            for (int i = 0; i < rowLookup.Length; i++)
            {
                rowLookup[i] = false;
            }

            //keep two arrays to tell us which diagonals are occupied 
            int k = 2 * n - 1;
            bool[] slashCodeLookup = new bool[k];
            for (int i = 0; i < slashCodeLookup.Length; i++)
            {
                slashCodeLookup[i] = false;
            }
            bool[] backslashCodeLookup = new bool[k];
            for (int i = 0; i < backslashCodeLookup.Length; i++)
            {
                backslashCodeLookup[i] = false;
            }

            // initalize helper matrices 
            for (int r = 0; r < n; r++)
                for (int c = 0; c < n; c++)
                {
                    slashCode[r, c] = r + c;
                    backslashCode[r, c] = r - c + 7;
                }
  
            if (SolveNQueensUtil(n, board, 0, slashCode, backslashCode, 
              rowLookup, slashCodeLookup, backslashCodeLookup) == false ) 
            {
                Console.WriteLine("Solution does not exist"); 
                return false; 
            }

            // solution found 
            PrintSolution(n, board); 
            return true; 
        }

        /* A utility function to print solution */
        static void PrintSolution(int n, int[,] board)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("  " + board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
