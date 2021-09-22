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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string expression="";
        //string[] charactere = new string[100];
        private int i = 0;

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            Button bPlus = new Button();
            bPlus.Content = buttonPlus.Content;
            OperationEnCours((string)bPlus.Content);
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button b3 = new Button();
            b3.Content = button3.Content;
            affichage.Text = (string)b3.Content;
            OperationEnCours((string)b3.Content);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button b2 = new Button();
            b2.Content = button2.Content;
            affichage.Text = (string)b2.Content;
            OperationEnCours((string)b2.Content);
        }

        private void OperationEnCours(string s)
        {
            if (i == 0)
                expression = s;
            else
                expression = expression+";"+s;
            i++;
        }

        private void buttonEgal_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(expression);
            string[] charactere = expression.Split(';');

            double resultat = 0;

            for (int i=2; i<=charactere.Length; i = i + 2)
            {
                switch (charactere[i - 1])
                {
                    case "+":
                        resultat = Convert.ToDouble(charactere[i - 2]) + Convert.ToDouble(charactere[i]);
                        charactere[i] = Convert.ToString(resultat);
                        break;

                    case "-":
                        resultat = Convert.ToDouble(charactere[i - 2]) - Convert.ToDouble(charactere[i]);
                        charactere[i] = Convert.ToString(resultat);
                        break;

                }
            }
            expression = "";
            i = 0;
            affichage.Text = Convert.ToString(resultat);
            //MessageBox.Show(Convert.ToString(resultat));
            

            
            
            
        }

        private void buttonM1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonM2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMoins_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonVirg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
