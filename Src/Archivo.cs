using System;
using System.IO;
using System.Collections.Generic;

namespace dummy_anagrams.Src
{
    public class Archivo
    {
        private string[] Internal_Arr = null;

        public Archivo()
        {
            Internal_Arr = new string[] { };
        }
        public Archivo(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"El archivo \"{path}\" no pudo ser encotnrado");
            }
            
            StreamReader sr = new StreamReader(path);
            string line;
            List<string> list_string = new List<string>();

            while ((line = sr.ReadLine()) != null)
            {
                list_string.Add(line);
            }

            this.Internal_Arr = list_string.ToArray();

        }
        public string[] get_array()
        {
            return this.Internal_Arr;
        }

    }


}
