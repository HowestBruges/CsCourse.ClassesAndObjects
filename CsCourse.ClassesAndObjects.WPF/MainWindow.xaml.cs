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
using CsCourse.ClassesAndObjectsLib;

namespace CsCourse.ClassesAndObjects.WPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Opvullen ComboBox
            foreach (string s in Enum.GetNames(typeof(Brand)))
            {
                cmbMerk.Items.Add(s);
            }

            // Opvullen Data
            for (int i=0; i<5; i++)
            {
                Car opstartWagen = new Car();
                lstAutos.Items.Add(opstartWagen);
                cmbWagen1.Items.Add(opstartWagen);
                cmbWagen2.Items.Add(opstartWagen);
            }

            // Netjes : Eerste item secteren 
            cmbMerk.SelectedIndex = 0;
            cmbWagen1.SelectedIndex = 0;
            cmbWagen2.SelectedIndex = 0;

            tbAantalObjecten.Text = Car.nrObjects.ToString();
        }

        private void btnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int snelheidMax = int.Parse(txtMaxSnelheid.Text);
                //Car nieuweWagen;            // Car Variabele declareren
                //nieuweWagen = new Car();    // Car variabele initialiseren
                //nieuweWagen.carBrand = (Brand)Enum.Parse(typeof(Brand), cmbMerk.SelectedItem.ToString());
                //nieuweWagen.maxSpeed = snelheidMax;
                
                Car nieuweWagen = new Car((Brand)Enum.Parse(typeof(Brand), cmbMerk.SelectedItem.ToString()), snelheidMax);

                lstAutos.Items.Add(nieuweWagen);
                cmbWagen1.Items.Add(nieuweWagen);
                cmbWagen2.Items.Add(nieuweWagen);
                
                tbAantalObjecten.Text = Car.nrObjects.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kan niet invoegen, foutieve ingave \nReden :\t" + ex.Message, "Foutmelding");
            }
        }

        private void lstAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                Car geselecteerdeWagen = (Car)lstAutos.SelectedItem;
                tbMerk.Text = geselecteerdeWagen.carBrand.ToString();
                tbMaxSnelheid.Text = geselecteerdeWagen.maxSpeed.ToString();
                tbActSnelheid.Text = geselecteerdeWagen.actSpeed.ToString();
            }
        }

        private void btnVersnel_Click(object sender, RoutedEventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                Car geselecteerdeWagen = (Car)lstAutos.SelectedItem;
                geselecteerdeWagen.IncreaseSpeed(5);
                tbActSnelheid.Text = geselecteerdeWagen.actSpeed.ToString();
            }
        }

        private void btnVertraag_Click(object sender, RoutedEventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                Car geselecteerdeWagen = (Car)lstAutos.SelectedItem;
                geselecteerdeWagen.DecreaseSpeed(5);
                tbActSnelheid.Text = geselecteerdeWagen.actSpeed.ToString();
            }
        }

        private void cmbWagen1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VergelijkSnelheid();
        }

        private void cmbWagen2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VergelijkSnelheid();
        }

        private void VergelijkSnelheid()
        {
            if ((cmbWagen1.SelectedItem != null) && (cmbWagen2.SelectedItem != null))
            {
               tbDeltaSnelheid.Text = Car.CompareSpeed((Car)cmbWagen1.SelectedItem, (Car)cmbWagen2.SelectedItem).ToString();
            }

        }

    }
}
