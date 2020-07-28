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
    /// Interaction logic for ctrlTextBox.xaml
    /// </summary>
    public partial class ctrlTextBox : UserControl
    {
        // Property
        public string c2tTBoxText
        {
            get { return c2tTBoxtext.Text; }
            set { c2tTBoxtext.Text = value; }
        }

        public string c2tTBoxPlaceHolder
        {
            get { return txtBlockPlaceholder.Text; }
            set { txtBlockPlaceholder.Text = value; }
        }

        string m_temp { get; set; }


        // Constructor
        public ctrlTextBox()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
