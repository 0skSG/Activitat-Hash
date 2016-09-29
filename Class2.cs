using System;
using System.Text; //Llibreria necesaria per el UTF8
using System.Security.Cryptography; //Llibreria per poder instancia SHA512

namespace ActivitatHash
{
    class Program
    {
        static void Main(String[] args)
        {
            //Creem una string de text, on guardarem l'arxiu de text que volem utilitzar
            String Text = null;
            String Text = System.IO.File.ReadAllText(@"C:\Users\Oscar\Documents\GitHub\Activitat-Hash\TextProvaHash");

            //Convertim l'String del text en un array de bytes
            byte[] ArrayBytes = UTF8Encoding.UTF8.GetBytes(Text);

            //Instanciem classe que ens permet calcular el hash
            SHA512Managed SHA512 = new SHA512Managed();

            //Calculem el hash de l'array generat anteriorment
            byte[] ArrayHash = SHA512.ComputeHash(ArrayBytes);

            //Tornem a transofrmar l'array a String per tal de poder guardar-lo en un arxiu
            String HashResultat = BitConverter.ToString(ArrayHash, 0);

            //Generem l'arxiu de text que contindrà el hash resultant
            System.IO.File.WriteAllText(@"C:\Users\Oscar\Documents\GitHub\Activitat-Hash\HashResultat.txt", text);

            //En cas de voler mostrar-lo per pantalla
            //Console.WriteLine("Hash {0}", HashResultat);
            //Console.ReadKey();

            //Eliminem la instancia
            SHA512.Dispose();


        }
    }
}
