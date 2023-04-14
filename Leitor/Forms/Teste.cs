using Leitor.Util;
using LerPorta.Services;

namespace Leitor.Forms
{
    public partial class Comunicação : Form
    {
        public ComPort com;
        public ComPort com2;
        int i = 0;

        private string fileTxt = "labelPergunta.txt";
        public string[] lines;

        public Comunicação()
        {
            InitializeComponent();


            com = new ComPort();
            com2 = new ComPort();

            atualizaItemsCombo();


        }

        private void atualizaItemsCombo(string comboSelecionado = null)
        {
            var portas = com.Portas;
            if (comboSelecionado == null)
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }

            if (comboSelecionado == "RX")
            {
                comboBox2.Items.Clear();
            }

            if (comboSelecionado == "TX")
            {
                comboBox1.Items.Clear();
            }


            foreach (var porta in portas)
            {
                if (comboSelecionado == null)
                {
                    comboBox1.Items.Add(porta);
                    comboBox2.Items.Add(porta);
                }

                if (comboSelecionado == "RX")
                {
                    comboBox2.Items.Add(porta);
                }

                if (comboSelecionado == "TX")
                {
                    comboBox1.Items.Add(porta);
                }

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (File.Exists(fileTxt))
            {
                lines = File.ReadAllLines(fileTxt);

            }


            if (timer1.Enabled)
            {
                com.stopDados();
                com2.stopDados();
                timer1.Stop();
                btnIniciar.Text = "Iniciar";
            }
            else
            {
                com = new ComPort();
                com2 = new ComPort();



                if (comboBox1.SelectedItem != null & comboBox2.SelectedItem != null)
                {
                    string agora = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                    listBox1.Items.Add("Iniciando - " + agora);

                    com.IniciarPorta(comboBox1.SelectedItem.ToString()); //5 resposta
                    com2.IniciarPorta(comboBox2.SelectedItem.ToString()); // 7 pergunta


                    com.LerDados(lines);
                    // com2.LerDados();

                    btnIniciar.Text = "Parar";
                    timer1.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Selecione porta serial RX/TX");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (com.dados.Count > 0)
            {

                foreach (var dado in com.dados.ToList())
                {
                    string[] x = dado.Split(";");
                    listBox1.Items.Add("[" + com._porta + "]: " + FormatarTexto.Format(x[0]));
                    listBox1.Items.Add("[" + com2._porta + "]: " + FormatarTexto.Format(x[1]));
                    listBox1.Items.Add("[" + com2._porta + "]: " + FormatarTexto.Format(x[2]));
                    com2.SendDados(x[2]);
                    com.dados.Remove(dado);

                }
            }

            
            //  i = i == 11 ? 0 : i + 1;
            if (checkBox1.Checked)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
        }

        private void Teste_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (com != null)
            {
                com.stopDados();
            }
            if (com2 != null)
            {
                com2.stopDados();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Teste_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            var itemSelecionado = comboBox1.SelectedItem;
            var itemSelecinadoCombo2 = comboBox2.SelectedItem;
            atualizaItemsCombo("RX");
            foreach (var item in comboBox2.Items)
            {
                if (itemSelecionado == item)
                {
                    comboBox2.Items.Remove(itemSelecionado);
                }
            }
            comboBox2.SelectedItem = itemSelecinadoCombo2;
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            var itemSelecionado = comboBox2.SelectedItem;
            var itemSelecinadoCombo1 = comboBox1.SelectedItem;
            atualizaItemsCombo("TX");
            foreach (var item in comboBox1.Items)
            {
                if (itemSelecionado == item)
                {
                    comboBox1.Items.Remove(itemSelecionado);
                }
            }
            comboBox1.SelectedItem = itemSelecinadoCombo1;
        }
    }
}
