using System;
namespace Coreschool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Course() => UniqueId = Guid.NewGuid().ToString(); 

        public SchedulesType CourseTime {get; set;}
        //{
          //  ID = Guid.NewGuid().ToString();
        //}



    }
}