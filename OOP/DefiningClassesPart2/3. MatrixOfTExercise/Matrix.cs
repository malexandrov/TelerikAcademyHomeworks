using System;
using System.Text;

namespace _3.MatrixOfTExercise
{
    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] matrix;
        private int matrixRow;
        private int matrixCol;

        // Constructors
        public Matrix() : this(0, 0, new T[0, 0])
        {
        }
        public Matrix(int row, int col): this(row, col, new T[row,col])
        {
        }

        public Matrix (int row, int col, T[,] matrix)
        {
            this.matrix = matrix;
            this.matrixRow = row;
            this.matrixCol = col;
        }

        // Properties
        public int GetRows { get { return this.matrixRow; } }
        public int GetCols { get { return this.matrixCol; } }

        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && col >= 0 && row < this.matrixRow && col < this.matrixCol)
                {
                    return this.matrix[row,col];
                }
                else { throw new ArgumentOutOfRangeException("Index out of range!!!"); }
            }

            set
            {
                if (row >= 0 && col >= 0 && row < this.matrixRow && col < this.matrixCol)
                {
                    this.matrix[row, col] = value;
                }
                else { throw new ArgumentOutOfRangeException("Index out of range!!!"); }
            }
                
        }

        // Methods

        public void PrintMatrix()
        {
            for (int i = 0; i < GetRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < GetCols; j++)
                {
                    Console.Write("{0,4}", this.matrix[i,j]);
                }
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.GetRows; i++)
            {
                builder.Append('\n');
                for (int j = 0; j < this.GetCols; j++)
                {
                    builder.Append(this.matrix[i, j]).Append(" ");
                }
            }
            return builder.ToString();
        }
        // Operator overloading

        public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
        {
            if (left.GetRows != right.GetRows || left.GetCols != right.GetCols)
            {
                throw new FormatException();
            }
            else
            {
                int rows = left.GetRows;
                int cols = left.GetCols;
                Matrix<T> resultMatrix = new Matrix<T>(rows,cols);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)left[i, j] + right[i, j];
                    }
                }
                return resultMatrix;
            }
        }

        public static Matrix<T> operator -(Matrix<T> left, Matrix<T> right)
        {
            if (left.GetRows != right.GetRows || left.GetCols != right.GetCols)
            {
                throw new FormatException();
            }
            else
            {
                int rows = left.GetRows;
                int cols = left.GetCols;
                Matrix<T> resultMatrix = new Matrix<T>(rows, cols);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)left[i, j] - right[i, j];
                    }
                }
                return resultMatrix;
            }
        }

        public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
        {
            if (left.GetCols != right.GetRows)
            {
                throw new FormatException();
            }
            else
            {
                int rows = left.GetRows;
                int cols = right.GetCols;
                Matrix<T> resultMatrix = new Matrix<T>(rows,cols);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)0;
                        for (int k = 0; k < cols; k++)
			            {
                            resultMatrix[i, j] += (dynamic)left[i, k] * (dynamic)right[k, j];
			            }
                    }
                }
                return resultMatrix;
            }
        }
        
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetCols; i++)
            {
                for (int j = 0; j < matrix.GetRows; j++)
                {
                    int zero = 0;
                    if (matrix[i, j].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetCols; i++)
            {
                for (int j = 0; j < matrix.GetRows; j++)
                {
                    int zero = 0;
                    if (matrix[i, j].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
