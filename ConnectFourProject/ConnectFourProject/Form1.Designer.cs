namespace ConnectFourProject
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
            this.button4 = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.VsPlayer = new System.Windows.Forms.Button();
            this.SinglePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(288, 698);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(581, 115);
            this.button4.TabIndex = 9;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Statistics
            // 
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.Location = new System.Drawing.Point(288, 564);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(581, 115);
            this.Statistics.TabIndex = 8;
            this.Statistics.Text = "Stats";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // VsPlayer
            // 
            this.VsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsPlayer.Location = new System.Drawing.Point(288, 431);
            this.VsPlayer.Name = "VsPlayer";
            this.VsPlayer.Size = new System.Drawing.Size(581, 115);
            this.VsPlayer.TabIndex = 7;
            this.VsPlayer.Text = "Two Player";
            this.VsPlayer.UseVisualStyleBackColor = true;
            this.VsPlayer.Click += new System.EventHandler(this.VsPlayer_Click);
            // 
            // SinglePlayer
            // 
            this.SinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayer.Location = new System.Drawing.Point(288, 300);
            this.SinglePlayer.Name = "SinglePlayer";
            this.SinglePlayer.Size = new System.Drawing.Size(581, 115);
            this.SinglePlayer.TabIndex = 6;
            this.SinglePlayer.Text = "Single Player";
            this.SinglePlayer.UseVisualStyleBackColor = true;
            this.SinglePlayer.Click += new System.EventHandler(this.SinglePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1027, 159);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONNECT FOUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1125, 816);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.VsPlayer);
            this.Controls.Add(this.SinglePlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button VsPlayer;
        private System.Windows.Forms.Button SinglePlayer;
        private System.Windows.Forms.Label label1;
    }
}

