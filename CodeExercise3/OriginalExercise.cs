using System;
using System.Collections;

namespace Coding.OriginalExercise
{
    // TODO: optimize this class
    public class OriginalMatrix : IEnumerable
    {
        private int[,] _data;
        
        public int Rows { get { return _data.GetLength(0); } }
        public int Columns { get { return _data.GetLength(1); } }

        public int this[int row, int col]
        {
            get { return _data[row, col]; }
            set { _data[row, col] = value; }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
        
        public OriginalMatrix(int[,] value)
        {
            _data = value;
        }
    }
    
    public class OriginalExercise
    {
        public static OriginalMatrix Multiply(OriginalMatrix a, OriginalMatrix b)
        {
            var result = new OriginalMatrix( new int[a.Rows, b.Columns] );
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
