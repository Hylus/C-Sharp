using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolekcje_nauka1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Perosn> PersonList = new List<Perosn>();
            PersonList.Add(new Perosn(1, "Andrzej", "Kowalski", 30));

            Console.WriteLine(PersonList.Count);

            PersonList.Add(new Perosn(2, "Jan", "Kowalski", 100));
            PersonList.Add(new Perosn(5, "Jan", "Kowalski", 800));
            PersonList.Add(new Perosn(3, "Pawel", "Kowalski", 50));
            PersonList.Add(new Perosn(4, "Darek", "Kowalski", 40));
            PersonList.Add(new Perosn(6, "Jan", "Kowalski", 10));

            Console.WriteLine(PersonList.Count);

            foreach (Perosn fePerson in PersonList)
            {
                Console.WriteLine("Id: " + fePerson.ID + " Imie: " + fePerson.FirstName + " Naziwkso " + fePerson.LastName + " wiek: " + fePerson.Age);

            }


            Perosn ZnajdzOsobe = PersonList.Find(SzukajElementu => SzukajElementu.Age == 10);

            List<Perosn> ListaJanow = PersonList.FindAll(x => x.FirstName.Equals("Jan"));

            bool exist = PersonList.Exists(x => x.FirstName.Equals("Anna"));

            PersonList.Reverse();

            PersonList.Insert(2, new Perosn(100, "HH", "JJ", 256));


            PersonList.Insert(7, new Perosn(100, "HH", "JJ", 256));


            Perosn obiekt = new Perosn(100, "HH", "JJ", 256);
            obiekt.ID = 800;


            ////////


            Dictionary<int, Perosn> PersonDictionary = new Dictionary<int, Perosn>();
            PersonDictionary.Add(1, new Perosn(2, "Jan", "Kowalski", 500));
            PersonDictionary.Add(2, new Perosn(2, "Wan", "b", 100));
            PersonDictionary.Add(3, new Perosn(2, "Tran", "a", 130));

            if (PersonDictionary.ContainsKey(1))
            {
                Perosn person = PersonDictionary[1];
            }

            


            Class1<int> klasa1 = new Class1<int>(15);


            ConsoleKey Key = Console.ReadKey().Key;
        }
    };
}
