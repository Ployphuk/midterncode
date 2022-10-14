using System;
using System.Collections.Generic;

class LoginTool{
    private Info[] info;

    public LoginTool(Info[] info){
        this.info= info;
    }

    public Info GetInfo(string mail){
        foreach(Info info in info){
            if(info.GetMail().Equals(mail)){
                return info;
            }
        }
        return null;
    }




}