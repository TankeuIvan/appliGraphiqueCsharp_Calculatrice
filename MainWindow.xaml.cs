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

        private void button0_Click(object sender, RoutedEventArgs e)
        {

        }
        private void buttonM1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonM2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button b2 = new Button();
            b2.Content = button2.Content;
            affichage.Text = (string)b2.Content;
            OperationEnCours((string)b2.Content);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button b3 = new Button();
            b3.Content = button3.Content;
            affichage.Text = (string)b3.Content;
            OperationEnCours((string)b3.Content);
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Button b4 = new Button();
            b4.Content = button4.Content;
            affichage.Text = (string)b4.Content;
            OperationEnCours((string)b4.Content);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Button b5 = new Button();
            b5.Content = button5.Content;
            affichage.Text = (string)b5.Content;
            OperationEnCours((string)b5.Content);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Button b6 = new Button();
            b6.Content = button6.Content;
            affichage.Text = (string)b6.Content;
            OperationEnCours((string)b6.Content);
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Button b7 = new Button();
            b7.Content = button7.Content;
            affichage.Text = (string)b7.Content;
            OperationEnCours((string)b7.Content);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Button b8 = new Button();
            b8.Content = button3.Content;
            affichage.Text = (string)b8.Content;
            OperationEnCours((string)b8.Content);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Button b9 = new Button();
            b9.Content = button9.Content;
            affichage.Text = (string)b9.Content;
            OperationEnCours((string)b9.Content);
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
            MessageBox.Show(expression);
            string[] charactere = expression.Split(';');

            double resultat = 0;

            for (int i=2; i<=charactere.Length; i = i + 2)
            {
                switch (charactere[i - 1])
                {
                    case "+":
                        resultat = Convert.ToDouble(charactere[i - 2]) + Convert.ToDouble(charactere[i]);
                        affichage.Text = Convert.ToString(resultat);
                       
                        break;

                    case "-":
                        resultat = Convert.ToDouble(charactere[i - 2]) - Convert.ToDouble(charactere[i]);
                        charactere[i] = Convert.ToString(resultat);
                        break;

                    case "/":
                        resultat = Convert.ToDouble(charactere[i - 2]) / Convert.ToDouble(charactere[i]);
                        charactere[i] = Convert.ToString(resultat);
                        break;

                    case "x":
                        resultat = Convert.ToDouble(charactere[i - 2]) * Convert.ToDouble(charactere[i]);
                        charactere[i] = Convert.ToString(resultat);
                        break;
                }
            }
            expression = "";
            i = 0;
            affichage.Text = Convert.ToString(resultat);
            //MessageBox.Show(Convert.ToString(resultat));
            
        }


        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            Button bPlus = new Button();
            bPlus.Content = buttonPlus.Content;
            OperationEnCours((string)bPlus.Content);

        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            Button bDiv = new Button();
            bDiv.Content = buttonDiv.Content;
            OperationEnCours((string)bDiv.Content);
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            Button bMul = new Button();
            bMul.Content = buttonMul.Content;
            OperationEnCours((string)bMul.Content);
        }

        private void buttonMoins_Click(object sender, RoutedEventArgs e)
        {
            Button bMoins = new Button();
            bMoins.Content = buttonMoins.Content;
            OperationEnCours((string)bMoins.Content);
        }
        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            /*Button bC = new Button();
            bC.Content = buttonC.Content;
            OperationEnCours((string)bPlus.Content);*/
        }
        private void buttonVirg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
