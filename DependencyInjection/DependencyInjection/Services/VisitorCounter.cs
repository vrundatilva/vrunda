using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class VisitorCounter
    {
        public int count { get;set; }
        public int Getcount()
        {
            count++;
            return count;
        }
    }
}
