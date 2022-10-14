using System.Collections.Generic;
using System;

class InfomationList{
    private List<Info> infomationList;

    public InfomationList(){
        this.infomationList = new List<Info>();
    }

    public void AddNewInfo(Info info){
        this.infomationList.Add(info);
    }

    public void FetchInfoList(){
        Console.WriteLine("List Person");
        Console.WriteLine("**********");

        foreach(Info info in this.infomationList){
            if(info is CurrentUniStudent){
                Console.WriteLine("Name {0} \n Type: Present Student \n", info.GetName());
            } else if (info is Student){
                Console.WriteLine("Name {0}/n Type: Student \n",info.GetName());
            } else if (info is Teacher){
                Console.WriteLine("Name {0} \n Type: Teacher \n",info.GetName());
            }else if (info is Addmin){
                Console.WriteLine("Name {0} \n Type: Admin \n",info.GetName());
            }
        }
    }

}
