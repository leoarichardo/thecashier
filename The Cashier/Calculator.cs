using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cashier
{
    class Calculator
    {
        private List<item> listitem;
        private double total = 0;

        public Calculator()
        {
            this.listitem = new List<item>();
        }
        public void addItem(item item)
        {
            this.listitem.Add(item);
            this.total += item.getsubTotal();
        }
        public double getTotal()
        {
            return total;
        }
        public List<item> getListItem()
        {
            return listitem;
        }
        
    }
}
