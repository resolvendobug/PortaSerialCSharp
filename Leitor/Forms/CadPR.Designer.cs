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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // labelPergunta
            // 
            labelPergunta.AutoSize = true;
            labelPergunta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPergunta.ForeColor = SystemColors.ControlLightLight;
            labelPergunta.Location = new Point(54, 30);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(101, 30);
            labelPergunta.TabIndex = 0;
            labelPergunta.Text = "Pergunta:";
            labelPergunta.Click += labelPergunta_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(54, 85);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 2;
            label1.Text = "Resposta:";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(54, 211);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 184);
            listBox1.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Server;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(54, 155);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(425, 44);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Salvar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // CadPR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelPergunta);
            Name = "CadPR";
            Text = "CadPR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPergunta;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private ListBox listBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}