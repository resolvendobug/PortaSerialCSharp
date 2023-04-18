namespace Leitor.Forms
{
    partial class DataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            numeroPergunta = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dadosPergunta = new TextBox();
            labelPergunta = new Label();
            dadosResposta = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(60, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 7;
            label2.Text = "Número:";
            // 
            // numeroPergunta
            // 
            numeroPergunta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numeroPergunta.Location = new Point(60, 42);
            numeroPergunta.Name = "numeroPergunta";
            numeroPergunta.Size = new Size(574, 29);
            numeroPergunta.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(574, 150);
            dataGridView1.TabIndex = 9;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(89, 388);
            button2.Name = "button2";
            button2.Size = new Size(111, 32);
            button2.TabIndex = 10;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(345, 388);
            button3.Name = "button3";
            button3.Size = new Size(117, 32);
            button3.TabIndex = 11;
            button3.Text = "Apagar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(216, 388);
            button4.Name = "button4";
            button4.Size = new Size(111, 32);
            button4.TabIndex = 12;
            button4.Text = "Inserir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dadosPergunta
            // 
            dadosPergunta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dadosPergunta.Location = new Point(60, 107);
            dadosPergunta.Name = "dadosPergunta";
            dadosPergunta.Size = new Size(574, 29);
            dadosPergunta.TabIndex = 14;
            // 
            // labelPergunta
            // 
            labelPergunta.AutoSize = true;
            labelPergunta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPergunta.ForeColor = SystemColors.ControlLightLight;
            labelPergunta.Location = new Point(60, 74);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(101, 30);
            labelPergunta.TabIndex = 13;
            labelPergunta.Text = "Pergunta:";
            // 
            // dadosResposta
            // 
            dadosResposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dadosResposta.Location = new Point(60, 172);
            dadosResposta.Name = "dadosResposta";
            dadosResposta.Size = new Size(574, 29);
            dadosResposta.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(60, 139);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 15;
            label1.Text = "Resposta:";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(478, 388);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dadosResposta);
            Controls.Add(label1);
            Controls.Add(dadosPergunta);
            Controls.Add(labelPergunta);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(numeroPergunta);
            Controls.Add(label2);
            Name = "DataBase";
            Text = "Banco de Dados";
            Load += DataBase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox numeroPergunta;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox dadosPergunta;
        private Label labelPergunta;
        private TextBox dadosResposta;
        private Label label1;
        private Button button1;
    }
}