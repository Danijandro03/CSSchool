using System;
using System.Collections.Generic;
using Coreschool;
using Coreschool.Entities;
using Coreschool.Util;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EngineSchool();
            engine.Init();
            Printer.WriteTitle("Bienvenido a la Escuela");
            Printer.Beep(10000, count: 2);
            PrintCourseSchool (engine.School);
        }

        private static void PrintCourseSchool(School school)
        {
            Printer.WriteTitle("Courses of School");

            if (school?.Courses != null)
            {
                foreach(var course in school.Courses)
                {
                    WriteLine($"Nombre {course.Name}, Id {course.UniqueId}");
                }
            }
        }
    }
}
