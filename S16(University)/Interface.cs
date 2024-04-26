public interface IUni
{
    void AddDepartment(Department New);
    void RemoveDepartment(Department Old);

    void AddAdministration(Administration New);

    void RemoveAdministration(Administration Old);

}

public interface IDEpartment
{
    
     void AddTeacher(Teachers NewTeacher);

     void RemoveTeacher(Teachers unwanted);

     void AddStudent(Students NewStudent);

     void RemoveStudent(Students unwanted);

     void AddEmployee(Employees NewEmployee);

     void RemoveEmployee(Employees unwanted);

     void AddStudentsGroup(StudentsGroup NewStudentsGroup);

     void RemoveStudentsGroup(StudentsGroup unwanted);

}

public interface IAdministration
{
    void AddEmployee(Employees NewEmployee);

    void RemoveEmployee(Employees unwanted);

}

public interface IStudentTeacher
{
     void AddCourse(Course course);

     void RemoveCourse(Course course);

}
public interface IStudent
{
     void AddGrade(Grade grade);

     void RemoveGrade(Grade grade);

    int Avg();
}
public interface IPlace
{
    int ToltalSalary();
    void PrintAllMembers();
}