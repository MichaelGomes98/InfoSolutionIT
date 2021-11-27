using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStore
{
    static class Session
    {
        public static int Id;
        public static string Nom;
        public static string Prenom;
        public static string Adresse;
        public static int CodePostal;
        public static string Email;
        public static string Password;
        public static int Connected;
        public static int Role;

        public static void genererSession(int id, string nom, string prenom, string adresse, int codePostal, string email, string password, int connected, int role) {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Email = email;
            Password = password;
            Connected = connected;
            Role = role;
        }



        public static void DestroySession()
        {
            Id = Convert.ToInt32(null);
            Nom = null;
            Prenom = null;
            Adresse = null;
            CodePostal = Convert.ToInt32(null);
            Email = null;
            Password = null;
            Connected = Convert.ToInt32(null);
            Role = Convert.ToInt32(null);
        }


    }
}