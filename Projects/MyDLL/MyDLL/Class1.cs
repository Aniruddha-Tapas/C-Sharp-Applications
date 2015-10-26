using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDLL
{
    namespace Clients
    {
        

       /*public*/ internal class Client
        {
           /// <summary>
           /// Persom's name. For internal use only
           /// </summary>
           public string Name
           {
               get;
               set;
           }
           /// <summary>
           /// Age
           /// </summary>
           public int Age
           {
               get;
               set;
           }
           /// <summary>
           /// Email
           /// </summary>
           public string Email
           {
               get;
               set;
           }
        }
    }
    class myClass
    {
        void MyMethod()
        {
            Clients.Client c = new Clients.Client();
           
        }
    }
}
