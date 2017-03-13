using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveObsession
{
    class Quantity
    {
        private readonly int _value;

        public Quantity(int value)
        {
            _value = value;
        }

        public static implicit operator Quantity(int value)
        {
            return new Quantity(value);
        }
        
        public static bool operator ==(Quantity one, Quantity other) { return one._value == other._value; }
        public static bool operator !=(Quantity one, Quantity other) { return !(one == other); }
        public static bool operator <(Quantity one, Quantity other) { return one._value < other._value; }
        public static bool operator <=(Quantity one, Quantity other) { return one == other ? true : one < other; }
        public static bool operator >(Quantity one, Quantity other) { return !(one <= other); }
        public static bool operator >=(Quantity one, Quantity other) { return !(one < other); }

        public override int GetHashCode()
        {
            return _value;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Quantity;
            if (other == null) return false;

            return this == other;
        }

        //inutile
        //public static bool operator ==(Quantity one, int other) { return one._value == other; }
        //public static bool operator !=(Quantity one, int other) { return !(one == other); }
        //public static bool operator <(Quantity one, int other) { return one._value < other; }
        //public static bool operator <=(Quantity one, int other) { return one == other ? true: one < other;}
        //public static bool operator >(Quantity one, int other) { return !(one <= other); }
        //public static bool operator >=(Quantity one, int other) { return !(one < other); }

        //public static bool operator ==(int one, Quantity other) { return other == one; }
        //public static bool operator !=(int one, Quantity other) { return !(one == other); }
        //public static bool operator <(int one, Quantity other) { return other > one; }
        //public static bool operator <=(int one, Quantity other) { return other >= one; }
        //public static bool operator >(int one, Quantity other) { return other < one; }
        //public static bool operator >=(int one, Quantity other) { return other <= one; }

        // Ne compile pas car int n'est pas un type reference
        //public static implicit operator int( Quantity qty)
        //{
        //    return _value;
        //}
    }
}
