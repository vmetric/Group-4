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

namespace Group_4_Project_Num2
{
    /// <summary>
    /// A program created to help inform users of the flammability of their clothing.
    /// When given 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void changeVisibility(Control control, bool visible)
        {
            if (visible)
            {
                control.Visibility = Visibility.Visible;
            } else
            {
                control.Visibility = Visibility.Hidden;
            }
        }

        string articleOfClothing = "";
        string material1 = "";
        string material2 = "";
        int material1Percentage = 0;
        int material2Percentage = 0;
        double areaOfArticle = 0.0;
        double timeToIgnite = 0.0;

        private void ArticleDropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(articleComboBox.SelectionBoxItem.ToString());

        }

        private void MaterialDropDownClosed(object sender, EventArgs e)
        {
            if (materialComboBox.SelectionBoxItem.ToString() == "Mix")
            {
                changeVisibility(label_FirstMaterial, true);
                changeVisibility(label_SecondMaterial, true);
                changeVisibility(comboBox_FirstMaterial, true);
                changeVisibility(comboBox_SecondMaterial, true);
                changeVisibility(label_MaterialTwoPercent, true);
                changeVisibility(textBox_MaterialTwoPercent, true);
                Application.Current.MainWindow.Width = 800;
                Application.Current.MainWindow.Height = 250;
            }
            else
            {
                changeVisibility(label_FirstMaterial, false);
                changeVisibility(label_SecondMaterial, false);
                changeVisibility(comboBox_FirstMaterial, false);
                changeVisibility(comboBox_SecondMaterial, false);
                changeVisibility(label_MaterialTwoPercent, false);
                changeVisibility(textBox_MaterialTwoPercent, false);
            }
        }
    }
}
