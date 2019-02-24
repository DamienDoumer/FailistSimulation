using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FailistSimulation.Models;

namespace FailistSimulation.Services
{
    public class DataAccessor
    {
        public static string ReadDataFile()
        {
            string data = string.Empty;
            using (StreamReader reader = new StreamReader("data.json"))
            {
                data = reader.ReadToEnd();
            }

            return data;
        }

        public static FailistObject DeserializeData()
        {
            return null;
        }
    }
}
