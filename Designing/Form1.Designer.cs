namespace Designing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgressiveBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercentagem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProgressiveBar
            // 
            this.ProgressiveBar.BackColor = System.Drawing.Color.Silver;
            this.ProgressiveBar.BorderRadius = 5;
            this.ProgressiveBar.Location = new System.Drawing.Point(37, 365);
            this.ProgressiveBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressiveBar.MaximumValue = 100;
            this.ProgressiveBar.Name = "ProgressiveBar";
            this.ProgressiveBar.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressiveBar.Size = new System.Drawing.Size(547, 12);
            this.ProgressiveBar.TabIndex = 1;
            this.ProgressiveBar.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading....";
            // 
            // lblPercentagem
            // 
            this.lblPercentagem.AutoSize = true;
            this.lblPercentagem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPercentagem.Location = new System.Drawing.Point(157, 338);
            this.lblPercentagem.Name = "lblPercentagem";
            this.lblPercentagem.Size = new System.Drawing.Size(27, 23);
            this.lblPercentagem.TabIndex = 3;
            this.lblPercentagem.Text = "%";
            this.lblPercentagem.Click += new System.EventHandler(this.lblPercentagem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(189, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "SYSTEM MANAGMENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPercentagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressiveBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressiveBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

