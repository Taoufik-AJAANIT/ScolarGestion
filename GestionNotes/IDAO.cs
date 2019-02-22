using System;
using System.Collections;
using System.Collections.Generic;

namespace GestionNotes
{
    public interface IDAO <t>
    {
            int Delete(string condition);
            int Insert(t M);
            List<Dictionary<string, string>> Select(string Reque);
            int Update(t M, String conditions);

    }
}
