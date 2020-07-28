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
using System.Windows.Threading;

namespace MosaicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                this.contentBody.Content = new ctrlLogIn(this.contentBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Window Move Event
        private void mainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Window Close Event
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            try
            {
                base.OnActivated(e);
                if (WindowStyle != WindowStyle.None)
                {
                    Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, (DispatcherOperationCallback)delegate (object unused)
                    {
                        WindowStyle = WindowStyle.None;
                        return null;
                    },
                    null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
