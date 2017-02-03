//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
namespace Rextester 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            int numero = 0;
            String binario = "";
            
            Console.Write("Ingrese un numero decimal positivo: ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero > 0) {
              
                while (numero > 0) {
                    if (numero%2 == 0) {
                        binario = "0" + binario;
                    } else {
                        binario = "1" + binario;
                    }
                    numero = (int) numero/2;
                }
                
            } else if (numero == 0) {
                binario = "0";
            } else {
                binario = "No se pudo convertir el Numero. Ingrese solo numeros positivos";
            }
            
            Console.WriteLine("El resultado de la conversion es: " + binario);
            Console.ReadKey();
        }
    }
}