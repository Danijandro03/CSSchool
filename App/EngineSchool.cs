using System;
using System.Collections.Generic;
using System.Linq;
using Coreschool.Entities;

namespace Coreschool
{

    public class EngineSchool
    {
        public School School { get; set; }

        public EngineSchool()
        {
            Init();
        }

        public void Init()
        {
            School = new School("Engineer", 2012, SchedulesType.mañana,
                                        country: "colombia", city: "Bogota");
            CourseLoad();
            AsigLoad();
            foreach (var Course in School.Courses)
            {
                Course.Students.AddRange(
                    StudentLoad());
            }
            EvaluationLoad();
        }


        private void EvaluationLoad()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Student> StudentLoad()
        {
            string[] name = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var StudentList = from n1 in name
                              from n2 in lastname
                              from n3 in name2
                              select new Student { Name=$"{n1} {n3} {n2}"}; 
            return StudentList;
        }

        private void AsigLoad()
        {
            foreach (var Course in School.Courses)
            {
                List<Asignature> ListAsignatures = new List<Asignature>()
                {
                    new Asignature{Name = "Math"},
                    new Asignature{Name = "Sport"},
                    new Asignature{Name = "Castellano"},
                    new Asignature{Name = "Scince"}

                };
                Course.Asignature.AddRange(ListAsignatures);
            }
        }

        private void CourseLoad()
        {
            School.Courses = new List<Course>()
            {
                        new Course() { Name = "101", CourseTime = SchedulesType.tarde },
                        new Course() { Name = "201", CourseTime = SchedulesType.tarde },
                        new Course() { Name = "301", CourseTime = SchedulesType.tarde },
                        new Course() { Name = "401", CourseTime = SchedulesType.tarde },
                        new Course() { Name = "501", CourseTime = SchedulesType.tarde }
            };

        }
    }

}