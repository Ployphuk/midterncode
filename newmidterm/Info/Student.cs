public class Student: Info{
    private int year;
    private string school;

    public Student(string prefix, string name, string surname, int age, string allergy, string religion,string mail, string password, int year, string school)
    : base(prefix, name, surname, age, allergy, religion,mail,password) {
        this.year = year;
        this.school = school;
    }
    
}