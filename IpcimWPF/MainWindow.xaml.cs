using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IpcimWPF
{
    public class Adatok
    {
        public string DomainName { get; set; }
        public string IpAddress { get; set; }
        public Adatok(string domainName, string ipAddress)
        {
            DomainName = domainName;
            IpAddress = ipAddress;
        }
    }
    public partial class MainWindow : Window
    {
        public List<Adatok> adatokLista = new List<Adatok>();
        public MainWindow()
        {
            InitializeComponent();
            //Betöltés csudh.txt fájlból
            var fajl = "C:\\Users\\Szalonna József\\source\\repos\\IpcimWPF\\IpcimWPF\\csudh.txt";
            var sorok = File.ReadAllLines(fajl, Encoding.UTF8);

            foreach (string s in sorok)
            {
                string[] darabok = s.Split(';');
                string domainName = darabok[0];
                string ipAddress = darabok[1];
                adatokLista.Add(new Adatok(domainName, ipAddress));
            }
            dataGrid.ItemsSource = adatokLista;
        }


        private void Bevitel(object sender, RoutedEventArgs e)
        { 
            
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {

        }
    }
}