using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MovieReccApp
{
    public class DataComms
    {
        enum genreID
        {

        }
        //Class variables
        public Object[] Genres; //array to store genres currently used

        //Consrtuctors
        public DataComms()
        {
            Genres = null;
        }

        //grabs genres from mainWindow
        //returns -1 on error
        //returns 1 on success
        public int getGenres(ArrayList genres)
        {
            //check that input was valid
            if (genres == null)
                return -1;

            //Convert the array list to an array and store in Class variable
            Genres = genres.ToArray();
            return 1;
        }
    }
}
