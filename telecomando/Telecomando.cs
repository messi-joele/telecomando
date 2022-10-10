using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomando
{
    internal class Telecomando
    {
        private string produttore;
        private string modello;
        private string funzionamento;
        private int canale;
        public Telecomando(string Ilproduttore, string Ilmodello, string Ilfunzionamento) 
        {
            produttore = Ilproduttore;
            modello = Ilmodello;
            funzionamento = Ilfunzionamento;                        
        }

        

        
        public void setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
        }
        public int getcanale()
        {
            return canale;
        }

        public string getproduttore()
        {
            return produttore;      
                }
        public string getmodello()
        {
            return modello;
        }
        public string getfunzionamento()
        {
            return funzionamento;
        }
    }
    
}
