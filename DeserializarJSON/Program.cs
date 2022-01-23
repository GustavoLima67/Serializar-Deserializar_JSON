using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Library;
    
namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Gustavo\Documents\Arquivos c#\02_SerializarJSON_json");
            string path = stream.ReadToEnd();

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            Usuario user = (Usuario) jsSerializer.Deserialize(path, typeof(Usuario));

            Console.WriteLine("User Name: {0}, CPF: {1}, Email: {2}", user.Name, user.CPF, user.Email);
            Console.ReadKey();
        }
    }
}
