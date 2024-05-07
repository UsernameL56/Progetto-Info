using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Account
    {
        // attributi
        private string _nome;
        private string _cognome;
        private string _email;
        private string _password;
        private string _ruolo;

        // metodi accessor
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Ruolo
        {
            get { return _ruolo; }
            set { _ruolo = value; }
        }

        // costruttori
        public Account(){
            Nome = "";
            Cognome = "";
            Email = "";
            Password = "";
        }
        public Account(string _nome, string _cognome, string _email, string _password, string _ruolo)
        {
            Nome = _nome;
            Cognome = _cognome;
            Email = _email;
            Password = _password;
            Ruolo = _ruolo;
        }
    }
}
