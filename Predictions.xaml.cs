using System.Windows;


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
