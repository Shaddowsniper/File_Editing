using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Change_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisierung der Variablen
            string path;
            string editChoice = "";
            bool readable = false;
            bool editFile = true;
            bool editString = true;
            bool editNextFile = true;

            //Soll eine Datei bearbeitet Werden?
            while (editFile)
            {
                //Prüfung, ob die angegebene Datei existiert.
                while (!readable)
                {
                    Console.WriteLine("Bitte den Dateipfad eingeben.");
                    path = Console.ReadLine();
                    if (File.Exists(path))
                    {
                        readable = true;
                    }
                }

                //Abfrage, ob eine weitere Datei bearbeitet werden soll.
                while (editNextFile)
                {
                    Console.WriteLine("Weitere Datei bearbeiten? y(es),n(o)");
                    editChoice = Console.ReadLine();
                    if (editChoice == "n")
                    {
                        editFile = false;
                        editNextFile = false;
                    }
                }
            }
        }
    }
}
