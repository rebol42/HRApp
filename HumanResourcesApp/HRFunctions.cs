using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HumanResourcesApp
{
    public class HRFunctions<T> where T : new()
    {
        private string _filePath;


        public HRFunctions(string filePath)
        {
            _filePath = filePath;
        }


        public void SerializeToFile(T Employee)
        {
            var  serializer = new JsonSerializer(); 
            var streamWriter = new StreamWriter(_filePath);


            try
            {
                serializer.Serialize(streamWriter, Employee);
                streamWriter.Close();
                streamWriter.Dispose();

            }
            finally
            {
                streamWriter.Dispose();

            }

        }

        public T DeserializeFromFile()
        {

            if (!File.Exists(_filePath))
            {
                return new T();
            }

            /*
            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (T)serializer.(streamReader)(_filePath);
                streamReader.Close();

                return students;
            }
            */
            using (var streamReader = new StreamReader(_filePath))
            using (JsonTextReader jsonReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var employee = serializer.Deserialize<T>(jsonReader);

                return employee;
            }
        }

    }
}
