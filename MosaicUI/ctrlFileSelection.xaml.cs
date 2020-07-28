using Microsoft.Win32;
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
    /// Interaction logic for ctrlFileSelection.xaml
    /// </summary>
    public partial class ctrlFileSelection : UserControl
    {
        public string c2tTBoxPlaceHolder
        {
            get { return txtBlockPlaceholder.Text; }
            set { txtBlockPlaceholder.Text = value; }
        }

        public ctrlFileSelection()
        {
            InitializeComponent();
        }

        private void btnFileBrowserPath_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                FileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
                txtFileSelection.Text = fileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
