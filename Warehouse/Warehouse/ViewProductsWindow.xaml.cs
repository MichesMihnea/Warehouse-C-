using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
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
    /// Interaction logic for ViewProductsWindow.xaml
    /// </summary>
    public partial class ViewProductsWindow : Window
    {
        WarehouseContext ctx;
        public ViewProductsWindow(WarehouseContext ctx)
        {
            this.ctx = ctx;
            InitializeComponent();
            dataGrid.ItemsSource = ctx.Products.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IList selectedRows = dataGrid.SelectedItems;

            foreach (Product row in selectedRows)
            {
                ctx.Products.Remove(row);
                ctx.SaveChanges();
            }

            dataGrid.ItemsSource = ctx.Products.ToList();
            dataGrid.Items.Refresh();
        }
    }
}
