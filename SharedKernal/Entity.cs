using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace SharedKernal
{
    public class Entity<TId> : IEquatable<Entity<TId>>
    {
        protected Entity(TId id)
        {
            if (!IsValid(id)) throw new ArgumentException("Argument Is not valid");
            Id = id;

        }
        public TId Id { get;  }


        public override bool Equals(Object obj)
        {
            return Equals(obj as Entity<TId>);
        }
        public bool Equals(Entity<TId>? other)
        {
            return Id.GetHashCode() == other.Id.GetHashCode();
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public static bool operator==(Entity<TId> lhs, Entity<TId> rhs)
        {
            return (lhs.Equals(rhs));
        }

        public static bool operator !=(Entity<TId> lhs, Entity<TId> rhs)
        {
            return !(lhs== rhs);
        }

        private bool IsValid(TId id)
        {
            return id is int || id is long || id is Guid;
        }
    }
}