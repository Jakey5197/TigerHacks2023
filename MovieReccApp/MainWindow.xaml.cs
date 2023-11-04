using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace MovieReccApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //Compiling Check Boxes
            CheckBox[] genres = new CheckBox[8];
            genres[0] = this.Comedy;
            genres[1] = this.Romance;
            genres[2] = this.Horror;
            genres[3] = this.Action;
            genres[4] = this.Scifi;
            genres[5] = this.Mystery;
            genres[6] = this.Kids;
            genres[7] = this.Fantasy;

            //Check which boxes are selected
            foreach (CheckBox genre in genres)
            {
                //If checkbox is checked...
                if(genre.IsChecked == true)
                {

                }
            }
        }
    }
}
