using System;

public class Addmin{
    private string email;
    private string password;

    public Addmin(string email, string password){
        this.email = email;
        this.password = password;
    }

    public string GetEmail(){

        return this.email;
    }

    public string GetPassword(){
        return this.password;
    }
}