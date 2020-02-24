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

namespace Shopping
{
    /// <summary>
    /// Interaction logic for ShoppingListItems.xaml
    /// </summary>
    public partial class ShoppingListItems : UserControl
    {
        public ShoppingListItems()
        {
            InitializeComponent();
        }

        private void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is ShoppingListData data)
            {
                if (sender is Button button)
                {
                    data.Remove(button.DataContext.ToString());
                }
            }
        }
    }
}
