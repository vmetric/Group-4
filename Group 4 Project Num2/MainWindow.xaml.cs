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
    /// When given material and percentage of that material and article of clothing, program will
    /// estimate the time until ignition and other various burn percents.
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
        int material1Percentage = -1;
        int material2Percentage = -1;
        double areaOfArticle = -1.0;
        double timeToIgnite = -1.0;

        private void ArticleDropDownClosed(object sender, EventArgs e)
        {
            articleOfClothing = articleComboBox.SelectionBoxItem.ToString();
        }
        private void MaterialDropDownClosed(object sender, EventArgs e)
        {
            if (materialComboBox.SelectionBoxItem.ToString() == "Mix")
            {
                changeVisibility(label_FirstMaterial, true);
                changeVisibility(label_SecondMaterial, true);
                changeVisibility(comboBox_FirstMaterial, true);
                changeVisibility(comboBox_SecondMaterial, true);
                changeVisibility(label_MaterialOnePercent, true);
                changeVisibility(textBox_MaterialOnePercent, true);
                changeVisibility(label_MaterialTwoPercent, true);
                changeVisibility(textBox_MaterialTwoPercent, true);
                Application.Current.MainWindow.Width = 800;
                Application.Current.MainWindow.Height = 250;
            }
            else if (materialComboBox.SelectionBoxItem.ToString() == null)
            {

            }
            else
            {
                changeVisibility(label_FirstMaterial, false);
                changeVisibility(label_SecondMaterial, false);
                changeVisibility(comboBox_FirstMaterial, false);
                changeVisibility(comboBox_SecondMaterial, false);
                changeVisibility(label_MaterialOnePercent, false);
                changeVisibility(textBox_MaterialOnePercent, false);
                changeVisibility(label_MaterialTwoPercent, false);
                changeVisibility(textBox_MaterialTwoPercent, false);
                material1 = materialComboBox.SelectionBoxItem.ToString();
                material1Percentage = 100;
                material2 = "";
                material2Percentage = 0;
            }
            
        }
        private void FirstMaterialDropdownClosed(object sender, EventArgs e)
        {
            if (comboBox_FirstMaterial.SelectionBoxItem.ToString() != null)
            {
                material1 = comboBox_FirstMaterial.SelectionBoxItem.ToString();
            }
        }
        private void SecondMaterialDropdownClosed(object sender, EventArgs e)
        {
            if (comboBox_SecondMaterial.SelectionBoxItem.ToString() != null)
            {
                material2 = comboBox_SecondMaterial.SelectionBoxItem.ToString();
            }
        }
    }
}
