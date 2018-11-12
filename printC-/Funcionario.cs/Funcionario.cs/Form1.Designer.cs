namespace Funcionario.cs
{
    partial class Form1
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
            this.comboSelect = new System.Windows.Forms.ComboBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.comboCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSelect
            // 
            this.comboSelect.FormattingEnabled = true;
            this.comboSelect.Location = new System.Drawing.Point(42, 55);
            this.comboSelect.Name = "comboSelect";
            this.comboSelect.Size = new System.Drawing.Size(210, 21);
            this.comboSelect.TabIndex = 12;
            this.comboSelect.SelectedIndexChanged += new System.EventHandler(this.comboSelect_SelectedIndexChanged);
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(39, 30);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(48, 13);
            this.lblEstados.TabIndex = 13;
            this.lblEstados.Text = "Estados:";
            // 
            // comboCidade
            // 
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.Location = new System.Drawing.Point(42, 127);
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(210, 21);
            this.comboCidade.TabIndex = 14;
            this.comboCidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(42, 108);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(48, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidades:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.comboCidade);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.comboSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSelect;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox comboCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button button1;
    }
}

