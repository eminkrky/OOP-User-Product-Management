using ConsoleApp2.Features;
using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class customer : buyProduct,IUser
    {
        public string Name { get; set; }

    }
}
