using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGITHUB
{
    class Biblioteca
    {
        List<Libro> elencoLibro = new List<Libro>();

        internal string NomeBiblioteca { get; set; }
        internal string Indirizzo { get; set; }
        internal int OrarioApertura { get; set; }
        internal int OrarioChiusura { get; set; }

        internal Biblioteca(string nomeBiblioteca,string indirizzo,int orarioApertura,int orarioChiusura) 
        {
            this.NomeBiblioteca = nomeBiblioteca;
            this.Indirizzo = indirizzo;
            this.OrarioApertura = orarioApertura;
            this.OrarioChiusura = orarioChiusura;
        }

        public void OperazioniLibro(Libro Autore,Libro Titolo,Libro Editore,Libro AnnoPubblicazione,Libro NumeroPagine) 
        {
            elencoLibro.Add(Autore);
            elencoLibro.Add(Titolo);
            elencoLibro.Add(Editore);
            elencoLibro.Add(AnnoPubblicazione);
            elencoLibro.Add(NumeroPagine);

            for (int i = 0; i < elencoLibro.Count; i++)
            {
                if (elencoLibro.Contains(Titolo))
                {
                    Titolo = (Libro)elencoLibro[i];
                }
            }

            for (int i = 0; i < elencoLibro.Count; i++)
            {
                if (elencoLibro.Contains(Autore))
                {
                    Autore = (Libro)elencoLibro[i];
                }
            }

            for (int i = 0; i < elencoLibro.Count; i++)
            {
                int numeroPagine = 0;
                numeroPagine = elencoLibro.Count;
            }
        }
    }
}
