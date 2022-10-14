using System.Collections.Generic;
using System;

class AdminList{
    private List<Addmin> adminList;

     public void AddNewAdmin(Addmin addmin){
        this.adminList.Add(addmin);  
    }

    public void FetchAdminList(){
        Console.WriteLine("List Admin");
        Console.WriteLine("**********");

        foreach(Addmin addmin in this.adminList){
            Console.WriteLine("Name {0} \n Type: Present Student \n", addmin.GetEmail());
        }
    }
}