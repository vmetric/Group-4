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

namespace Group_4_Project_Num2
{
    /// <summary>
    /// Interaction logic for Predictions.xaml
    /// </summary>
    public partial class Predictions : Window
    {
        public Predictions()
        {
            InitializeComponent();
            
            label_Display.Content = $"Your chosen cloth will ignite in {MainWindow.userCloth.ignitionTime} seconds\n" +
                $"It will be 25% burnt in {MainWindow.userCloth.oneFourthBurnt} seconds\n" +
                $"It will be 50% burnt in {MainWindow.userCloth.halfBurnt} seconds\n" +
                $"It will be 75% burnt in {MainWindow.userCloth.threeFourthsBurnt} seconds\n" +
                $"It will be completely burnt in {MainWindow.userCloth.completelyBurnt} seconds";
        }

        private void button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
