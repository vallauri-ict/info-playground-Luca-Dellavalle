﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_14_OOP_1_persone_studenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void SetAttributs(string nome, string cognome, string sesso, int eta) {
            if (true) { 
            //controlli su i parametri 
            }
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this.eta = eta;
        }
        //un metodo solo una get compito
        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome() {
            return this.cognome;
        }

        public string GetSesso()
        {
            return this.sesso;
        }

        public int GetEta()
        {
            return this.eta;
        }
    }

}
