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

            // Netjes : Eerste item secteren 
            cmbMerk.SelectedIndex = 0;
        }

        private void btnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int snelheidMax = int.Parse(txtMaxSnelheid.Text);
                Car nieuweWagen;            // Car Variabele declareren
                nieuweWagen = new Car();    // Car variabele initialiseren
                nieuweWagen.carBrand = (Brand)Enum.Parse(typeof(Brand), cmbMerk.SelectedItem.ToString());
                nieuweWagen.maxSpeed = snelheidMax;
                lstAutos.Items.Add(nieuweWagen);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kan niet invoegen, foutieve ingave \nReden :\t" + ex.Message, "Foutmelding");
            }
        }
    }
}
