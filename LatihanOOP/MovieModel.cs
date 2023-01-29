using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    internal class MovieModel
    {
        public int NumberofMovie { get; set; }
        public string JudulofMovie { get; set; }
        public double MovieofRating { get; set; }
       

        public List<inputMovie> myList = new List<inputMovie>();

        
        
        public virtual void PrintMovie()
        {
            bool kontinu = true;
            bool kontinuinput1 = true;
            bool kontinuinput2 = true;
            
            while (kontinu)
            {
                firstoption:
                if (kontinu = true)
                {
                    kontinuinput1 = true;
                }
                
                Console.WriteLine("1. Daftar Movies");
                Console.WriteLine("2. Tambah Movies");
                Console.WriteLine("3. Keluar");
                Console.WriteLine("Masukan Pilihan");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    testlist:
                    if (myList.Count > 0)
                    {
                        Console.WriteLine("List Movies dan Rating:");
                        myList.ForEach(item =>
                        {
                            Console.WriteLine(item.NumberofMovie+"." + " " + item.JudulofMovie + " - " + item.MovieofRating);
                         
                        });
                        while (kontinuinput2)
                        {

                            kontinuyesandno:
                            Console.WriteLine("Vote Movie? Y/N");
                            input = Console.ReadLine().ToUpper();
                            if (input == "Y")
                            {
                                Console.Clear();
                                pilihanlanjutvote:
                                Console.WriteLine("List Movies:");
                                myList.ForEach(item =>
                                {
                                    Console.WriteLine(item.NumberofMovie + "." + " " + item.JudulofMovie + " - " + item.MovieofRating);

                                });

                                Console.WriteLine("Pilih Nomor Movie yang ingin di vote");
                                int selectedMovieNumber = int.Parse(Console.ReadLine());
                                var selectedMovie = myList.FirstOrDefault(item => item.NumberofMovie == selectedMovieNumber);
                                if (selectedMovie != null)
                                {
                                    Console.Clear();
                                    jumptoselectedmovie:
                                    Console.WriteLine("Movies Tersedia");
                                    Console.WriteLine("Judul: " + selectedMovie.JudulofMovie);
                                    Console.WriteLine("Rating Sekarang: " + selectedMovie.MovieofRating);
                                    Console.WriteLine($"Yakin ingin vote movie{selectedMovie.JudulofMovie} ? Y/N");
                                    input = Console.ReadLine().ToUpper();
                                    if (input == "Y")
                                    {
                                        Console.Clear();
                                        selectedMovie.MovieofRating += 0.1;
                                        Console.WriteLine($"Terimakasih sudah melakukan vote, kini rating movies dengan judul {selectedMovie.JudulofMovie} telah ditambahkan sebanyak 0.1 !");

                                        myList = myList.OrderByDescending(item => item.MovieofRating).ToList();
                                        myList.ForEach(item =>
                                        {
                                            Console.WriteLine(item.NumberofMovie + "." + " " + item.JudulofMovie + " - " + item.MovieofRating);

                                        });
                                    }
                                    else if (input == "N")
                                    {
                                        Console.Clear();
                                        goto testlist;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        ErrorHandlingForInput HandlingInput5 = new ErrorHandlingForInput();
                                        HandlingInput5.CheckInputNandY(input);
                                        goto jumptoselectedmovie;
                                    }
                                    
                                }
                                
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Movie masih belum tersedia, silahkan pilih:");
                                    Console.WriteLine("1. Menambahkan Movie");
                                    Console.WriteLine("2. Lanjut memberikan vote");
                                    input = Console.ReadLine();
                                    if (input == "1")
                                    {
                                        Console.Clear();
                                        inputMovie inmovie2 = new inputMovie();
                                        inmovie2.additemmovie();
                                        myList.Add(inmovie2);
                                        Console.Clear();
                                        Console.WriteLine("BERHASIL MENAMBAHKAN MOVIES!!");
                                        Console.WriteLine("");
                                        goto pilihanlanjutvote;
                                        //kontinuinput2 = true;

                                    }
                                    else if (input == "2")
                                    {
                                        Console.Clear();
                                        goto pilihanlanjutvote;
                                    }
                                    else
                                    {
                                        Console.WriteLine("tidak tersedia");
                                    }

                                }

                            }
                            else if (input == "N")
                            {
                                Console.Clear();
                                kontinuinput1 = false;
                                kontinustopenter:
                                Console.WriteLine("Yakin exit program? ketik 'stop' jika ingin keluar program / 'enter' untuk memilih ulang ");

                                input = Console.ReadLine().ToUpper();
                                if(input == "STOP")
                                {
                                    Console.WriteLine("Terimakasih Telah Menggunakan Program Kami!!");
                                    kontinu = false;
                                    kontinuinput2 = false;
                                    break;
                                }
                                else if(input == "ENTER")
                                {
                                    kontinuinput1 = true;
                                    kontinuinput2 = true;
                                    kontinu = false;
                                    Console.Clear();
                                    goto firstoption;
                                    
                                }
                                else
                                {
                                    Console.Clear();
                                    ErrorHandlingForInput HandlingInput4 = new ErrorHandlingForInput();
                                    HandlingInput4.CheckInputStopEnter(input);
                                    goto kontinustopenter;
                                }


                            }
                            else
                            {
                                Console.Clear();
                                ErrorHandlingForInput HandlingInput3 = new ErrorHandlingForInput();
                                HandlingInput3.CheckInputNandY(input);
                                goto testlist;
                            }

                        }
                        
                        
                    }
                    else
                    {
                        
                        Console.WriteLine("Tidak ada data movie, silahkan pilih 'Tambah Movies' terlebih dahulu jika ingin melanjutkan. ");
                        
                    }
                    
                }
                else if (input == "2")
                {
                    
                    Console.Clear();
                    
                ifnullmovies:

                    while (kontinuinput1)
                    {
                        
                        inputMovie inmovie = new inputMovie();
                        inmovie.additemmovie();
                        myList.Add(inmovie);
                        Console.Clear();
                        jumpnandy:
                        Console.WriteLine("Lanjutkan tambah movie? Y/N");
                        input = Console.ReadLine().ToUpper();
                        Console.Clear();
                        if (input == "Y") {
                            //int selectedMovieNumberEquals = int.Parse(Console.ReadLine());
                            //var selectedMovie = myList.FirstOrDefault(item => item.NumberofMovie == selectedMovieNumberEquals);
                            //var queryAllCustomers = from test in myList select test.NumberofMovie;
                            //if (selectedMovieNumberEquals.Equals(selectedMovie.NumberofMovie))
                            //{
                            //    Console.WriteLine("Nomor movies sudah ada! silahkan tambahkan yang lain");
                            //}
                            kontinuinput1 = true;
                        }
                        else if (input == "N")
                        {
                            kontinuinput1 = false;
                            stopenter:
                            Console.WriteLine("Yakin exit program? ketik 'stop' jika ingin keluar program /'enter' untuk memilih ulang ke tampilan awal");
                            input = Console.ReadLine().ToUpper();
                            if (input == "STOP")
                            {
                                Console.WriteLine("Terimakasih Telah Menggunakan Program Kami!!");
                                kontinu = false;
                            }
                            else if (input == "ENTER")
                            {
                                Console.Clear();
                                goto firstoption;
                            }
                            else
                            {
                                Console.Clear();
                                ErrorHandlingForInput HandlingInput2 = new ErrorHandlingForInput();
                                HandlingInput2.CheckInputStopEnter(input);
                                goto stopenter;
                            }
                            
                        }
                        else
                        {
                            Console.Clear();
                            ErrorHandlingForInput HandlingInput1 = new ErrorHandlingForInput();
                            HandlingInput1.CheckInputNandY(input);
                            goto jumpnandy;
                        }
                    }
                    
                }
                else if (input == "3")
                {
                    //kontinu = false;
                    Console.WriteLine("Terimakasih Telah Menggunakan Program Kami!!");
                    kontinu = false;
                }
                else
                {
                    Console.Clear();
                    ErrorHandlingForInput HandlingInput = new ErrorHandlingForInput();
                    HandlingInput.CheckInputFirstProgram(input);
                    
                }
            }
        }
    }
}
