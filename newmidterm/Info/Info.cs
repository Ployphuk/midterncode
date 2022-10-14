using System;

public class Info{
    private string prefix;
    private string name;
    private string surname;
    private int age;
    private string allergy;
    private string religion;
    private string mail;
    private string password;

    public Info(string prefix, string name,string surname, int age, string allergy, string religion,string mail, string password){
        this.prefix = prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
        this.mail= mail;
        this.password = password;
    }


    public string GetPrefix(){
        //Console.Write("Input Prefix :");
        return this.prefix;
    }

    public string GetName(){
        //Console.Write("Input your Name :");
        return this.name;
    }
    public string GetSurname(){
        return this.surname;
    }

    public int GetAge(){
        //Console.Write("Input age :");
        return this.age;
    }

    public string GetAllergy(){
        //Console.Write(" Input your allergy infomation :");
        return this.allergy;
    }

    public string GetReligion(){
        //Console.Write("Input you religion");
        return this.religion;
    }

    public string GetMail(){
        //Console.Write("Input you religion");
        return this.mail;
    }

    public string GetPassword(){
        //Console.Write("Input you religion");
        return this.password;
    }


    

}


