using System;
using System.Collections.Generic;

namespace GestionNotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           

            DAO test  = new DAO("student", "", "root", "Student","127.0.0.1");

            Dictionary<string,string> up  = new Dictionary<string,string>();
            Dictionary<string, string> inser = new Dictionary<string, string>();
            up.Add("firstname","taoufikkk");
            up.Add("lastname", "ajaa");
            up.Add("filiere", "ginf3");



            inser.Add("firstname", "hemza");
            inser.Add("lastname", "enaime");
            inser.Add("filiere", "cp2");
            RequestCondition rq = new RequestCondition();
            Object[] t = { 34 , 47 , 99};

            test.update("delete", "id " + rq.IN(t), up);
            test.update("update", "id " + rq.Equal(46), up);
            test.update("insert", "", inser);
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>(); 
            //result = test.Get("select * from Student");
        }

    }
}
