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

namespace Jaddad_Zizi_Hamdaoui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1;
        double num2;
        char op;
        public MainWindow()
        {
            InitializeComponent();
        }


        // l'affichage de  1 et l'attribué dans l'operation de calcul
        private void numUn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "1";
        }


        // l'affichage de  2 et l'attribué dans l'operation de calcul
        private void numDeux_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "2";
        }


        // l'affichage de  3 et l'attribué dans l'operation de calcul
        private void numTrois_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "3";
        }


        // l'affichage de  4 et l'attribué dans l'operation de calcul
        private void numQuatre_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "4";
        }


        // l'affichage de  5 et l'attribué dans l'operation de calcul
        private void numCinq_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "5";
        }


        // l'affichage de  6 et l'attribué dans l'operation de calcul
        private void numSix_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "6";
        }


        // l'affichage de  7 et l'attribué dans l'operation de calcul
        private void numSept_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "7";
        }


        // l'affichage de  8 et l'attribué dans l'operation de calcul
        private void numHuit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "8";
        }


        // l'affichage de  9 et l'attribué dans l'operation de calcul
        private void numNeuf_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "9";
        }




        // l'affichage de  0 et l'attribué dans l'operation de calcul
        private void numZero_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            affichage.Text += btn.Content.ToString();
            num2 = double.Parse(affichage.Text);
            saisie.Text = saisie.Text + "0";
        }

        // l'affichage de la virgule "." et l'attribué dans l'operation de calcul
        private void virgule_Click(object sender, RoutedEventArgs e)
        {
            saisie.Text = saisie.Text + ".";
        }

        // la fonction addition
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(affichage.Text);
            op = '+';
            affichage.Clear();
            saisie.Text = saisie.Text + "+";
            
        }

        // la fonctiob supstraction 
        private void moins_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(affichage.Text);
            op = '-';
            affichage.Clear();
            saisie.Text = saisie.Text + "-";
        }

        // la fonction multiplication
        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(affichage.Text);
            op = '*';
            affichage.Clear();
            saisie.Text = saisie.Text + "*";
        }

        // la fonction division
        private void division_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(affichage.Text);
            op = '/';
            affichage.Clear();
            saisie.Text = saisie.Text + "/";
        }

        private void efface_Click(object sender, RoutedEventArgs e)
        {
            saisie.Clear();
            affichage.Clear();
           // affichage.Text = "0" ;
        }

        //la fonction modulo
        private void modulo_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(affichage.Text);
            op = '%';
            affichage.Clear();
            saisie.Text = saisie.Text + "%";
        }


        //la fonction factoriel 
        private void factoriel_Click(object sender, RoutedEventArgs e)
        {
            int numfact = Int32.Parse(affichage.Text);
            for (int i = numfact - 1; i > 0; i--)
            {
                numfact = numfact * i;
            }
            affichage.Text = "fact(" + numfact + ")";
            affichage.Text = numfact.ToString();

        }


        //la fonction qui affiche l'inverse du nombre saisie 
        private void inverse_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(affichage.Text);
            double numinver = 1 / num;
            saisie.Text = "1/(" + num.ToString() + ") ";
            affichage.Text = numinver.ToString();

        }





        // l affichage des resultat 
        private void egal_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(affichage.Text);
            double resultat = 0;
            saisie.Text = saisie.Text + "=";

            if (op == '+')
            {
                resultat = num1 + num2;
            }
            if (op == '-')
            {
                resultat = num1 - num2;
            }
            if (op == '*')
            {
                resultat = num1 * num2;
            }
            if (op == '/')
            {
                resultat = num1 / num2;
            }
            if (op == '%')
            {
                resultat = num1 % num2;
            }
            affichage.Text = resultat.ToString();
        }





    }
}
