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

namespace ATCRadarScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class ScreenTag
        {
            private double finalX;
            private double finalY;
            private double actualX;
            private double actualY;

            ScreenTag( double x, double y)
            {
                actualX = x;
                actualY = y;
                // slant to right upward
                finalX += 3d;
                finalY -= 3d;
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //TextBlock textBlock1 = new TextBlock();
            //TextBlock textBlock2 = new TextBlock();

            //textBlock1.TextWrapping = textBlock2.TextWrapping = TextWrapping.Wrap;
            //textBlock2.Background = Brushes.AntiqueWhite;
            //textBlock2.TextAlignment = TextAlignment.Center;

            //textBlock1.Inlines.Add(new Bold(new Run("TextBlock")));
            //textBlock1.Inlines.Add(new Run(" is designed to be "));
            //textBlock1.Inlines.Add(new Italic(new Run("lightweight")));
            //textBlock1.Inlines.Add(new Run(", and is geared specifically at integrating "));
            //textBlock1.Inlines.Add(new Italic(new Run("small")));
            //textBlock1.Inlines.Add(new Run(" portions of flow content into a UI."));

            //textBlock2.Text =
            //    "By default, a TextBlock provides no UI beyond simply displaying its contents.";
        }
    }
}
