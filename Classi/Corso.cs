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
        private List<string> _materiali;

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
        public List<string> Materiali
        {
            get { return _materiali; }
            set { _materiali = value; }
        }

        // costruttore
        public Corso(string _nome)
        {
            Id = GeneraID();
            Nome = _nome;
            Materiali = new List<string>();
        }

        // metodi
        private string GeneraID()
        {
            return Guid.NewGuid().ToString("N").Substring(0,6);
        }
    }
}
