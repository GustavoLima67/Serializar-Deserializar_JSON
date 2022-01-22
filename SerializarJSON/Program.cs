using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.IO;
using System.Web.Script.Serialization;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo\Documents\Arquivos c#\02_SerializarJSON_json";

            Usuario usuario = new Usuario() { Name = "Maria das Neves", CPF = "333.333.333.00", Email = "maria@gmail.com" };

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string jsonSrl = jsSerializer.Serialize(usuario);

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(jsonSrl);
            sw.Close();

            Console.WriteLine("File generated");
            Console.ReadKey();
        }
    }
}
