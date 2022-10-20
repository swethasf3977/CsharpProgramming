using System;
namespace CafeteriaApplication
{
    public class Cafeteria
    {   
        private static int s_userId=100;
        public string UserId { get;}
        public string Name{ get; set; }
        public double Mob { get; set; }
        public int Workno{ get; set; }
        public int  Balance { get; set; }

   

    public Cafeteria(string name,double mobile,int workno,int balance)

    {   s_userId++;
        UserId ="SF"+s_userId;

        Name  = name;
        Mob = mobile;
        Workno = workno;
    
    }
    }
}