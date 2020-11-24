namespace SandwichReactor
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
            this.Title = new System.Windows.Forms.Label();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.NewTitle = new System.Windows.Forms.Label();
            this.RedBox = new System.Windows.Forms.Label();
            this.RedBox2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(1806, 483);
            this.Title.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(661, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Nuclear reactor control";
            this.Title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Reactor1
            // 
            this.Reactor1.AutoSize = true;
            this.Reactor1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Reactor1.Location = new System.Drawing.Point(113, 135);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(269, 39);
            this.Reactor1.TabIndex = 1;
            this.Reactor1.Text = "Reactor 1";
            // 
            // Reactor2
            // 
            this.Reactor2.AutoSize = true;
            this.Reactor2.ForeColor = System.Drawing.Color.DarkOrange;
            this.Reactor2.Location = new System.Drawing.Point(618, 135);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(297, 39);
            this.Reactor2.TabIndex = 2;
            this.Reactor2.Text = "Reactor 2 ";
            // 
            // NewTitle
            // 
            this.NewTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.NewTitle.ForeColor = System.Drawing.Color.DarkKhaki;
            this.NewTitle.Location = new System.Drawing.Point(182, 45);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(689, 39);
            this.NewTitle.TabIndex = 3;
            this.NewTitle.Text = "Nuclear reactor controll";
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.DarkRed;
            this.RedBox.Cursor = System.Windows.Forms.Cursors.No;
            this.RedBox.Location = new System.Drawing.Point(120, 221);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(246, 205);
            this.RedBox.TabIndex = 4;
            this.RedBox.Click += new System.EventHandler(this.RedBox_Click);
            // 
            // RedBox2
            // 
            this.RedBox2.BackColor = System.Drawing.Color.DarkRed;
            this.RedBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.RedBox2.Location = new System.Drawing.Point(625, 221);
            this.RedBox2.Name = "RedBox2";
            this.RedBox2.Size = new System.Drawing.Size(246, 205);
            this.RedBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(137, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(661, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 69);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start 2 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.BackColor = System.Drawing.Color.Firebrick;
            this.OutPutLabel.Enabled = false;
            this.OutPutLabel.Location = new System.Drawing.Point(203, 525);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(599, 39);
            this.OutPutLabel.TabIndex = 8;
            this.OutPutLabel.Text = "Both reactors Stable";
            this.OutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1044, 573);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RedBox2);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.NewTitle);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("mono 07_66", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Margin = new System.Windows.Forms.Padding(14, 9, 14, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Label NewTitle;
        private System.Windows.Forms.Label RedBox;
        private System.Windows.Forms.Label RedBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label OutPutLabel;
    }
}

