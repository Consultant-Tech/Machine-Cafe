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
using Modeles.Modele;
using Service;

namespace MachineCafes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MachineUserControl
    {
        private readonly CafeService _cafeService = new CafeService();
        private readonly PersonneService _personnelService = new PersonneService();
        private string _niveauintensite = "";
        public MachineUserControl()
        {
            InitializeComponent();
        }

        private void the_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.RoyalBlue;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void expresso_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.RoyalBlue;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void cappuccino_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.RoyalBlue;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void cafelait_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.RoyalBlue;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void CafeMacchiato_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.RoyalBlue;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void chocolatchaud_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.RoyalBlue;
            cafemoka.Background = Brushes.FloralWhite;
        }

        private void cafemoka_Click(object sender, RoutedEventArgs e)
        {
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.RoyalBlue;
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            int laitvalue2 = int.Parse(laitvalue.Text);
            laitvalue2--;
            if (laitvalue2 == 0)
            {
                min.IsEnabled = false;
            }
            else
            {
                min.IsEnabled = true;
                plus1.IsEnabled = true;
            }
            laitvalue.Text = laitvalue2.ToString();
        }
        private void plus1_Click(object sender, RoutedEventArgs e)
        {
            int laitvalue2 = int.Parse(laitvalue.Text);
            laitvalue2++;
            if (laitvalue2 == 5)
            {
                plus1.IsEnabled = false;
            }
            else
            {
                plus1.IsEnabled = true;
                min.IsEnabled = true;
            }
            laitvalue.Text = laitvalue2.ToString();
        }

        private void plus2_Click(object sender, RoutedEventArgs e)
        {
            int sucrevalue2 = int.Parse(sucrevalue.Text);
            sucrevalue2++;
            if (sucrevalue2 == 5)
            {
                plus2.IsEnabled = false;
            }
            else
            {
                plus2.IsEnabled = true;
                min1.IsEnabled = true;
            }
            sucrevalue.Text = sucrevalue2.ToString();
        }

        private void min1_Click(object sender, RoutedEventArgs e)
        {
            int sucrevalue2 = int.Parse(sucrevalue.Text);
            sucrevalue2--;
            if (sucrevalue2 == 0)
            {
                min1.IsEnabled = false;
            }
            else
            {
                min1.IsEnabled = true;
                plus2.IsEnabled = true;
            }
            sucrevalue.Text = sucrevalue2.ToString();
        }

        private void minusminus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.RoyalBlue;
            minus.Background = Brushes.FloralWhite;
            middle.Background = Brushes.FloralWhite;
            plus.Background = Brushes.FloralWhite;
            plusplus.Background = Brushes.FloralWhite;
            _niveauintensite = "minusminus";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.FloralWhite;
            minus.Background = Brushes.RoyalBlue;
            middle.Background = Brushes.FloralWhite;
            plus.Background = Brushes.FloralWhite;
            plusplus.Background = Brushes.FloralWhite;
            _niveauintensite = "minus";
        }

        private void middle_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.FloralWhite;
            minus.Background = Brushes.FloralWhite;
            middle.Background = Brushes.RoyalBlue;
            plus.Background = Brushes.FloralWhite;
            plusplus.Background = Brushes.FloralWhite;
            _niveauintensite = "middle";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.FloralWhite;
            minus.Background = Brushes.FloralWhite;
            middle.Background = Brushes.FloralWhite;
            plus.Background = Brushes.RoyalBlue;
            plusplus.Background = Brushes.FloralWhite;
            _niveauintensite = "plus";
        }

        private void plusplus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.FloralWhite;
            minus.Background = Brushes.FloralWhite;
            middle.Background = Brushes.FloralWhite;
            plus.Background = Brushes.FloralWhite;
            plusplus.Background = Brushes.RoyalBlue;
            _niveauintensite = "plusplus";
        }

        private void mug_Click(object sender, RoutedEventArgs e)
        {
            mug.Background = Brushes.RoyalBlue;
        }
        private void order_Click(object sender, RoutedEventArgs e)
        {
            string typecafe = "";
            if (minusminus.Background == Brushes.RoyalBlue)
            {
                typecafe = MessageAffichage(typecafe);
            }
            else if (minus.Background == Brushes.RoyalBlue)
            {
                typecafe = MessageAffichage(typecafe);
            }
            else if (middle.Background == Brushes.RoyalBlue)
            {
                typecafe = MessageAffichage(typecafe);
            }
            else if (plus.Background == Brushes.RoyalBlue)
            {
                typecafe = MessageAffichage(typecafe);
            }
            else if (plusplus.Background == Brushes.RoyalBlue)
            {
                typecafe = MessageAffichage(typecafe);
            }
            else
            {
                MessageBox.Show("Merci de sélectionner l'intensité du café.");
            }
            if(typecafe != "")
            {
                // Verifier si personnel n'existe pas ajouter 
                Personnel personnel = _personnelService.RecupererPersonnel(matricule.Text);
                if (personnel == null)
                {
                    _personnelService.AjouterPersonnel(matricule.Text, nom.Text, prenom.Text);
                }
                //ajouter Ordre
                if (mug.Background == Brushes.RoyalBlue)
                {
                    _cafeService.AjouterOrdre(typecafe, _niveauintensite, int.Parse(laitvalue.Text), int.Parse(sucrevalue.Text), 1, matricule.Text);
                }
                else
                {
                    _cafeService.AjouterOrdre(typecafe, _niveauintensite, int.Parse(laitvalue.Text), int.Parse(sucrevalue.Text), 0, matricule.Text);
                }

                Clear();
                matricule.Text = "";
                nom.Text = "";
                prenom.Text = "";
            }
        }

        private void Clear()
        {
            mug.Background = Brushes.FloralWhite;
            minusminus.Background = Brushes.FloralWhite;
            minus.Background = Brushes.FloralWhite;
            middle.Background = Brushes.FloralWhite;
            plus.Background = Brushes.FloralWhite;
            plusplus.Background = Brushes.FloralWhite;
            the.Background = Brushes.FloralWhite;
            expresso.Background = Brushes.FloralWhite;
            cappuccino.Background = Brushes.FloralWhite;
            cafelait.Background = Brushes.FloralWhite;
            CafeMacchiato.Background = Brushes.FloralWhite;
            chocolatchaud.Background = Brushes.FloralWhite;
            cafemoka.Background = Brushes.FloralWhite;
            laitvalue.Text = "0";
            sucrevalue.Text = "0";
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {

            Clear();
            Ordre ordre = _cafeService.RecupererOrdre(matricule.Text);
            if (ordre.Type == "thé")
            {
                the_Click(sender, e);
            }
            if (ordre.Type == "Expresso")
            {
                expresso_Click(sender, e);
            }
            if (ordre.Type == "Cappuccino")
            {
                cappuccino_Click(sender, e);
            }
            if (ordre.Type == "Café au lait")
            {
                cafelait_Click(sender, e);
            }
            if (ordre.Type == "Café Macchiato")
            {
                CafeMacchiato_Click(sender, e);
            }
            if (ordre.Type == "Chocolat Chaud")
            {
                chocolatchaud_Click(sender, e);
            }
            if (ordre.Type == "Café Moka")
            {
                cafemoka_Click(sender, e);
            }
            if (ordre.Intensite == "minusminus")
            {
                minusminus_Click(sender, e);
            }
            if (ordre.Intensite == "minus")
            {
                minus_Click(sender, e);
            }
            if (ordre.Intensite == "middle")
            {
                middle_Click(sender, e);
            }
            if (ordre.Intensite == "plus")
            {
                plus_Click(sender, e);
            }
            if (ordre.Intensite == "plusplus")
            {
                plusplus_Click(sender, e);
            }
            laitvalue.Text = ordre.Lait.ToString();
            sucrevalue.Text = ordre.Sucre.ToString();
            if(ordre.Mug == 1)
            {
                mug_Click(sender, e);
            }
        }

        private string MessageAffichage(string typecafe)
        {
            if (the.Background == Brushes.RoyalBlue)
            {
                typecafe = "thé";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (expresso.Background == Brushes.RoyalBlue)
            {
                typecafe = "Expresso";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (cappuccino.Background == Brushes.RoyalBlue)
            {
                typecafe = "Cappuccino";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (cafelait.Background == Brushes.RoyalBlue)
            {
                typecafe = "Café au lait";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (CafeMacchiato.Background == Brushes.RoyalBlue)
            {
                typecafe = "Café Macchiato";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (chocolatchaud.Background == Brushes.RoyalBlue)
            {
                typecafe = "Chocolat Chaud";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else if (cafemoka.Background == Brushes.RoyalBlue)
            {
                typecafe = "Café Moka";
                MessageBox.Show("Profitez de votre belle tasse " + typecafe + " avec " + sucrevalue.Text + " quantités de sucre et " + laitvalue.Text + " quantités de lait!");
            }
            else
            {
                MessageBox.Show("Merci de sélectionner le choix!");
            }

            return typecafe;
        }

        private void matricule_Onchange(object sender, RoutedEventArgs e)
        {

            Personnel personnel = _personnelService.RecupererPersonnel(matricule.Text);
            if(personnel != null)
            {
                nom.Text = personnel.Nom;
                prenom.Text = personnel.Prenom;
            }
        }
    }
}
