using System;
using System.Collections.Generic;
using System.Linq;
using Coreschool.Entities;

namespace Coreschool
{

    public class EngineSchool
    {
        Random rnd = new Random();
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
            AsignatureLoad();
            EvaluationLoad();
        }

        private void CourseLoad()
        {
            School.Courses = new List<Course>()
            {
                        new Course() { Name = "101", CourseTime = SchedulesType.mañana },
                        new Course() { Name = "201", CourseTime = SchedulesType.noche },
                        new Course() { Name = "301", CourseTime = SchedulesType.tarde },
                        new Course() { Name = "401", CourseTime = SchedulesType.mañana },
                        new Course() { Name = "501", CourseTime = SchedulesType.noche}
            };


            
        }
        private void AsignatureLoad()
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
                
                Course.Asignature = ListAsignatures;                         
            }
            
        }
        private void EvaluationLoad()
        {
            foreach (var Course in School.Courses)
            {
                foreach (var Asignature in Course.Asignature){

                    List<Evaluation> ListEvaluation = new List<Evaluation>()
                    {
                        new Evaluation{Asignature = Asignature,},
                        new Evaluation{Asignature = Asignature},
                        new Evaluation{Asignature = Asignature},
                        new Evaluation{Asignature = Asignature},
                        new Evaluation{Asignature = Asignature}
                    };
                    
                    Asignature.evaluations = ListEvaluation;
                }

                EvaluationLoad(Course.Asignature);
            }
        }

        private void EvaluationLoad(List<Asignature> asignature)
        {
            foreach(var Course in School.Courses)
            {
                int cantRandom = rnd.Next(5, 20);
                Course.Students = StudentCreate(cantRandom);
            }
            
            
            foreach (var e in asignature)
            {
                Double notRandom = rnd.NextDouble()*(5.0 - 0.0)+0.0;
                e.Note = notRandom;
                string ev = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0,8);
                e.Name = ev;
            }
            

        }

        private List<Student> StudentCreate(int stu)
        {
            string[] name = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var StudentList = from n1 in name
                              from n2 in lastname
                              from n3 in name2
                              select new Student { Name=$"{n1} {n3} {n2}"}; 

            return StudentList.OrderBy((al)=>al.UniqueId).Take(stu).ToList();
        }
/*         private void EvaluationLoad()
        {
            throw new NotImplementedException();
        }    */
       
    }

}