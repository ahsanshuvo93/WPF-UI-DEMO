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

namespace MosaicUI
{
    /// <summary>
    /// Interaction logic for ctrlButton.xaml
    /// </summary>
    public partial class ctrlButton : UserControl
    {
        public string c2tButtonContent
        {
            get { return c2tbtnContent.Text; }
            set { c2tbtnContent.Text = value; }
        }

        public ctrlButton()
        {
            InitializeComponent();
        }
    }
}
