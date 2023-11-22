using System;
using System.Reflection;
using System.Threading.Tasks;

namespace FiveFriday.Utilities
{
    public class FileReader
    {
        public static async Task<string> ReadFileAsync(string fileName)
        {
            try
            {
                var assembly = typeof(App).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fileName}");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    return await reader.ReadToEndAsync();
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