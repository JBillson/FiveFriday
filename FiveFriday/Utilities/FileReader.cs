using System;
using System.Reflection;

namespace FiveFriday.Utilities
{
    public class FileReader
    {
        public static string ReadFile(string fileName)
        {
            try
            {
                var assembly = typeof(App).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fileName}");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to read file: " + e.Message);
                throw;
            }
        }
    }
}