using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1
{
    internal class applicatiooncontext:DbContext
    {
        public DbSet<users> users { get; set; }

        public applicatiooncontext() : base("PizzaOrdersEntities") { }


    }
}
