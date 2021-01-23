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
using System.Windows.Shapes;

namespace KattintósWPF
{
    /// <summary>
    /// Interaction logic for InputDialogSample.xaml
    /// </summary>
    public partial class InputDialogSample : Window
    {
        public static string testFelhasznalonev;
        public InputDialogSample(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer.Text == "Ide írj...")
            {
                MessageBox.Show("Meg kell adnod egy játékosnevet!");
            }
            else
            {
                this.DialogResult = true;
                testFelhasznalonev = txtAnswer.Text;
            }
        }

        public string getFelhasznalonev()
        {
            testFelhasznalonev = txtAnswer.Text;
                return testFelhasznalonev;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }


    }
}
