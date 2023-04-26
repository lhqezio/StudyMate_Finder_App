using System.ComponentModel.DataAnnotations;

namespace StudyMate
{
    public class TakenCourses
    {
        [Key]
        public string CourseId{get;set;}
        public Courses Course{get;set;}       
        public List<Profile> Profiles{get;}=new();

        public TakenCourses(){}
        public TakenCourses(Courses course)
        {
            CourseId=Guid.NewGuid().ToString();
            Course = course;
        }

        //Override of Equals method. This is used to compare two course objects.
        public override bool Equals(object? obj)
        {
            if (obj is not TakenCourses other){
                return false;
            }   
            return Course == other.Course;
        }

        //Since we are overriding the Equals method, we must also override the GetHashCode method.
        public override int GetHashCode()
        {
            return Course.GetHashCode();
        }
    }
}
