using System;
using System.Collections.Generic;
using Coreschool;
using Coreschool.Entities;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EngineSchool();

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

            SchoolProgram.Courses = new List<Course>(){
                new Course(){Name = "101",CourseTime = SchedulesType.mañana},
                new Course(){Name = "201",CourseTime = SchedulesType.mañana},
                new Course(){Name = "301",CourseTime = SchedulesType.mañana}
            };
            //Agrego cursos a la lista(Objeto que se deja enumerar)
            SchoolProgram.Courses.Add(new Course() { Name = "102", CourseTime = SchedulesType.tarde });
            SchoolProgram.Courses.Add(new Course() { Name = "202", CourseTime = SchedulesType.tarde });
            //

            var otCollect = new List<Course>(){
                new Course(){Name = "401",CourseTime = SchedulesType.mañana},
                new Course(){Name = "501",CourseTime = SchedulesType.mañana},
                new Course(){Name = "502",CourseTime = SchedulesType.tarde}
            };

            printCourseSchoolProgram(SchoolProgram);
        }
        
        private static void printCourseSchoolProgram(School SchoolProgram)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Course of School");
            Console.WriteLine("=================================");
            if (SchoolProgram.Courses == null)
                return;
            else
            {

                foreach (var Course in SchoolProgram.Courses)
                {
                    Console.WriteLine($"Nombre {Course.Name}, Horario {Course.CourseTime}");
                }

            }

        }
       
    }
}
