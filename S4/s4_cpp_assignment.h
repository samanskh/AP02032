#include <iostream>
#include <string>
#include <vector>

using namespace std;
class Student {
    friend class Course;
private:
    string name;
    vector<int> grades;

public:

    Student(const string& studentName){
        name = studentName;
    }

    string& get_name()
    {
        return name;
    }
    void addGrade(int grade) {
        grades.push_back(grade);
    }

    double getAverageGrade() const {
        int sum = 0;
        int size = grades.size();
        if (size == 0)
        return 0;
        for (int i = 0; i<size;i++)
        sum += grades[i];
        return (sum / size);
    }

    string getName() const {
        return name;
    }
};

class Course {
private:
    string courseName;
    string instructorName;
    vector<Student> students;
    

public:
    Course(const string& name, const string& instructor){
        courseName = name;
        instructorName = instructor;
    }

    void add_grade(const string& studentName, int newGrade)
    {
        for (int i = 0;i<students.size();i++)
        {
            if (students[i].name == studentName)
            {
                students[i].addGrade(newGrade);
            }

        }
    }
    vector<Student>& get_student()
    {
        return students;
    }
    void addStudent(const Student& student) {
        students.push_back(student);
    }

    double getCourseAverage() const {
        if (students.size() == 0)
        return 0.0;
        double sum = 0.0;
        for (int i = 0;i<students.size();i++)
        {
            sum += students[i].getAverageGrade();
        }
        return sum / students.size();

    }
    
    string displayStudentGrades(const string& studentName) const {
        string s;
        int check = 0;
        for (int i = 0;i<students.size();i++)
        {
            if (students[i].name == studentName)
            {
                check = 1;
                for (int j = 0;j<students[i].grades.size();j++)
                {
                    s += to_string(students[i].grades[j]) + ' ';
                }
            }

        }
        string out;
        if (check == 0)
        out = "Student not found.";
        else{
        out = "Grades for " + studentName + ':' + '\n' + s + '\n';}
    return out;
    }
    
};

class Instructor {
private:
    string instructorName;
    Course& course;

public:
    Instructor(const string& name, Course& courseObj)
    :course(courseObj)
    {
        instructorName = name;
    }
    //    for (int i = 0;i<students.size();i++)
        // {
        //     if (students[i].name == studentName)
        //     {
        //         check = 1;
        //         for (int j = 0;j<students[i].grades.size();j++)
        //         {
        //             s += to_string(students[i].grades[j]) + ' ';
        //         }
        //     }
    void changeGrade(const string& studentName, int newGrade) {
        course.add_grade(studentName,newGrade);
    }
};

// int main() {
//     Course course("Programming 101", "John Doe");

//     Student student1("Alice");
//     student1.addGrade(90);
//     student1.addGrade(85);
//     student1.addGrade(95);
//     course.addStudent(student1);

//     Student student2("Bob");
//     student2.addGrade(75);
//     student2.addGrade(80);
//     student2.addGrade(70);
//     course.addStudent(student2);

//     // Calculate and display the average grade for the course
//     double courseAverage = course.getCourseAverage();
//     cout << "Average grade for the course: " << courseAverage << endl;

//     // Display grades for a specific student
//     course.displayStudentGrades("Alice");

//     // Instructor changes a student's grade
//     Instructor instructor("Jane Smith", course);
//     instructor.changeGrade("Bob", 85);

//     // Display updated grades for the student
//     course.displayStudentGrades("Bob");

//     return 0;
// }