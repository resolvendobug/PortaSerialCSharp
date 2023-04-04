using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace LerPorta.Services
{
    public class ComPort
    {
        public List<string> Portas { get; }
        public List<string> dados { get; set;}
        private SerialPort sp;

        public ComPort()
        {
            Portas = new List<string>();
            LerPortas();
            
        }
        public void IniciarPorta(string porta)
        {
            sp = new SerialPort(porta, 9600, Parity.None, 8, StopBits.One);
            dados = new List<string>();
        }

        public void LerPortas()
        {
            var names = SerialPort.GetPortNames();

            foreach (var name in names)
            {
                Portas.Add(name);
            }
        }

        public void stopDados(){
            sp.Close();
        }

        public void LerDados()
        {
            sp.DataReceived += sp_DataReceived;
            sp.Open();
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            try
            {
                SerialPort sp = (SerialPort)sender;
                int length = sp.BytesToRead;
                byte[] buf = new byte[length];
                sp.Read(buf, 0, length);
                string hex =  Convert.ToHexString(buf);
                dados.Add(hex);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message, "Error");
                Console.WriteLine(ex.StackTrace);
            }
            
            
        }
    }

}