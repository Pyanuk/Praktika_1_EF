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

namespace Praktika_1_EF
{
 
    public partial class FourPage : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public FourPage()
        {
            InitializeComponent();
            CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
        }
    }
}
