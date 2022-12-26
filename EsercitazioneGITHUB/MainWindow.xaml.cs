using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercitazioneGITHUB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Libro> elencoLibri = new List<Libro>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aggiungi_Libro(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro();

            txtAutore.Text = libro.Autore;
            txtTitolo.Text = libro.Titolo;
            txtEditore.Text = libro.Editore;
            txtAnnoPubblicazione.Text = Convert.ToString(libro.AnnoPubblicazione);
            txtNumeroPagine.Text = Convert.ToString(libro.NumeroPagine);

            elencoLibri.Add(libro);
        }

        private void Aggiunta_Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();

            txtNomeBiblioteca.Text = biblioteca.NomeBiblioteca;
            txtIndirizzo.Text = biblioteca.Indirizzo;
            txtOrarioApertura.Text = Convert.ToString(biblioteca.OrarioApertura);
            txtOrarioChiusura.Text = Convert.ToString(biblioteca.OrarioChiusura);
        }

        private void Ricerca_Titolo_Click(object sender, RoutedEventArgs e)
        {
            Libro ricercaLibro = new Libro();

            txtRicercaTitolo.Text = ricercaLibro.Titolo;
        }

        private void Ricerca_Autore_Click(object sender, RoutedEventArgs e)
        {
            Libro ricercaAutore = new Libro();

            txtRicercaAutore.Text = ricercaAutore.Autore;

            txtNumeroLibri.Text = Convert.ToString(elencoLibri.Count()); 
        }

       
    }
}
