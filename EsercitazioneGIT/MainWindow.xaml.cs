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

namespace EsercitazioneGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Cd> _listCD;
        private Autore autore;
        private Cd cd;
        
        public MainWindow()
        {

            InitializeComponent();
            txt_cd.Text = "NUMERO BRANI CD: 0" + '\n' + "DURATA CD: 0 secondi";


           

        }

        private void btn_aggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txt_nomeCanzone.Text;
            string nomeAutore = txt_nomeAutore.Text;
            double durata = double.Parse(txt_durataCanzone.Text);

            autore = new autore(titolo, nomeAutore, durata);

            lst_listaCanzoni.Items.Add(autore);
        }

        private void btn_creaCd_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txt_nomeCanzone.Text;
            string autore = txt_nomeAutore.Text;

            cd = new Cd(titolo, autore);
            if(lst_listaCanzoni.SelectedItem != null)
            {
                lst_CD.Items.Add(cd._listBrani);
            }
            

        }
    }

}