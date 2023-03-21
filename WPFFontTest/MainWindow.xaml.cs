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

namespace WPFFontTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FontFamily newInterFont = new FontFamily(new Uri(@"C:\Users\dani_\source\repos\WPFFontTest\WPFFontTest\Assets\Inter-Regular.otf"), "Inter");
            FontFamily oldInterFont = new FontFamily(new Uri(@"C:\Users\dani_\source\repos\WPFFontTest\WPFFontTest\Assets-old\Inter-Regular.otf"), "Inter");

            mTitle.FontFamily = newInterFont;
            mTextBlock1.FontFamily = newInterFont;
            mTextBlock2.FontFamily = newInterFont;
            mTextBlock3.FontFamily = newInterFont;

            mTitle2.FontFamily = oldInterFont;
            mTextBlock4.FontFamily = oldInterFont;
            mTextBlock5.FontFamily = oldInterFont;
            mTextBlock6.FontFamily = oldInterFont;
        }
    }
}
