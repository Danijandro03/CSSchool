using System;
using System.Collections.Generic;

namespace Coreschool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Course() => UniqueId = Guid.NewGuid().ToString();
        public SchedulesType CourseTime { get; set; }
        //{
        //  ID = Guid.NewGuid().ToString();
        //}
        public List<Asignature> Asignature { get; set; }
        public List<Student> Students { get; set; }


    }
}