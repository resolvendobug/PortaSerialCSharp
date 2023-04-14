using System.IO.Ports;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace LerPorta.Services
{
    public class ComPort
    {
        public List<string> Portas { get; }
        public string _porta;
        public List<string> dados { get; set;}
        private SerialPort sp;
        private string hex;
        string[] _linhas;

        public ComPort()
        {
            Portas = new List<string>();
            LerPortas();
            
        }
        public void IniciarPorta(string porta)
        {
            _porta = porta;
            sp = new SerialPort(_porta, 9600, Parity.None, 8, StopBits.One);
            dados = new List<string>();
            sp.Open();
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
            if (sp != null)
            {
                sp.Close();
            }
        }

        public void LerDados(string[] linhas)
        {
            _linhas = linhas;
            sp.DataReceived += sp_DataReceived;
           
        }

        public void SendDados(string dados)
        {
            byte[] bytes = Convert.FromHexString(dados);
            sp.Write(bytes, 0, bytes.Length);
           
        }
        

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            try
            {
                SerialPort sp = (SerialPort)sender;
                int length = sp.BytesToRead;
                byte[] buf = new byte[length];
                sp.Read(buf, 0, length);
                hex +=  Convert.ToHexString(buf);

                foreach (var item in _linhas)
                {
                    string[] x = item.Replace(" ","").Split(";");
                    if (hex.Contains(x[1].ToUpper()))
                    {
                        dados.Add(x[0] + ";" + x[1] + ";" + x[2]);
                        hex = "";
                    }
                    
                }

                // hex +=  System.Text.Encoding.UTF8.GetString(buf);
                //if (hex.Contains("03"))
                // {
               
                //    hex = "";
               // }
               // dados.Add(hex);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message, "Error");
                Console.WriteLine(ex.StackTrace);
            }
            
            
        }
    }

}