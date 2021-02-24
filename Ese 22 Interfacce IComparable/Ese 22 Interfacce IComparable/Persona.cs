using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_22_Interfacce_IComparable
{
    class Persona : IComparable //permette l'ordinamento 
    {
        string nome;
        string cognome;
        string città;

        public Persona(string nome, string cognome, string città) {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Città = città;
        }

        public string Nome { get =>nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Città { get => città; set => città = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.Cognome, true);
        }  
    }
}
