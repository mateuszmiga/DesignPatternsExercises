using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface ICartOperations // this interface could be integrated with composite class. However, we can implement this.
    {
        void Add(CartBase cart);
        void Remove(CartBase cart);
    }
}
