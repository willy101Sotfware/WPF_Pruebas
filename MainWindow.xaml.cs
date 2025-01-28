using System.Windows;

namespace WPF_Pruebas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Ajustar tamaño para relación 16:9
            this.Height = SystemParameters.PrimaryScreenHeight;
            this.Width = this.Height * 9 / 16;
            this.WindowVB.Height = SystemParameters.PrimaryScreenHeight;
            this.WindowVB.Width = this.Height * 9 / 16;



        }
    }
}