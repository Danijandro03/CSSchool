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

            //declarar arreglo del tipo Course con 3 posiciones

            var arCourse = new Course[3];

            //Creo y asigno FirstCourse a posición 0
            arCourse[0] = new Course()
            {
                Name = "FirstCourse"
            };
            //Creo SecondCourse
            var curso1 = new Course()
            {
                Name = "SecondCourse"
            };
            //Asigno SecondCourse a la posición 1
            arCourse[1] = curso1;

            arCourse[2] = new Course
            {
                Name = "ThirdCourse"
            };
            //Imprimir en consola:
            Console.WriteLine(School);
            System.Console.WriteLine("==============================");
            PrintCourseWhile(arCourse);
            System.Console.WriteLine("==============================");
            PrintCourseDoWhile (arCourse);
            System.Console.WriteLine("==============================");
            PrintCourseFor(arCourse);
            System.Console.WriteLine("==============================");
            PrintCourseForEach(arCourse);

            // {
            //     
            //     //declaro objeto con segundo constructor
            //     var School1 = new School("Giralda", 2004, SchoolTypes.Secundaria, 
            //                             country: "Colombia", city: "Medelin");
            //     School.Country = "Colombia";
            //     School.City = "Bogota";
            //     School.SchoolType = SchoolTypes.Primaria;
            //     Console.WriteLine(School);
            // }

        }

        private static void PrintCourseWhile(Course[] arCourse)
        {
            int count = 0;
            while (count < arCourse.Length)
            {
                Console.WriteLine($"Nombre {arCourse[count].Name}, id {arCourse[count].ID}");
                count += 1;
            }
        }
        private static void PrintCourseDoWhile(Course[] arCourse)
        {
            int count = 0;
            do
            {
                Console.WriteLine($"Nombre {arCourse[count].Name}, id {arCourse[count].ID}");
                count++;
            }
            //se puede declarar contador++ (aumenta despues de comparar) 
            //o ++contador (lo aumenta antes de comparar)
            while (count < arCourse.Length);
        }
        private static void PrintCourseFor(Course[] arCourse)
        {
            for (int i = 0; i < arCourse.Length; i++)
            {
                Console.WriteLine($"Nombre {arCourse[i].Name}, id {arCourse[i].ID}");
            }
        }
        private static void PrintCourseForEach(Course[] arCourse)
        {
            foreach (var Course in arCourse)
            {
                Console.WriteLine($"Nombre {Course.Name}, id {Course.ID}");
            }
        }
    }
}
