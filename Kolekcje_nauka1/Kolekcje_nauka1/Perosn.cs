using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje_nauka1
{
    class Perosn
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName {get; private set;}
        public int Age {get; private set;}

        public Perosn (int ID, string FirstName, string LastName, int Age)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }


    };
}
