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
        //Enum for converting 
        public enum MovieGenre
        {
            Action = 28,
            Adventure = 12,
            Animation = 16,
            Comedy = 35,
            Crime = 80,
            Documentary = 99,
            Drama = 18,
            Family = 10751,
            Fantasy = 14,
            History = 36,
            Horror = 27,
            Music = 10402,
            Mystery = 9648,
            Romance = 10749,
            ScienceFiction = 878,
            TVMovie = 10770,
            Thriller = 53,
            War = 10752,
            Western = 37
        }
        //Class variables
        public Object[] Genres; //array to store genres currently used
        public int number; 

        //Consrtuctors
        public DataComms()
        {
            Genres = null;
        }

        //grabs genres from mainWindow and sets it in class
        //returns -1 on error
        //returns 1 on success
        public int setGenres(ArrayList genres)
        {
            //check that input was valid
            if (genres == null)
                return -1;

            //Convert the array list to an array and store in Class variable
            Genres = genres.ToArray();
            return 1;
        }

        //get Genres
        public Object getGenres()
        {
            return Genres;
        }

        //sends request to API to search for movies with the requested genres
        /*public Object getRecs()
        {
            
        }*/
    }
}
