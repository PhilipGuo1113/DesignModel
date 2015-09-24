using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverModel
{
    class CObject : IObject
    {
        public virtual void Update(object o)
        {
            Console.WriteLine(o.ToString());
        }
    }
}
