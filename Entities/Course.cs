using System;
namespace Coreschool.Entities
{
    public class Course
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Course() => ID = Guid.NewGuid().ToString(); 
        //{
          //  ID = Guid.NewGuid().ToString();
        //}



    }
}