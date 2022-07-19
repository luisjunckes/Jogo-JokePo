
namespace JoKenPo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.JoKenPo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JoKenPo
            // 
            this.JoKenPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoKenPo.Location = new System.Drawing.Point(12, 9);
            this.JoKenPo.Name = "JoKenPo";
            this.JoKenPo.Size = new System.Drawing.Size(598, 224);
            this.JoKenPo.TabIndex = 0;
            this.JoKenPo.Text = "Escolha: pedra, papel ou tesoura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(79, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voce";
            // 
            // PC
            // 
            this.PC.AutoSize = true;
            this.PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PC.Location = new System.Drawing.Point(373, 146);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(39, 25);
            this.PC.TabIndex = 5;
            this.PC.Text = "Pc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(654, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "?";
            // 
            // Vs
            // 
            this.Vs.AutoSize = true;
            this.Vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Vs.Location = new System.Drawing.Point(238, 146);
            this.Vs.Name = "Vs";
            this.Vs.Size = new System.Drawing.Size(39, 25);
            this.Vs.TabIndex = 7;
            this.Vs.Text = "Vs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(517, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(296, 267);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(200, 200);
            this.btnPaper.TabIndex = 10;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Location = new System.Drawing.Point(562, 267);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(200, 200);
            this.btnScissors.TabIndex = 11;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.btnStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStone.Location = new System.Drawing.Point(19, 267);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(200, 200);
            this.btnStone.TabIndex = 9;
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // picResult
            // 
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResult.Location = new System.Drawing.Point(562, 61);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(200, 200);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 3;
            this.picResult.TabStop = false;
            this.picResult.Click += new System.EventHandler(this.picResult_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(296, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 499);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Vs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JoKenPo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoKenPo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Vs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
    }
}

