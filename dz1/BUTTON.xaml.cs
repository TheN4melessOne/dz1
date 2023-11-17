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

namespace dz1
{
    /// <summary>
    /// Логика взаимодействия для BUTTON.xaml
    /// </summary>
    public partial class BUTTON : Page
    {
        public BUTTON()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kitty Kit = new Kitty();
            this.NavigationService.Navigate(Kit);
        }

    }
}
