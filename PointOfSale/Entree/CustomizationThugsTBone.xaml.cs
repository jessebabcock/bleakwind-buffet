using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Entree
{
    /// <summary>
    /// Interaction logic for CustomizationThugsTBone.xaml
    /// </summary>
    public partial class CustomizationThugsTBone : UserControl
    {
        private OrderComponent o;
        public CustomizationThugsTBone(OrderComponent oc)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Thugs T-Bone";
            o = oc;
        }

        void DoneClick(object sender, RoutedEventArgs e)
        {
            MenuScreen();
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            MenuScreen();
        }

        void MenuScreen()
        {
            o.pageDisplay.Child = o.Menu;
        }
    }
}
