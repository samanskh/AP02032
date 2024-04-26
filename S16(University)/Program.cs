using System.Runtime.InteropServices;

namespace HW;

class Program
{
    static void Main(string[] args)
    {
        Teachers HeadLanguage = new Teachers("Ali","Amiri",1850,30_000);
        Teachers HeadComputer = new Teachers("Reza","Kazemi",1832,35_000);
        Teachers HeadPhysics = new Teachers("Mohammad","Gholami",1875,32_000);
        Teachers Programing = new Teachers("Saman","Akbari",1889,37_500);
        Teachers Mathematics = new Teachers("Alireza","Mirzaee",1879,36_500);
        Teachers English = new Teachers("Kazem","Ghalamchi",1887,33_000);
        Teachers French = new Teachers("Nima","Yushij",1881,34_500);
        Teachers Labratory = new Teachers("Fatemeh","Kabiri",1900,40_000);
        Teachers Electrics = new Teachers("Zeinab","Rezaee",1875,42_500);
        Students Saman = new Students("Saman","Khajeamiri",2005);
        Students Reza = new Students("Reza","Molaee",2004);
        Students Ali = new Students("Ali","Kalami",2004);
        Students Rozita = new Students("Rozita","Bagheri",2005);
        Students Yasaman = new Students("Yasaman","Amiri",2005);
        Students Maryam = new Students("Maryam","Talebi",2002);
        Students Amir = new Students("Amir","Behbahani",2004);
        Students Faezeh = new Students("Faezeh","Eshghi",2005);
        Students Nima = new Students("Nima","Hosseini",2004);
        Employees Ali_E = new Employees("Ali","Kazemi",1990,15_000);
        Employees Saman_E = new Employees("Saman","Hosseini",1985,11_000);
        Employees Nima_E = new Employees("Nima","Talebi",1987,15_500);
        Employees Zeinab_E = new Employees("Zeinab","Kazemi",1989,12_000);
        Employees Reza_E = new Employees("Reza","Molaee",1980,17_000);
        Employees Kazem_E = new Employees("Kazem","Bagheri",1983,20_000);
        Employees Alireza_E = new Employees("Alireza","Ghalamchi",1987,15_000);
        Employees Yasaman_E = new Employees("Yasaman","Gholami",1992,18_500);
        Employees Mohammad_E = new Employees("Mohammad","Kabiri",1991,15_000);
        StudentsGroup Anjoman1 = new StudentsGroup("Anjoman Elmi",Ali);
        StudentsGroup Daftar1 = new StudentsGroup("Daftar Farhangi",Reza);
        StudentsGroup Anjoman2 = new StudentsGroup("Anjoman Elmi",Amir);
        StudentsGroup Daftar2 = new StudentsGroup("Daftar Farhangi",Nima);
        StudentsGroup Anjoman3 = new StudentsGroup("Anjoman Elmi",Yasaman);
        StudentsGroup Daftar3 = new StudentsGroup("Daftar Farhangi",Rozita);

        
        Department ForeignLanguage = new Department("Foreign Language",HeadLanguage);
        ForeignLanguage.AddTeacher(HeadLanguage);
        ForeignLanguage.AddTeacher(English);
        ForeignLanguage.AddTeacher(French);
        ForeignLanguage.AddStudent(Saman);
        ForeignLanguage.AddStudent(Reza);
        ForeignLanguage.AddStudent(Ali);
        ForeignLanguage.AddEmployee(Ali_E);
        ForeignLanguage.AddEmployee(Saman_E);
        ForeignLanguage.AddEmployee(Nima_E);
        ForeignLanguage.AddStudentsGroup(Anjoman1);
        ForeignLanguage.AddStudentsGroup(Daftar1);
        Department Computer = new Department("Computer",HeadComputer);
        Computer.AddTeacher(HeadComputer);
        Computer.AddTeacher(Programing);
        Computer.AddTeacher(Mathematics);
        Computer.AddStudent(Maryam);
        Computer.AddStudent(Amir);
        Computer.AddStudent(Faezeh);
        Computer.AddEmployee(Zeinab_E);
        Computer.AddEmployee(Reza_E);
        Computer.AddEmployee(Kazem_E);
        Computer.AddStudentsGroup(Anjoman2);
        Computer.AddStudentsGroup(Daftar2);
        Department Science = new Department("Science",HeadPhysics);
        Science.AddTeacher(HeadPhysics);
        Science.AddTeacher(Labratory);
        Science.AddTeacher(Electrics);
        Science.AddStudent(Nima);
        Science.AddStudent(Yasaman);
        Science.AddStudent(Rozita);
        Science.AddEmployee(Alireza_E);
        Science.AddEmployee(Yasaman_E);
        Science.AddEmployee(Mohammad_E);
        Science.AddStudentsGroup(Anjoman3);
        Science.AddStudentsGroup(Daftar3);
        Administration Farhangi = new Administration("Farhangi",Electrics);
        Administration Pajuhesh = new Administration("Pajuhesh",French);
        Administration Danehsjuee = new Administration("Danehsjuee",Mathematics);
        Farhangi.AddEmployee(Saman_E);
        Pajuhesh.AddEmployee(Yasaman_E);
        Danehsjuee.AddEmployee(Alireza_E);

        University Elmosanat = new University("IUST","Iran",HeadComputer);
        Elmosanat.AddDepartment(ForeignLanguage);
        Elmosanat.AddDepartment(Computer);
        Elmosanat.AddDepartment(Science);
        Elmosanat.AddAdministration(Farhangi);
        Elmosanat.AddAdministration(Pajuhesh);
        Elmosanat.AddAdministration(Danehsjuee);
        Course Riazi2 = new Course("Riazi2",3);
        Course Moadelat = new Course("Moadelat",3);
        Course Farsi = new Course("Farsi",2);
        Grade Zaban = new Grade("Zaban",3,16);
        Grade Riazi1 = new Grade("Riazi1",3,17);
        Grade Fizik = new Grade("Fizik",2,18);
        HeadComputer.AddCourse(Riazi2);
        HeadComputer.AddCourse(Moadelat);
        HeadComputer.AddCourse(Farsi);
        HeadLanguage.AddCourse(Riazi2);
        HeadLanguage.AddCourse(Moadelat);
        HeadLanguage.AddCourse(Farsi);
        HeadPhysics.AddCourse(Riazi2);
        HeadPhysics.AddCourse(Moadelat);
        HeadPhysics.AddCourse(Farsi);
        Programing.AddCourse(Riazi2);
        Programing.AddCourse(Moadelat);
        Programing.AddCourse(Farsi);
        Mathematics.AddCourse(Riazi2);
        Mathematics.AddCourse(Moadelat);
        Mathematics.AddCourse(Farsi);
        English.AddCourse(Riazi2);
        English.AddCourse(Moadelat);
        English.AddCourse(Farsi);
        Saman.AddGrade(Zaban);
        Saman.AddGrade(Riazi1);
        Saman.AddGrade(Fizik);
        Saman.AddCourse(Riazi2);
        Saman.AddCourse(Moadelat);
        Saman.AddCourse(Farsi);


        System.Console.WriteLine("-----------------------");
        Saman.PrintCourses();
        Saman.PrintGrades();
        HeadComputer.PrintCourses();
        Saman.PrintCourses();
        Saman.RemoveCourse(new Course("Riazi2",3));
        Saman.PrintCourses();
        Console.WriteLine(Saman.Avg());
        Console.WriteLine(Electrics.Id);



        System.Console.WriteLine("-----------------------");
        Elmosanat.PrintAllMembers();
        Console.WriteLine(Elmosanat.ToltalSalary());
        

    }
}
