using System;
using System.Collections.Generic;

namespace GestionNotes
{
    public class Eleve
    {
        private string Code_fil ;
        private string codeElev;
        private string niveau;
        private string nom;
        private string prenom;

        public Eleve(string nom,string prenom,string niveau,string codeElev,string Code_fil)
        {
            this.nom = nom;
            this.prenom = prenom ;
            this.niveau = niveau;
            this.codeElev = codeElev;
            this.Code_fil = Code_fil;

        }

        public Dictionary<string,string> ConverObjectToDictionnary()
        {
            Dictionary<string ,string> eleve = new Dictionary<string, string>() ;

            eleve.Add("nom", nom);
            eleve.Add("prenom" ,prenom);
            eleve.Add("codeElev" , codeElev);
            eleve.Add("Code_fil", Code_fil);
            eleve.Add("niveau", niveau);

            return eleve;

        }


    }
}
