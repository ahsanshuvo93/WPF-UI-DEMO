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
    /// Interaction logic for ctrlFolderBrowser.xaml
    /// </summary>
    public partial class ctrlFolderBrowser : UserControl
    {
        public string c2tTBoxPlaceHolder
        {
            get { return txtBlockPlaceholder.Text; }
            set { txtBlockPlaceholder.Text = value; }
        }

        public ctrlFolderBrowser()
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

        private void btnFolderBrowserPath_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
                dialog.ShowDialog();
                txtFolderBrowserPath.Text = dialog.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
