using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(8,9);
                ContaCorrente conta2 = new ContaCorrente(8,19);
                conta2.Transferir(10000, conta);
                //conta.Sacar(1000);
                
                //Metodo(); 
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Informações na innerException: ");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
                
            }

            Console.ReadLine();


        }

        public static void Metodo()
        {
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {
            double resultado = Dividir(10, divisor);
            Console.WriteLine("O resultado da divisão 10 por " + divisor + " é " + resultado);
            
        }
        public static double Dividir(int num, int divisor)
        {

            try
            {
                return num / divisor;

            }catch (DivideByZeroException)
            {
               
                Console.WriteLine("Exceção com o número = " + num + " e o divisor " + divisor);
                throw;
            }
        }
    }
}
