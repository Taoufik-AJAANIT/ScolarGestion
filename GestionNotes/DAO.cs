using System;
using System.Collections.Generic;

namespace GestionNotes
{



    public  class DAO : Mysql
    {

        public string[] param_co;
        private string table;

        public DAO(string BD, string Pass, string User, string table,string server) : base(BD, Pass, User,server)
        {
            this.table = table;
            param_co = new string[4];
            param_co[0] = server;
            param_co[1] = BD;
            param_co[2] = User;
            param_co[3] = Pass;


        }

        public List<Dictionary<string,string>> select(string sql)
        {
            return Get(sql);
        }

        public int update(string action,string conditions, Dictionary<string, string> Data)
        {
            switch (action)
            {
                    case "delete":
                        return delete(conditions);


                    case "update":
                       
                        return update(conditions,Data);


                    case "insert":

                        return insert(Data);

            }
            return 0;

        }

        public int update(string conditions, Dictionary<string, string> Data)
        {
            string sql = "update " + table + " set ";
            int size = 0;
            foreach (var value in Data.Keys)
            {
                string virgul = "";
                if (++size < Data.Keys.Count)
                    virgul = ",";
                sql += value + " = " + "'" + Data[value] + "'" + virgul;
            }


            sql += "where " + conditions;
            return Up(sql);
        }



        public int insert(Dictionary<string, string> Data)
        {
            string sql = "insert into  " + table;
            int size = 0;
            string values = "(";
            string data = "(";
            foreach (var value in Data.Keys)
            {
                string virgul = "";
                if (++size < Data.Keys.Count)
                    virgul = ",";
                else virgul = ")";
                values += value + virgul;
                data += "'" + Data[value] + "'" + virgul;
            }


            sql += values + "values " + data;
            return Up(sql);
        }



        public int delete(string conditions)
        {
            return Up("delete from " + table + " where " + conditions);
        }
    }
}
