using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Catalog.Domain
{
    public /*class*/ record Category//:ValueObject
    {
      
        public string CatName { get; set; }
        public string CatDescription { get; set; }

        //protected override IEnumerable<object> GetAtomicValues()
        //{
        //    yield return CatName;
        //    yield return CatDescription;
        //}
    }
}
