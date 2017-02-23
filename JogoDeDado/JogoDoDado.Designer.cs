namespace JogoDeDado
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
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.btnJogDado = new System.Windows.Forms.Button();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.txtRodada = new System.Windows.Forms.TextBox();
            this.lblRodada = new System.Windows.Forms.Label();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.lblJ1result = new System.Windows.Forms.Label();
            this.lblJ2result = new System.Windows.Forms.Label();
            this.lstBoxJ1 = new System.Windows.Forms.ListBox();
            this.lstBoxJ2 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(32, 18);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(151, 31);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(592, 18);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(151, 31);
            this.lblJogador2.TabIndex = 1;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // btnJogDado
            // 
            this.btnJogDado.BackColor = System.Drawing.Color.Azure;
            this.btnJogDado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogDado.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogDado.Location = new System.Drawing.Point(317, 260);
            this.btnJogDado.Name = "btnJogDado";
            this.btnJogDado.Size = new System.Drawing.Size(130, 52);
            this.btnJogDado.TabIndex = 2;
            this.btnJogDado.Text = "Jogar Dado";
            this.btnJogDado.UseVisualStyleBackColor = false;
            this.btnJogDado.Click += new System.EventHandler(this.btnJogDado_Click);
            // 
            // txtJogador1
            // 
            this.txtJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador1.Location = new System.Drawing.Point(79, 52);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.ReadOnly = true;
            this.txtJogador1.Size = new System.Drawing.Size(56, 38);
            this.txtJogador1.TabIndex = 3;
            this.txtJogador1.Text = "0";
            this.txtJogador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJogador2
            // 
            this.txtJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador2.Location = new System.Drawing.Point(638, 52);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.ReadOnly = true;
            this.txtJogador2.Size = new System.Drawing.Size(56, 38);
            this.txtJogador2.TabIndex = 4;
            this.txtJogador2.Text = "0";
            this.txtJogador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRodada
            // 
            this.txtRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRodada.Location = new System.Drawing.Point(359, 130);
            this.txtRodada.Name = "txtRodada";
            this.txtRodada.ReadOnly = true;
            this.txtRodada.Size = new System.Drawing.Size(43, 35);
            this.txtRodada.TabIndex = 5;
            this.txtRodada.Text = "1";
            this.txtRodada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodada.Location = new System.Drawing.Point(335, 104);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(93, 23);
            this.lblRodada.TabIndex = 6;
            this.lblRodada.Text = "Rodada";
            // 
            // txtDado
            // 
            this.txtDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDado.Location = new System.Drawing.Point(359, 318);
            this.txtDado.Name = "txtDado";
            this.txtDado.ReadOnly = true;
            this.txtDado.Size = new System.Drawing.Size(43, 31);
            this.txtDado.TabIndex = 14;
            this.txtDado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJ1result
            // 
            this.lblJ1result.AutoSize = true;
            this.lblJ1result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1result.Location = new System.Drawing.Point(75, 232);
            this.lblJ1result.Name = "lblJ1result";
            this.lblJ1result.Size = new System.Drawing.Size(61, 20);
            this.lblJ1result.TabIndex = 15;
            this.lblJ1result.Text = "Result";
            this.lblJ1result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJ1result.Visible = false;
            // 
            // lblJ2result
            // 
            this.lblJ2result.AutoSize = true;
            this.lblJ2result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2result.Location = new System.Drawing.Point(634, 231);
            this.lblJ2result.Name = "lblJ2result";
            this.lblJ2result.Size = new System.Drawing.Size(61, 20);
            this.lblJ2result.TabIndex = 16;
            this.lblJ2result.Text = "Result";
            this.lblJ2result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJ2result.Visible = false;
            // 
            // lstBoxJ1
            // 
            this.lstBoxJ1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxJ1.FormattingEnabled = true;
            this.lstBoxJ1.ItemHeight = 31;
            this.lstBoxJ1.Location = new System.Drawing.Point(90, 105);
            this.lstBoxJ1.Name = "lstBoxJ1";
            this.lstBoxJ1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstBoxJ1.Size = new System.Drawing.Size(34, 97);
            this.lstBoxJ1.TabIndex = 17;
            // 
            // lstBoxJ2
            // 
            this.lstBoxJ2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxJ2.FormattingEnabled = true;
            this.lstBoxJ2.ItemHeight = 31;
            this.lstBoxJ2.Location = new System.Drawing.Point(650, 105);
            this.lstBoxJ2.Name = "lstBoxJ2";
            this.lstBoxJ2.Size = new System.Drawing.Size(34, 97);
            this.lstBoxJ2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::JogoDeDado.Properties.Resources.dice;
            this.pictureBox2.Location = new System.Drawing.Point(140, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoDeDado.Properties.Resources.dice2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(767, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstBoxJ2);
            this.Controls.Add(this.lstBoxJ1);
            this.Controls.Add(this.lblJ2result);
            this.Controls.Add(this.lblJ1result);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.txtRodada);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.btnJogDado);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Button btnJogDado;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.TextBox txtRodada;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.Label lblJ1result;
        private System.Windows.Forms.Label lblJ2result;
        private System.Windows.Forms.ListBox lstBoxJ1;
        private System.Windows.Forms.ListBox lstBoxJ2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

