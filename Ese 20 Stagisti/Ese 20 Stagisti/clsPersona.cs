using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_20_Stagisti
{
    abstract class clsPersona
    {
        #region attributi
        protected string nome;
        protected string cognome;
        protected string città;
        #endregion

        public string Città
        {
            get => città;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    città = value;
                }
                else
                {
                    throw new Exception("città non valida");
                }
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("cognome non valido");
                }
            }
        }


        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("nome non valido");
                }
            }
        }

        protected clsPersona(string nome, string cognome, string città)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.città = città;
        }

        public abstract string visualizza();
    }
}
