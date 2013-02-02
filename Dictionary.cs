﻿using System;
using System.Text;

class Dictionary
{
    static void Main()
    {
        bool inDictionary = false;
        string lines = ".NET \U+2014 platform for applications from Microsoft\nCLR \U+2014 managed execution environment for .NET\nnamespace \U+2014 hierarchical organization of classes";
        string[] dictionaryDataCenter = lines.Split('\n');
        string word = Console.ReadLine();
        for (int i = 0; i < dictionaryDataCenter.Length; i++)
        {
            string[] def = dictionaryDataCenter[i].Split('\U+2014');
            for (int j = 0; j < def.Length; j++)
            {
                def[0] = def[0].Trim();
                def[1] = def[1].Trim();
            }
            if (string.Compare(def[0], word, true) == 0)
            {
                Console.WriteLine("Definition for \"{0}\": {1}.",word, def[1]);
                inDictionary = true;
            }
        }
        if (inDictionary == false)
        {
            Console.WriteLine("No matches for {0}!", word);
        }
    }
}