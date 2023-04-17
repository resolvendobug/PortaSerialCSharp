using Dapper;
using Leitor.DB;
using Leitor.Entity;
using Leitor.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Leitor.Forms
{
    public partial class DataBase : Form
    {
        DBase db;
        PerguntaRepository perguntaRepository;
        public DataBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            db = new DBase();
            //     perguntaRepository = new PerguntaRepository(db);
            LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            perguntaRepository = new PerguntaRepository(db);
            List<Pergunta> list = await perguntaRepository.LoadData();
            if (list.Count() > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.numeroPergunta = numeroPergunta.Text;
            p.dadosPergunta = dadosPergunta.Text;
            p.dadosResposta = dadosResposta.Text;

            if (perguntaRepository.Insert(p))
            {
                MessageBox.Show("Inserido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir!");
            }
            LoadDataAsync();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Excluir pergunta " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " ?", "Apagar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (!perguntaRepository.Delete(id))
                {
                    MessageBox.Show("Erro ao deletar!");
                }
                LoadDataAsync();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Pergunta p = new Pergunta();
            p.numeroPergunta = numeroPergunta.Text;
            p.dadosPergunta = dadosPergunta.Text;
            p.dadosResposta = dadosResposta.Text;

            if (perguntaRepository.Update(id, p))
            {
                MessageBox.Show("alterado");
            }
            else
            {
                MessageBox.Show("Erro ao deletar!");
            }
            LoadDataAsync();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button2.Enabled = true;
            numeroPergunta.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dadosPergunta.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dadosResposta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            numeroPergunta.Text = "";
            dadosPergunta.Text = "";
            dadosResposta.Text = "";
        }
    }
}
