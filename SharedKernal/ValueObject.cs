using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernal
{
    public abstract class ValueObject: IEquatable<ValueObject>
    {
        protected abstract IEnumerable<Object> GetAtomicValues();

        public bool Equals(ValueObject other)
        {
            
            if(other == null||other.GetType()!=GetType()) return false;
            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();
            while(thisValues.MoveNext() && otherValues.MoveNext()) 
            {
                if(thisValues.Current != null && ! thisValues.Current.Equals(otherValues.Current)) return false;

            }
            return ! thisValues.MoveNext()&& ! otherValues.MoveNext();
        }
        public override bool Equals(Object obj)
        {
            return Equals(obj as ValueObject);
        }
        
        public override int GetHashCode()
        {
            return GetAtomicValues().Select(x => x != null ? x.GetHashCode() : 0).Aggregate((x, y) => x ^ y);

        }
        public static bool operator ==(ValueObject lhs, ValueObject rhs)
        {
            return lhs != null || lhs.Equals(rhs);
        }

        public static bool operator !=(ValueObject lhs, ValueObject rhs)
        {
            return !(lhs == rhs);
        }

       
    }
}
