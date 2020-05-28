using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Beers_MarkD.Backend
{
   public class Person
    {
       public string Name { get; set; }
       public  int Age { get; set; }

        public List<Beers> Beerlist;

        public Person() { }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age, List<Beers> beerlist)
        {
            Name = name;
            Age = age;
            Beerlist = beerlist;
        }


        private int Getname(DateTime date)
        {
            DateTime currenttime = DateTime.UtcNow;


            int age = currenttime.Year - date.Year;

            return age;
        }

        



        


    }
}
