using System;
using System.Collections;
using System.Collections.Generic;

namespace GestionNotes
{
    public class EleveDAO : DAO,IDAO<Eleve>
    {
        public EleveDAO(string BD, string Pass, string User, string table, string server) :base(BD, Pass, User,table,  server)
        {
            

        }

        public int Delete(string conditions)
        {
           return  update("delete",conditions,null);
        }

        public int Insert(Eleve M)
        {
            return update("delete", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque)
        {
            return select(Reque);
        }

        public int Update(Eleve M,String conditions)
        {
            return update("delete", conditions, M.ConverObjectToDictionnary());
        }
    }
}
