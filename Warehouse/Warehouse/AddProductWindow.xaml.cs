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
using System.Windows.Shapes;
using Warehouse.Model;
using Warehouse.Program;

namespace Warehouse
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        WarehouseContext ctx;
        public AddProductWindow(WarehouseContext ctx)
        {
            this.ctx = ctx;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var prod = new Product() { Name = productNameBox.Text };

            ctx.Products.Add(prod);
            ctx.SaveChanges();
        }
    }
}
