using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP
{
    internal class ErrorHandlingForInput: MovieModel
    {
        public ErrorHandlingForInput() : base() { }

        public void CheckInputFirstProgram(string input)
        {
            try
            {
                if (input != "1" || input != "2" || input != "3")
                {
                    throw new Exception("Pilihan tidak tersedia. Silahkan hanya input 1-3.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void CheckInputNandY(string input)
        {
            try
            {
                if (input != "N" || input != "Y")
                {
                    throw new Exception($"Pilihan tidak tersedia. Silahkan hanya input N atau Y");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void CheckInputStopEnter(string input)
        {
            try
            {
                if (input != "STOP" || input != "ENTER")
                {
                    throw new Exception($"Pilihan tidak tersedia. Silahkan hanya input STOP atau ENTER");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
