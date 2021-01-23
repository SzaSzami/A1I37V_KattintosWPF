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
using System.Windows.Threading;

namespace KattintósWPF
{

    
    public partial class MainWindow : Window
    {
        public static string felhasznalo;

        public MainWindow()
        {
            InitializeComponent();
            lblBejelentkezveMint.Content = InputDialogSample.testFelhasznalonev;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Start startjatek = new Start();
            startjatek.Show();
            this.Close();
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Jatekosnev_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample("Kérlek add meg a neved!","Ide írj...");
            if (inputDialog.ShowDialog() == true)
            {
                felhasznalo = inputDialog.Answer;
                lblBejelentkezveMint.Content = InputDialogSample.testFelhasznalonev;
            }
                
            
        }
    }
}
