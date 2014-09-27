﻿namespace PetPamonha
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.label1 = new System.Windows.Forms.Label();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtPET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBanho = new System.Windows.Forms.CheckBox();
            this.chkTosa = new System.Windows.Forms.CheckBox();
            this.chkUnhas = new System.Windows.Forms.CheckBox();
            this.chkRelaxamento = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mktCPF
            // 
            this.mktCPF.Location = new System.Drawing.Point(51, 47);
            this.mktCPF.Mask = "000.000.000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(89, 20);
            this.mktCPF.TabIndex = 4;
            this.mktCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtPET
            // 
            this.txtPET.Location = new System.Drawing.Point(83, 15);
            this.txtPET.Name = "txtPET";
            this.txtPET.Size = new System.Drawing.Size(205, 20);
            this.txtPET.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome PET: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgendar.Location = new System.Drawing.Point(236, 200);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(112, 44);
            this.btnAgendar.TabIndex = 10;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "13:45",
            "14:50",
            "18:30"});
            this.comboBox1.Location = new System.Drawing.Point(51, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRelaxamento);
            this.groupBox1.Controls.Add(this.chkUnhas);
            this.groupBox1.Controls.Add(this.chkTosa);
            this.groupBox1.Controls.Add(this.chkBanho);
            this.groupBox1.Location = new System.Drawing.Point(344, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tratamentos";
            // 
            // chkBanho
            // 
            this.chkBanho.AutoSize = true;
            this.chkBanho.Location = new System.Drawing.Point(16, 32);
            this.chkBanho.Name = "chkBanho";
            this.chkBanho.Size = new System.Drawing.Size(57, 17);
            this.chkBanho.TabIndex = 0;
            this.chkBanho.Text = "Banho";
            this.chkBanho.UseVisualStyleBackColor = true;
            // 
            // chkTosa
            // 
            this.chkTosa.AutoSize = true;
            this.chkTosa.Location = new System.Drawing.Point(16, 68);
            this.chkTosa.Name = "chkTosa";
            this.chkTosa.Size = new System.Drawing.Size(50, 17);
            this.chkTosa.TabIndex = 1;
            this.chkTosa.Text = "Tosa";
            this.chkTosa.UseVisualStyleBackColor = true;
            // 
            // chkUnhas
            // 
            this.chkUnhas.AutoSize = true;
            this.chkUnhas.Location = new System.Drawing.Point(129, 32);
            this.chkUnhas.Name = "chkUnhas";
            this.chkUnhas.Size = new System.Drawing.Size(57, 17);
            this.chkUnhas.TabIndex = 2;
            this.chkUnhas.Text = "Unhas";
            this.chkUnhas.UseVisualStyleBackColor = true;
            // 
            // chkRelaxamento
            // 
            this.chkRelaxamento.AutoSize = true;
            this.chkRelaxamento.Location = new System.Drawing.Point(129, 68);
            this.chkRelaxamento.Name = "chkRelaxamento";
            this.chkRelaxamento.Size = new System.Drawing.Size(88, 17);
            this.chkRelaxamento.TabIndex = 3;
            this.chkRelaxamento.Text = "Relaxamento";
            this.chkRelaxamento.UseVisualStyleBackColor = true;
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mktCPF);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.TextBox txtPET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRelaxamento;
        private System.Windows.Forms.CheckBox chkUnhas;
        private System.Windows.Forms.CheckBox chkTosa;
        private System.Windows.Forms.CheckBox chkBanho;
    }
}