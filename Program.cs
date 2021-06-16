using System;
using Coreschool.Entities;
using SchoolType;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var School = new School("San Bartolome", 1604);
            School.Country = "Colombia";
            School.City = "Bogota";
            School.SchoolType = SchoolTypes.Primaria;
            Console.WriteLine(School);
        }


    }
}
