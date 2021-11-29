﻿using System;
using System.IO;
using Mod2HW6.Interfaces;

namespace Mod2HW6.Services
{
    public class FileReader : IReadFile
    {
        public string ReadFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    return File.ReadAllText(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
    }
}
