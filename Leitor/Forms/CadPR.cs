using Leitor.Services;
using Leitor.Util;
using LerPorta.Services;
using System.Text;
using System.Windows.Media.TextFormatting;

namespace Leitor.Forms
{
    public partial class CadPR : Form
    {
        private string fileTxt = "labelPergunta.txt";
        public string[] lines;
        private int selectedList;
        public CadPR()
        {
            InitializeComponent();
            if (File.Exists(fileTxt))
            {
                lines = File.ReadAllLines(fileTxt);
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPergunta_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string path = "" + fileTxt;
            string line = FormatarTexto.Format(textBox3.Text) + ";" + FormatarTexto.Format(textBox1.Text) + ";" + FormatarTexto.Format(textBox2.Text);
            // line = FormatarTexto.Format(line);
            sb.Append(line);
            listBox1.Items.Add(sb.ToString());
            FileLog.WriteFile(path, sb);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //https://www.youtube.com/watch?v=l1K2AEDByN0
            string? curItem = listBox1.SelectedItem.ToString();
            selectedList = listBox1.SelectedIndex;
            if (curItem != null)
            {
                string[] itens = curItem.Split(new char[] { ';' });
                if (itens.Length == 3)
                {
                    textBox3.Text = itens[0];
                    textBox1.Text = itens[1];
                    textBox2.Text = itens[2];
                }
            }
        }
    }
}
