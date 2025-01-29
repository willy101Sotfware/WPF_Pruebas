using System;
using System.Windows;
using System.Windows.Input;
using WPF_Pruebas.Presentation.Shared.Components;

namespace WPF_Pruebas
{
    /// <summary>
    /// Lógica de interacción para Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
          

        }

        private void Continuar_Touch(object sender, MouseButtonEventArgs e)
        {
            // Abrir FormUser en lugar de MainWindow
            FormUser formUser = new FormUser();
            formUser.Show();

            this.Close();
        }
    }
}
