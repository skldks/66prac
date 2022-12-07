using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Pair
    {
        private int _first;
        private int _second;

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }


        public int First
        {
            get { return _first; }
            set { _first = value; }
        }

        public int Second
        {
            get { return _second; }
            set { _second = value; }
        }


        public Pair Substraction(Pair pair)
        {
            return new Pair(First - pair.First, Second - pair.Second);
        }
        public Pair Substraction(Pair pair, Pair pair1)
        {
            return new Pair(First - pair.First - pair1.First, Second - pair.Second - pair1.Second);
        }
        public static bool operator true(Pair pair)
        {
            if (pair.First == pair.Second && pair.First == pair.Second)
            {
                return false;
            }
            else return true;
        }
        public static bool operator false(Pair pair)
        {
            return pair.First != pair.Second;
        }
    }
}
