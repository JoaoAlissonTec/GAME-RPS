namespace RPSGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_bestpoints = new System.Windows.Forms.Label();
            this.lbl_best = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_tesoura = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_pedra = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_bestpoints);
            this.panel1.Controls.Add(this.lbl_best);
            this.panel1.Controls.Add(this.lbl_points);
            this.panel1.Controls.Add(this.lbl_score);
            this.panel1.Controls.Add(this.btn_tesoura);
            this.panel1.Controls.Add(this.btn_papel);
            this.panel1.Controls.Add(this.btn_pedra);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 401);
            this.panel1.TabIndex = 0;
            // 
            // lbl_bestpoints
            // 
            this.lbl_bestpoints.AutoSize = true;
            this.lbl_bestpoints.Location = new System.Drawing.Point(569, 368);
            this.lbl_bestpoints.Name = "lbl_bestpoints";
            this.lbl_bestpoints.Size = new System.Drawing.Size(21, 20);
            this.lbl_bestpoints.TabIndex = 8;
            this.lbl_bestpoints.Text = "0 ";
            // 
            // lbl_best
            // 
            this.lbl_best.AutoSize = true;
            this.lbl_best.Location = new System.Drawing.Point(504, 368);
            this.lbl_best.Name = "lbl_best";
            this.lbl_best.Size = new System.Drawing.Size(59, 20);
            this.lbl_best.TabIndex = 7;
            this.lbl_best.Text = "Melhor:";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(679, 368);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(21, 20);
            this.lbl_points.TabIndex = 6;
            this.lbl_points.Text = "0 ";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(596, 368);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(81, 20);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Pontuação:";
            // 
            // btn_tesoura
            // 
            this.btn_tesoura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_tesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tesoura.FlatAppearance.BorderSize = 0;
            this.btn_tesoura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_tesoura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_tesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tesoura.Image = global::RPSGame.Properties.Resources.pedra_papel_tesoura__4_;
            this.btn_tesoura.Location = new System.Drawing.Point(476, 177);
            this.btn_tesoura.Name = "btn_tesoura";
            this.btn_tesoura.Size = new System.Drawing.Size(207, 153);
            this.btn_tesoura.TabIndex = 4;
            this.btn_tesoura.UseVisualStyleBackColor = false;
            this.btn_tesoura.Click += new System.EventHandler(this.btn_tesoura_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_papel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_papel.FlatAppearance.BorderSize = 0;
            this.btn_papel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_papel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_papel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_papel.Image = global::RPSGame.Properties.Resources.pedra_papel_tesoura__2_1;
            this.btn_papel.Location = new System.Drawing.Point(251, 177);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(207, 153);
            this.btn_papel.TabIndex = 3;
            this.btn_papel.UseVisualStyleBackColor = false;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_pedra
            // 
            this.btn_pedra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_pedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pedra.FlatAppearance.BorderSize = 0;
            this.btn_pedra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_pedra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_pedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedra.Image = global::RPSGame.Properties.Resources.pedra_papel_tesoura__2_1;
            this.btn_pedra.Location = new System.Drawing.Point(27, 177);
            this.btn_pedra.Name = "btn_pedra";
            this.btn_pedra.Size = new System.Drawing.Size(207, 153);
            this.btn_pedra.TabIndex = 2;
            this.btn_pedra.UseVisualStyleBackColor = false;
            this.btn_pedra.Click += new System.EventHandler(this.btn_pedra_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(206, 85);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(334, 34);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Pedra, papel ou tesoura?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 396);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RPS Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_titulo;
        private Button btn_tesoura;
        private Button btn_papel;
        private Button btn_pedra;
        private Label lbl_points;
        private Label lbl_score;
        private Label lbl_bestpoints;
        private Label lbl_best;
    }
}