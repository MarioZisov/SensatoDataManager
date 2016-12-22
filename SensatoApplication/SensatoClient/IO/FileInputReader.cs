namespace SensatoClient.IO
{
    using System.Collections.Generic;
    using System.IO;

    public class FileInputReader
    { 
        public FileInputReader()
        {

        }

        public List<string> ReadInput(string filePath)
        {
            List<string> allLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    allLines.Add(line);
                    line = reader.ReadLine();
                }
            }

            return allLines;
        }
    }
}
