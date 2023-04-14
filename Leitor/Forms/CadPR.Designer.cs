namespace Leitor.Forms
{
    partial class CadPR
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
            labelPergunta = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            buttonSalvar = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // labelPergunta
            // 
            labelPergunta.Anchor = AnchorStyles.None;
            labelPergunta.AutoSize = true;
            labelPergunta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPergunta.ForeColor = SystemColors.ControlLightLight;
            labelPergunta.Location = new Point(110, 82);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(101, 30);
            labelPergunta.TabIndex = 0;
            labelPergunta.Text = "Pergunta:";
            labelPergunta.Click += labelPergunta_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(110, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(564, 29);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(110, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(564, 29);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(110, 146);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 2;
            label1.Text = "Resposta:";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(110, 283);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 123);
            listBox1.TabIndex = 4;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.None;
            buttonSalvar.BackColor = Color.Gainsboro;
            buttonSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.ActiveCaptionText;
            buttonSalvar.Location = new Point(110, 233);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(564, 35);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(110, 23);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 6;
            label2.Text = "Número:";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(110, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(564, 29);
            textBox3.TabIndex = 7;
            // 
            // CadPR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(buttonSalvar);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelPergunta);
            Name = "CadPR";
            Text = "Perguntas/Respostas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPergunta;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private ListBox listBox1;
        private Button buttonSalvar;
        private Label label2;
        private TextBox textBox3;
    }
}