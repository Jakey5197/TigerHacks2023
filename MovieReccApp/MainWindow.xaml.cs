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
using System.Collections;

namespace MovieReccApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataComms Wire = new DataComms(); //line used for communicating with api and database
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //Compiling Check Boxes
            CheckBox[] genres = new CheckBox[19];
            genres[0] = this.Action;
            genres[1] = this.Adventure;
            genres[2] = this.Animation;
            genres[3] = this.Comedy;
            genres[4] = this.Crime;
            genres[5] = this.Documentary;
            genres[6] = this.Drama;
            genres[7] = this.Family;
            genres[8] = this.Fantasy;
            genres[9] = this.History;
            genres[10] = this.Horror;
            genres[11] = this.Music;
            genres[12] = this.Mystery;
            genres[13] = this.Romance;
            genres[14] = this.ScienceFiction;
            genres[15] = this.TVMovie;
            genres[16] = this.Thriller;
            genres[17] = this.War;
            genres[18] = this.Western;

            //Check which boxes are selected
            ArrayList selections = new ArrayList();
            foreach (CheckBox genre in genres)
            {
                //Count items 
                if(genre.IsChecked == true)
                {
                    selections.Add(genre.Name);

                }
                //Update Wire genre info
                if(Wire.setGenres(selections) == -1) //check for errors
                {
                    //do something to fix it idk
                }
            }
            
        }
    }
}
