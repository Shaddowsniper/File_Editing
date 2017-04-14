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
            string path = "";
            string editChoice = "";
            string search;
            string replace;

            bool readable = false;
            bool editFile = true;
            bool editString = true;
            bool editNextFile = true;


            //Soll eine Datei bearbeitet Werden?
            while (editFile)
            {
                editNextFile = true;
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

                //Datei zum Beschreiben öffnen
                while (editString)
                {
                    //Definierung des Textes, der ersetzt werden soll.
                    Console.WriteLine("Den Suchbegriff eingeben.");
                    search = Console.ReadLine();
                    Console.WriteLine("Änderung eingeben.");
                    replace = Console.ReadLine();

                    //Überschreibung des Textes
                    string text = File.ReadAllText(path);
                    text = text.Replace(search, replace);
                    File.WriteAllText(path, text);



                    Console.WriteLine("Die Datei weiter bearbeiten?y(es), n(o)");
                    editChoice = Console.ReadLine();
                    if(editChoice == "n")
                    {
                        editString = false;
                    }
                }

                //Abfrage, ob eine weitere Datei bearbeitet werden soll.
                while (editNextFile)
                {
                    Console.WriteLine("Weitere Dateien bearbeiten? y(es),n(o)");
                    editChoice = Console.ReadLine();
                    if (editChoice == "n")
                    {
                        editFile = false;
                        editNextFile = false;
                    }else if(editChoice == "y")
                    {
                        readable = false;
                        editNextFile = false;
                        editString = true;
                    }
                }
            }
        }
    }
}
