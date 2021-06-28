using SchoolType;

namespace Coreschool.Entities
{
    public class SchoolEngine
    {

    }

    public void Init()
    {
        School SchoolEngine = new School("Platzi Academy", 2012, SchedulesType.mañana,
                                    country: "colombia", city: "Bogota");
        SchoolEngine.Courses.Add(new Course(){Name = "101", CourseTime = SchedulesType.tarde});
        SchoolEngine.Courses.Add(new Course(){Name = "201", CourseTime = SchedulesType.tarde});
        SchoolEngine.Courses.Add(new Course(){Name = "301", CourseTime = SchedulesType.tarde});
        SchoolEngine.Courses.Add(new Course(){Name = "401", CourseTime = SchedulesType.tarde});
        SchoolEngine.Courses.Add(new Course(){Name = "501", CourseTime = SchedulesType.tarde});

    }


}
