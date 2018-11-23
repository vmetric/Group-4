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
    /// 
    public class Record
    {
        //public string material { get; set; }
        //public double timeToIgnite { get; set; }
        //public double timeTo3CM { get; set; }
        //public double timeTo6CM { get; set; }
        //public double timeTo9CM { get; set; }
        //public double timeTo12CM { get; set; }
        //public double timeTo15CM { get; set; }
        //public double flameout { get; set; }
        //public double burnDuration { get; set; }
        public string material;
        public double timeToIgnite;
        public double timeTo3CM;
        public double timeTo6CM;
        public double timeTo9CM;
        public double timeTo12CM;
        public double timeTo15CM;
        public double flameout;
        public double burnDuration;

        public Record(string material, double timeToIgnite, double timeTo3CM, double timeTo6CM, double timeTo9CM, double timeTo12CM, double timeTo15CM, double flameout, double burnDuration)
        {
            this.material = material;
            this.timeToIgnite = timeToIgnite;
            this.timeTo3CM = timeTo3CM;
            this.timeTo6CM = timeTo6CM;
            this.timeTo9CM = timeTo9CM;
            this.timeTo12CM = timeTo12CM;
            this.timeTo15CM = timeTo15CM;
            this.flameout = flameout;
            this.burnDuration = burnDuration;
        }
    }
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
        List<Record> ledger = new List<Record> {
            new Record("Cotton", 1.50, 5.20, 6.76, 7.70, 8.75, 9.57, 15.04, 13.54),
            new Record("Wool", 16.84, 19.67, 21.12, 22.31, 23.56, 26.26, 33.63, 16.79),
            new Record("Spandex", 0.80, 5.37, 7.27, 9.17, 10.66, 11.67, 17.34, 16.54),
            new Record("Polyester", 1.50, 5.20, 6.76, 7.70, 8.75, 9.57, 15.04, 13.54),
            new Record("Nomex", 1.63, 6.29, 4.19, 9.67, 7.09, 8.75, 13.774, 60),
        };

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
