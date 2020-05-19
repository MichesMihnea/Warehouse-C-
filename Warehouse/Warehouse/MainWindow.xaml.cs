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
using Warehouse.Model;
using Warehouse.Program;

namespace Warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WarehouseContext ctx;
        public MainWindow()
        {
            InitializeComponent();
            ctx = new WarehouseContext();          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addProductWindow = new AddProductWindow(ctx);
            addProductWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var viewProductsWindow = new ViewProductsWindow(ctx);
            viewProductsWindow.Show();
        }
    }
}
