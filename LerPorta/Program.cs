
using System.IO.Ports;
using LerPorta.Services;

namespace LerPorta
{
    class Program
    {

        static void Main(string[] args)
        {
            ComPort com = new ComPort();
           
             var portas = com.Portas;
             foreach (var porta in portas)
             {
                 Console.WriteLine(porta);
             }
            
            com.IniciarPorta(com.Portas[1]);
            com.LerDados();

            do
            {
                string cs = "";
                while (! Console.KeyAvailable) {
                    
                    foreach (var dado in com.dados.ToList())
                    {
                        if(dado.Contains("03")){
                            cs = dado;
                            Console.WriteLine();
                            com.dados.Remove(cs); 
                        }else 
                        if(cs.Contains("03")) 
                        { 
                            cs += dado; 
                            Console.WriteLine("cs: "+cs);
                            com.dados.Remove(dado); 
                            cs = "";
                        }else{
                            Console.Write(dado);
                            //Console.Write(" ");
                            com.dados.Remove(dado);
                        }
                    }
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            com.stopDados();

        }

      
    }
}
