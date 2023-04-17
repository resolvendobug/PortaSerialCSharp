using LerPorta.Services;

namespace LerPorta
{
    class Program
    {

        static void Main(string[] args)
        {
            ComPort com = new ComPort();
            ComPort com2 = new ComPort();
           
             var portas = com.Portas;
             foreach (var porta in portas)
             {
                 Console.WriteLine(porta);
             }
            
            com.IniciarPorta(com.Portas[2]);
            com2.IniciarPorta(com.Portas[1]);
           // com.LerDados();
          //  com2.LerDados();

            string[] dados = new string[12];
            dados[0] = "01";
            dados[1] = "53";
            dados[2] = "30";
            dados[3] = "31";
            dados[4] = "4B";
            dados[5] = "30";
            dados[6] = "02";
            dados[7] = "4D";
            dados[8] = "30";
            dados[9] = "44";
            dados[10] = "03";
            dados[11] = "30";

            do
            {
               
                int i = 0;
                while (! Console.KeyAvailable) {
                    
                  //  com2.SendDados(dados[i]);
                    if (com.dados.Count > 0)
                    { 

                        foreach (var dado in com.dados.ToList())
                        {
                            Console.WriteLine(dado);
                            com.dados.Remove(dado);
                        }

                        foreach (var dado in com2.dados.ToList())
                        {
                            Console.WriteLine(com2._porta+": "+dado);
                            com2.dados.Remove(dado);
                        }

                        /*
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
                               // Console.Write(dado);
                                //Console.Write(" ");
                              //  com.dados.Remove(dado);
                            }
                        }*/
                    }
                    i = i == 11 ? 0 : i+1;
                    Thread.Sleep(100);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            com.stopDados();

        }

      
    }
}
