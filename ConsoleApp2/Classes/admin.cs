using ConsoleApp2.Interfaces;
using ConsoleApp2.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class admin : addProduct,IUser
    {
       public string Name { get; set; }

        
    }
 }

