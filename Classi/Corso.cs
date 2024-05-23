using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Classi
{
    public class Corso
    {
        // attributi
        private string _id;
        private string _nome;
        private string _proprietario;
        private List<string> _materiali;
        private List<string> _partecipanti;

        // metodi accessor
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Proprietario
        {
            get { return _proprietario; }
            set { _proprietario = value; }
        }
        public List<string> Materiali
        {
            get { return _materiali; }
            set { _materiali = value; }
        }
        public List<string> Partecipanti
        {
            get { return _partecipanti; }
            set { _partecipanti = value; }
        }

        // costruttore
        public Corso(string _nome, string _proprietario)
        {
            Id = GeneraID();
            Nome = _nome;
            Proprietario = _proprietario;
            Materiali = new List<string>();
            Partecipanti = new List<string>();
        }

        // metodi
        private string GeneraID()
        {
            return Guid.NewGuid().ToString("N").Substring(0,6);
        }
    }
}
