using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_07_Classe_indexata
{
    class MyIndexClasse
    {
        private string[] element;
        //costruttore
        public MyIndexClasse(int elementNumber) //numero di stringhe che vengano generate nella classe
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        //iteratore
        public string this[int pos] 
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int length() {
            return element.Length;
        }
    }
}
