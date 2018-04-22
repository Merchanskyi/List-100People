using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100People
{
    class Program
    {
        static void Main(string[] args)
        {
            var nPeople = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                nPeople.Add(i);
            }

            //Вариант колбасой
            while (nPeople.Count > 2)
            {
                nPeople = nPeople.Where((value, index) => (index + 1) % 3 != 0).ToList();
            }


            //Вариант не колбасный
            //while (nPeople.Count > 2)
            //{
            //    var nPeople2 = new List<int>();

            //    for (var index = 0; index < nPeople.Count; index++)
            //    {
            //        if ((index + 1) % 3 != 0)
            //        {
            //            nPeople2.Add(nPeople[index]);
            //        }
            //    }

            //    nPeople = nPeople2;
            //}

            Console.ReadKey();
        }
    }
}