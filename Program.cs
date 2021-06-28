using System;
using System.Collections.Generic;
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

            //Creo variable de lista, va a traajar con Course ya definido

            School.Courses = new List<Course>(){
                new Course(){Name = "101",CourseTime = SchedulesType.mañana},
                new Course(){Name = "201",CourseTime = SchedulesType.mañana},
                new Course(){Name = "301",CourseTime = SchedulesType.mañana}
            };
            //Agrego cursos a la lista(Objeto que se deja enumerar)
            School.Courses.Add(new Course() { Name = "102", CourseTime = SchedulesType.tarde });
            School.Courses.Add(new Course() { Name = "202", CourseTime = SchedulesType.tarde });
            //

            var otCollect = new List<Course>(){
                new Course(){Name = "401",CourseTime = SchedulesType.mañana},
                new Course(){Name = "501",CourseTime = SchedulesType.mañana},
                new Course(){Name = "502",CourseTime = SchedulesType.tarde}
            };

            //Vaciar list
            /* otCollect.Clear();  */


            //a la colección de cursos school.course agrego los cursos de la variable otcollect
/*             School.Courses.AddRange(otCollect);
            //Crea curso solo, suelto
            //Course tmp = new Course{Name = "101-Vacaional", CourseTime = SchedulesType.noche};
            //Agrego curso tmp a School.Courses
            //School.Courses.Add(tmp);
            printCourseSchool(School);
            //WriteLine("Curso tmp.Hash " + tmp.GetHashCode());
            School.Courses.RemoveAll(delegate(Course cur)
            {
                return cur.Name == "301";
            } );
            School.Courses.RemoveAll((cur) => cur.Name == "501" && cur.CourseTime == SchedulesType.mañana);

            //School.Courses.Remove(tmp);
            WriteLine("========Remove========="); */
            printCourseSchool(School);

            //crear arreglo invocando atributo de School, Asigno lista a asignación de datos en declaración de Courses dentro de School


            /*             School.Courses = new Course[]{
                            new Course(){Name = "FirstCourse"},
                            new Course(){Name = "SecondCourse"},      
                            new Course(){Name = "ThirdCourse"}
                        }; */
            //School = null;        
            //Imprimir en consola:
            /*          
         /*             System.Console.WriteLine("==============================");
                     PrintCourseWhile(arCourse);
                     System.Console.WriteLine("==============================");
                     PrintCourseDoWhile(arCourse);
                     System.Console.WriteLine("==============================");
                     PrintCourseFor(arCourse);
                     System.Console.WriteLine("==============================");
                     PrintCourseForEach(arCourse); */
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

        private static bool Predicate(Course courobj)
        {
            return courobj.Name == "301";
        }
        
        private static void printCourseSchool(School school)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Course of School");
            Console.WriteLine("=================================");
            if (school.Courses == null)
                return;
            else
            {

                foreach (var Course in school.Courses)
                {
                    Console.WriteLine($"Nombre {Course.Name}, id {Course.Id}");
                }

            }

        }
        /* private static void PrintCourseWhile(Course[] arCourse)
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
        }*/
    }
}
