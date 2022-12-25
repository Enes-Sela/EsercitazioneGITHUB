using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGITHUB
{
    class Libro
    {
        internal string Autore { get; set; }
        internal string Titolo { get; set; }
        internal string Editore { get; set; }
        internal int AnnoPubblicazione { get; set; }
        internal int NumeroPagine { get; set; }

        internal Libro(string autore,string titolo,string editore,int annoPubblicazione,int numeroPagine) 
        {
            this.Autore = autore;
            this.Titolo = titolo;
            this.Editore = editore;
            this.AnnoPubblicazione = annoPubblicazione;
            this.NumeroPagine = numeroPagine;
        }

        public string ToString(string autore, string titolo, string editore, int annoPubblicazione, int numeroPagine) 
        {
            return "Il libro è stato scritto da : " + autore + "\n" + "Il titolo del libro è : " + titolo + "\n" + "L'editore è : " + editore + "\n" + "Il libro è stato pubblicato nel : " + annoPubblicazione + "\n" + "Il libro ha : " + numeroPagine + "pagine";
        }

        public int readingTime(int numeroPagine) 
        {
            int tempo = 0;

            if (numeroPagine < 100)
            {
                tempo = 60;

            }
            else if(numeroPagine > 100 && numeroPagine < 200) 
            {
                tempo = 120;
            }
            else if (numeroPagine > 200)
            {
                tempo = 180;
            }
            return tempo;
        }
    }
}
