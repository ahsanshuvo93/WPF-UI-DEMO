using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ctrlInputForm.xaml
    /// </summary>
    public partial class ctrlInputForm : UserControl
    {
        public ctrlInputForm()
        {
            InitializeComponent();

            LoadImage();

        }

        void LoadImage()
        {
            string _path = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            _path = _path.Replace("\\bin\\Debug", "");

            string _pathOne = _path + "\\Images\\Flower.jpg";
            string _pathTwo = _path + "\\Images\\see.jpg";

            double _lengthOne = new System.IO.FileInfo(_pathOne).Length;
            double _lengthTwo = new System.IO.FileInfo(_pathTwo).Length;

            _lengthOne = (_lengthOne / 1024) / 1024;

            if (_lengthOne < 3)
            {
                imgOne.Source = new BitmapImage(new Uri(_pathOne, UriKind.RelativeOrAbsolute));
            }
            else
            {
                imgOne.Visibility = Visibility.Collapsed;
                imgErroMsgOne.Visibility = Visibility.Visible;
                bdrImageOne.BorderThickness = new Thickness(1);
            }

            _lengthTwo = (_lengthTwo / 1024) / 1024;

            if (_lengthTwo < 3)
            {
                imgTwo.Source = new BitmapImage(new Uri(_pathTwo, UriKind.RelativeOrAbsolute));
            }
            else
            {
                imgTwo.Visibility = Visibility.Collapsed;
                imgErroMsgTwo.Visibility = Visibility.Visible;
                bdrImageTwo.BorderThickness = new Thickness(1);
            }
        }
    }
}