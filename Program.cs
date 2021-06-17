using System;
using Coreschool.Entities;
using SchoolType;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var School = new School("San Bartolome", 1604);

            //declarar arreglo del tipo Course con 3 posiciones y asignando de una vez valores
            var arCourse = new Course[3]
            {
                new Course(){
                Name = "FirstCourse"
                },
                new Course(){
                Name = "SecondCourse"
                },      
                new Course(){
                Name = "ThirdCourse"
                }
            };

            //Otra opción para crear arreglo
            Course[] arCourse1 = {
                new Course(){Name = "FirstCourse"},
                new Course(){Name = "SecondCourse"},      
                new Course(){Name = "ThirdCourse"}
            };

            //crear arreglo invocando atributo de School

            School.Courses = new Course[]{
                new Course(){Name = "FirstCourse"},
                new Course(){Name = "SecondCourse"},      
                new Course(){Name = "ThirdCourse"}
            };
            School = null;
            printCourseSchool(School);

        
            //Imprimir en consola:
            Console.WriteLine(School);
            System.Console.WriteLine("==============================");
            PrintCourseWhile(arCourse);
            System.Console.WriteLine("==============================");
            PrintCourseDoWhile(arCourse);
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
        private static void printCourseSchool(School school)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Course of School");
            Console.WriteLine("=================================");
            if(school.Courses == null)
            return;
            else{

                foreach (var Course in school.Courses){
                Console.WriteLine($"Nombre {Course.Name}, id {Course.ID}");
                }

            }
            
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
            do{
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
