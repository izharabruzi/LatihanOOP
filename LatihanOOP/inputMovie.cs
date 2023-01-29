using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    internal class inputMovie:MovieModel
    {
        

        public virtual void additemmovie()
        {
            numbermov:
            Console.WriteLine("No. Movie:");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number))
            {
                Console.Clear();
                Console.WriteLine("INVALID INPUT! Hanya bisa angka bulat untuk menambahkan nomor");
                goto numbermov;
                
                input = Console.ReadLine();
                
            }
            if (int.TryParse(input, out number))
            {
                Console.Clear();
                NumberofMovie = number;
                Console.WriteLine("No. Movie:");
                Console.WriteLine(NumberofMovie);
            }
            


            Console.WriteLine("Judul:");
            JudulofMovie = Console.ReadLine();

            ratingmov:
            Double rating;
            Console.WriteLine("Rating Awal:");
            
            input = Console.ReadLine();
            while (!Double.TryParse(input, out rating))
            {
                Console.Clear();
                Console.WriteLine("INVALID INPUT! Hanya bisa menambahkan angka untuk menambahkan rating:");
                Console.WriteLine("No. Movie:");
                Console.WriteLine(NumberofMovie);
                Console.WriteLine("Judul Movie:");
                Console.WriteLine(JudulofMovie);
                Console.WriteLine("Rating Awal:");
                input = Console.ReadLine();
                Console.Clear();
                
            }
            if (Double.TryParse(input, out rating))
            {
                Console.Clear();
                MovieofRating = rating;
                Console.WriteLine("Rating Awal:");
                Console.WriteLine(MovieofRating);
            }

        }

    }
}
