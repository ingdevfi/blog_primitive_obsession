﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveObsession
{
    class Price
    {
        private double _value;

        public static implicit operator Price(double value) { return new Price { _value = value }; }
        
        public static bool operator ==(Price one, Price other) { return one._value == other._value; }
        public static bool operator !=(Price one, Price other) { return !(one == other); }
        public static bool operator >(Price one, Price other)  { return one._value > other._value; }
        public static bool operator <=(Price one, Price other) { return !(one > other); }
        public static bool operator >=(Price one, Price other) { return !(one < other); }
        public static bool operator <(Price one, Price other)  { return one._value < other._value ; }

        public override bool Equals(object obj)
        {
            var other = obj as Price;

            if (other == null) return false;
            return other._value == _value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
