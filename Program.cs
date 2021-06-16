using System;
using Coreschool.Entities;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var School = new School("San Bartolome", 1604);
            School.Country = "Colombia";
            School.City = "Bogota";
            Console.WriteLine(School.Name);
        }


    }
}
