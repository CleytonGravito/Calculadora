namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PnlHistorico = new System.Windows.Forms.Panel();
            this.BntExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BntMenu = new System.Windows.Forms.Button();
            this.BntHistorico = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.BntLimparHistorico = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PnlTitulo.SuspendLayout();
            this.PnlHistorico.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.button2);
            this.PnlTitulo.Controls.Add(this.button1);
            this.PnlTitulo.Controls.Add(this.BntExit);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(350, 40);
            this.PnlTitulo.TabIndex = 2;
            // 
            // PnlHistorico
            // 
            this.PnlHistorico.Controls.Add(this.richTextBox1);
            this.PnlHistorico.Controls.Add(this.BntLimparHistorico);
            this.PnlHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistorico.Location = new System.Drawing.Point(0, 565);
            this.PnlHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistorico.Name = "PnlHistorico";
            this.PnlHistorico.Size = new System.Drawing.Size(350, 5);
            this.PnlHistorico.TabIndex = 3;
            // 
            // BntExit
            // 
            this.BntExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BntExit.FlatAppearance.BorderSize = 0;
            this.BntExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntExit.Image = ((System.Drawing.Image)(resources.GetObject("BntExit.Image")));
            this.BntExit.Location = new System.Drawing.Point(300, 0);
            this.BntExit.Margin = new System.Windows.Forms.Padding(0);
            this.BntExit.Name = "BntExit";
            this.BntExit.Size = new System.Drawing.Size(50, 40);
            this.BntExit.TabIndex = 0;
            this.BntExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BntMenu);
            this.panel1.Controls.Add(this.BntHistorico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 4;
            // 
            // BntMenu
            // 
            this.BntMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BntMenu.FlatAppearance.BorderSize = 0;
            this.BntMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntMenu.Image = ((System.Drawing.Image)(resources.GetObject("BntMenu.Image")));
            this.BntMenu.Location = new System.Drawing.Point(0, 0);
            this.BntMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BntMenu.Name = "BntMenu";
            this.BntMenu.Size = new System.Drawing.Size(50, 40);
            this.BntMenu.TabIndex = 2;
            this.BntMenu.UseVisualStyleBackColor = true;
            // 
            // BntHistorico
            // 
            this.BntHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.BntHistorico.FlatAppearance.BorderSize = 0;
            this.BntHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BntHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntHistorico.Image = ((System.Drawing.Image)(resources.GetObject("BntHistorico.Image")));
            this.BntHistorico.Location = new System.Drawing.Point(300, 0);
            this.BntHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.BntHistorico.Name = "BntHistorico";
            this.BntHistorico.Size = new System.Drawing.Size(50, 40);
            this.BntHistorico.TabIndex = 0;
            this.BntHistorico.UseVisualStyleBackColor = true;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.TxtDisplay2.TabIndex = 5;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 105);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay1.TabIndex = 6;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BntLimparHistorico
            // 
            this.BntLimparHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BntLimparHistorico.FlatAppearance.BorderSize = 0;
            this.BntLimparHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BntLimparHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntLimparHistorico.Image = ((System.Drawing.Image)(resources.GetObject("BntLimparHistorico.Image")));
            this.BntLimparHistorico.Location = new System.Drawing.Point(0, -35);
            this.BntLimparHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.BntLimparHistorico.Name = "BntLimparHistorico";
            this.BntLimparHistorico.Size = new System.Drawing.Size(350, 40);
            this.BntLimparHistorico.TabIndex = 3;
            this.BntLimparHistorico.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(350, 0);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHistorico);
            this.Controls.Add(this.PnlTitulo);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlHistorico.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Button BntExit;
        private System.Windows.Forms.Panel PnlHistorico;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BntMenu;
        private System.Windows.Forms.Button BntHistorico;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BntLimparHistorico;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

