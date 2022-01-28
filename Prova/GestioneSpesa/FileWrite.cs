using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GestioneSpesa
{
    internal class FileWrite
    {
        private string data;
        private string categoria;
        private string descrizione;
        private double importo = 0;
        public bool WriteToFile(string filePath, string fileContent)
        {

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"{filePath} does not Exists");
            using (StreamWriter rw = new StreamWriter(@"C:\Users\martina.tiso\Desktop\week2\week2\Week2.FileSystem.txt", true))

            {
                rw.WriteLine(data, categoria, descrizione, importo);
            }
            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = new UTF8Encoding(true).GetBytes(fileContent);
                fs.Write(buffer, 0, buffer.Length);
            }
           
            return true;
        }

        
    }
}
