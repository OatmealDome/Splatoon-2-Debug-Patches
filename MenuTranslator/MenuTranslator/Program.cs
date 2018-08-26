using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MenuTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("MenuTranslator.exe <target file> <translation file> <destination file>");
                return;
            }

            // Get args
            string targetFile = args[0];
            string translationFile = args[1];
            string destFile = args[2];

            // Load the translation dictionary
            Dictionary<string, string> translationDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(translationFile));

            // Read the target file
            string targetContents = File.ReadAllText(targetFile);

            // Replace all localizables, the lazy way
            foreach (string key in translationDictionary.Keys)
            {
                Console.WriteLine("Replacing " + key);
                targetContents = targetContents.Replace("\"" + key + "\"", "\"" + translationDictionary[key] + "\"");
            }

            // Write out the new file
            File.WriteAllText(destFile, targetContents);

            Console.WriteLine("Done!");
        }
    }
}
