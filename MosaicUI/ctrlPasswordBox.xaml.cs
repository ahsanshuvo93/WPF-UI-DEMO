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
    /// Interaction logic for ctrlPasswordBox.xaml
    /// </summary>
    public partial class ctrlPasswordBox : UserControl
    {
        public string c2tPassword
        {
            get { return c2tPasswordBox.Password; }
            set { c2tPasswordBox.Password = value; }
        }

        public string c2tPasswordBoxPlaceholder
        {
            get { return PasswordBoxPlaceholder.Text; }
            set { PasswordBoxPlaceholder.Text = value; }
        }

        string m_temp { get; set; }
        public ctrlPasswordBox()
        {
            InitializeComponent();
        }
    }
}
