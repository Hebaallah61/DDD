using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernal
{
    public abstract class AggregateRoot<TId>: Entity<TId>
    {
        private readonly List<DomainEvent> events;
        protected AggregateRoot(TId id):base(id) { }
      
        public IReadOnlyCollection<DomainEvent> Events => events;
        public void RaiseEvent(DomainEvent @event)
        {
            events.Add(@event);
        }

    }
}
