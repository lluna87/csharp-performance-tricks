using System.Collections;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Matrix : System.Collections.Generic.IEnumerable<int>
    {
        int _rowCount = 0;
        int _columnCount = 0;
        private int[] _data;
        
        public int Rows { get { return this._rowCount; } }
        public int Columns { get { return this._columnCount; } }

        public int this[int rows, int columns]
        {
            get { return this._data[rows * _columnCount + columns]; }
            set { this._data[rows * _columnCount + columns] = value; }
        }
        
        private int[] Flatten(int[,] value) {
            int currentCell = 0;
            int localRowCount = value.GetUpperBound(0) + 1;
            int localColumnCount = value.GetUpperBound(1) + 1;

            int[] result = new int[localRowCount * localColumnCount];
            for(int i = 0; i < localRowCount; i++) {
                for(int j = 0; j < localColumnCount; j++) {
                    result[currentCell++] = value[i, j];
                }
            }

            return result;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<int>)_data).GetEnumerator();
        }

        public Matrix(int[,] value)
        {
            this._rowCount = value.GetUpperBound(0) + 1;
            this._columnCount = value.GetUpperBound(1) + 1;
            this._data = this.Flatten(value);
        }

    }
    
    public class Exercise
    {
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            var result = new Matrix(new int[a.Rows, b.Columns]);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < a.Columns; k++) 
                    result[i, j] += (a[i, k] * b[k, j]);
                }
            }
            return result;
         }
    }
}
