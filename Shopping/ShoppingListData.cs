using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shopping
{
    public class ShoppingListData: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            /// ? Checks to see if property changed is null.
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
