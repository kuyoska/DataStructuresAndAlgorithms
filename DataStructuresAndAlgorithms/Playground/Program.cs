using Microsoft.VisualBasic;
using System.Data.Common;
using ZTMCodeInterview;

namespace Playground
{
    internal class Program
    {
        private static string[,] _face1 = new string[3, 3];
        private static string[,] _face2 = new string[3, 3];
        private static string[,] _face3 = new string[3, 3];
        private static string[,] _face4 = new string[3, 3];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var bigO = new BigO();
            //bigO.MeasureTimeExecution();
            //bigO.LogAllPairsOfArray();

            Console.WriteLine(Fibonachi(10));
            Console.WriteLine(FibonachiDP(10));

            int cont = 1;

            FillFace(_face1,ref cont, "verde");
            FillFace(_face2,ref cont, "rojo");
            FillFace(_face3,ref cont, "azul");
            FillFace(_face4,ref cont, "naranja");

            UpOposite(1);

            Console.WriteLine(_face1);
        }

        private static void UpOposite(int faceNumber)
        {
            int column = 0;
            int row = 0;

            var currentFace = GetFaceByNumber(faceNumber);

            string[] rowToMove = new string[3];

            rowToMove[0] = currentFace[column, row];
            rowToMove[1] = currentFace[column, row + 1];
            rowToMove[2] = currentFace[column, row + 2];

            var nextFace = GetFaceByNumber(faceNumber + 1);

            MoveUpOposite(rowToMove, nextFace, faceNumber + 1, faceNumber);
        }

        private static void MoveUpOposite(string[] newRow, string[,] currentFace, int faceNumber, int initialFace)
        {
            int column = 0;
            int row = 0;

            string[] rowToMove = new string[3];

            rowToMove[0] = currentFace[column, row];
            rowToMove[1] = currentFace[column, row + 1];
            rowToMove[2] = currentFace[column, row + 2];

            currentFace[column, row] = newRow[0];
            currentFace[column, row + 1] = newRow[1];
            currentFace[column, row + 2] = newRow[2];

            int nextFaceNumber = faceNumber + 1;
            nextFaceNumber = nextFaceNumber == 5 ? 1 : nextFaceNumber;
            var nextFace = GetFaceByNumber(nextFaceNumber);

            if(nextFaceNumber != initialFace)
                MoveUpOposite(rowToMove, nextFace, faceNumber + 1, initialFace);
            else
            {
                nextFace[column, row] = rowToMove[0];
                nextFace[column, row + 1] = rowToMove[1];
                nextFace[column, row + 2] = rowToMove[2];
            }
        }

        private static string[,] GetFaceByNumber(int faceNumber)
        {
            switch (faceNumber)
            {
                case 1: return _face1;
                case 2: return _face2;
                case 3: return _face3;
                case 4: return _face4;
            }

            return null;
        }

        private static void FillFace(string[,] face1,ref int cont, string color)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    face1[i, j] = $"{color}{cont}";
                    cont++;
                }
            }
        }

        static int Fibonachi(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }

        static int FibonachiDP(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            //f(0) = 0
            //f(1) = 1
            //f(n) = f(n - 1) + f(n - 2)
            
            int before = 0; //F(0)
            int current = 1; //F(1)
            int resultado = 0;

            for(int i = 2; i <= number; i++)
            {
                resultado = before + current;
                before = current;
                current = resultado;
            }

            return resultado;
        }
    }
}
