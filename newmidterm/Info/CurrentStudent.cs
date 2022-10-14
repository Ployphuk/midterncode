public class CurrentUniStudent: Info{
    private long studentID;

    public CurrentUniStudent(string prefix, string name,string surname, int age, string allergy,string mail, string password, string religion, long StudentID)
    : base(prefix, name, surname, age, allergy, religion,mail,password) {
        this.studentID = StudentID;
    }

    

    
}