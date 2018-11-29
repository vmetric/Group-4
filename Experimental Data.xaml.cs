using System;
using System.Windows;

namespace Group_4_Project_Num2
{
    /// <summary>
    /// Interaction logic for Experimental_Data.xaml
    /// </summary>
    public partial class Experimental_Data : Window
    {
        public Experimental_Data()
        {
            InitializeComponent();
        }

        private void comboBox_Fabric_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Fabric.SelectionBoxItem.ToString() != "")
            {
                this.Height = 225;
                string fabric = comboBox_Fabric.SelectionBoxItem.ToString();
                if (fabric == "Wool")
                {
                    textBlock_Display.Text = $"Averaged experimental data for wool is as follows--\n" +
                        $"Time to fabric ignition: {MainWindow.ledger[0].timeToIgnite} seconds\n" +
                        $"Time to 20% burnt: {MainWindow.ledger[0].timeTo3CM} seconds\n" +
                        $"Time to 40% burnt: {MainWindow.ledger[0].timeTo6CM} seconds\n" +
                        $"Time to 80% burnt: {MainWindow.ledger[0].timeTo12CM} seconds\n" +
                        $"Time to 100% burnt: {MainWindow.ledger[0].timeTo15CM} seconds\n" +
                        $"Time until no flames visible: {MainWindow.ledger[0].flameout} seconds\n";
                }
                else if (fabric == "Cotton")
                {
                    textBlock_Display.Text = $"Averaged experimental data for cotton is as follows--\n" +
                    $"Time to fabric ignition: {MainWindow.ledger[1].timeToIgnite} seconds\n" +
                    $"Time to 20% burnt: {MainWindow.ledger[1].timeTo3CM} seconds\n" +
                    $"Time to 40% burnt: {MainWindow.ledger[1].timeTo6CM} seconds\n" +
                    $"Time to 80% burnt: {MainWindow.ledger[1].timeTo12CM} seconds\n" +
                    $"Time to 100% burnt: {MainWindow.ledger[1].timeTo15CM} seconds\n" +
                    $"Time until no flames visible: {MainWindow.ledger[1].flameout} seconds\n";
                }
                else if (fabric == "Spandex")
                {
                    textBlock_Display.Text = $"Averaged experimental data for spandex is as follows--\n" +
                    $"Time to fabric ignition: {MainWindow.ledger[2].timeToIgnite} seconds\n" +
                    $"Time to 20% burnt: {MainWindow.ledger[2].timeTo3CM} seconds\n" +
                    $"Time to 40% burnt: {MainWindow.ledger[2].timeTo6CM} seconds\n" +
                    $"Time to 80% burnt: {MainWindow.ledger[2].timeTo12CM} seconds\n" +
                    $"Time to 100% burnt: {MainWindow.ledger[2].timeTo15CM} seconds\n" +
                    $"Time until no flames visible: {MainWindow.ledger[2].flameout} seconds\n";
                }
                else if (fabric == "Polyester")
                {
                    textBlock_Display.Text = $"Averaged experimental data for wool is as follows--\n" +
                    $"Time to fabric ignition: {MainWindow.ledger[3].timeToIgnite} seconds\n" +
                    $"Time to 20% burnt: {MainWindow.ledger[3].timeTo3CM} seconds\n" +
                    $"Time to 40% burnt: {MainWindow.ledger[3].timeTo6CM} seconds\n" +
                    $"Time to 80% burnt: {MainWindow.ledger[3].timeTo12CM} seconds\n" +
                    $"Time to 100% burnt: {MainWindow.ledger[3].timeTo15CM} seconds\n" +
                    $"Time until no flames visible: {MainWindow.ledger[3].flameout} seconds\n";
                }
                else if (fabric == "Nomex")
                {
                    textBlock_Display.Text = $"Averaged experimental data for wool is as follows--\n" +
                    $"Time to fabric ignition: {MainWindow.ledger[4].timeToIgnite} seconds\n" +
                    $"Time to 20% burnt: {MainWindow.ledger[4].timeTo3CM} seconds\n" +
                    $"Time to 40% burnt: {MainWindow.ledger[4].timeTo6CM} seconds\n" +
                    $"Time to 80% burnt: {MainWindow.ledger[4].timeTo12CM} seconds\n" +
                    $"Time to 100% burnt: {MainWindow.ledger[4].timeTo15CM} seconds\n" +
                    $"Time until no flames visible: {MainWindow.ledger[4].flameout} seconds\n";
                }
            }
            else if (comboBox_Fabric.SelectionBoxItem.ToString() == "")
            {

                this.Height = 75;
            }
        }
    }
}
