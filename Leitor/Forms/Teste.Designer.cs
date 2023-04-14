namespace Leitor.Forms
{
    partial class Comunicação
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(55, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(580, 259);
            listBox1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Gainsboro;
            btnIniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnIniciar.Location = new Point(55, 377);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(580, 53);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(55, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 7;
            label2.Text = "COM RX:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(346, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 8;
            label1.Text = "COM TX:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DropDownClosed += comboBox1_DropDownClosed;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(446, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.DropDownClosed += comboBox2_DropDownClosed;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Gainsboro;
            checkBox1.Location = new Point(55, 351);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Rolagem Automática";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Comunicação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnIniciar);
            Controls.Add(listBox1);
            Name = "Comunicação";
            Text = "Comunicação";
            FormClosed += Teste_FormClosed;
            Load += Teste_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
    }
}