using Project1.Core;
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

namespace Project1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }


        private void BtnGreate_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.ConectFrame.Navigate(new PageCreate());
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.ConectFrame.Navigate(new PagReg());
        }
    }
}
