public class Course
{
    public string course{get;}
    public int NumUnit{get;}
    public Course(string course,int num)
    {
        this.course = course;
        this.NumUnit = num;
    }
    public override bool Equals(object obj)
    {
        var item = obj as Course;
        if (obj == null){
            
            return false; 
        }
        return this.course.Equals(item.course);
    }
}
public class Grade:Course
{
    public int grade{get;}
    public Grade(string course,int num,int grade):base(course,num)
    {
        this.grade = grade;
    }
}