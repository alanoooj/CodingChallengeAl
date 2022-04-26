
namespace CodingChallenge_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Given_weights = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLeft1 = new System.Windows.Forms.TextBox();
            this.textBoxLeft2 = new System.Windows.Forms.TextBox();
            this.textBoxLeft3 = new System.Windows.Forms.TextBox();
            this.textBoxLeft4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRight4 = new System.Windows.Forms.TextBox();
            this.textBoxRight3 = new System.Windows.Forms.TextBox();
            this.textBoxRight2 = new System.Windows.Forms.TextBox();
            this.textBoxRight1 = new System.Windows.Forms.TextBox();
            this.First_piece = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Second_piece = new System.Windows.Forms.TextBox();
            this.Third_piece = new System.Windows.Forms.TextBox();
            this.Forth_piece = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balkenwaage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abautToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abautToolStripMenuItem
            // 
            this.abautToolStripMenuItem.Name = "abautToolStripMenuItem";
            this.abautToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abautToolStripMenuItem.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "v584.2";
            // 
            // Given_weights
            // 
            this.Given_weights.Location = new System.Drawing.Point(89, 180);
            this.Given_weights.Name = "Given_weights";
            this.Given_weights.Size = new System.Drawing.Size(100, 20);
            this.Given_weights.TabIndex = 3;
            this.Given_weights.TextChanged += new System.EventHandler(this.Given_weights_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geben sie bitte ein beliebiges Gewicht zwischen 1 kg und 40 kg";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxLeft1
            // 
            this.textBoxLeft1.Location = new System.Drawing.Point(273, 272);
            this.textBoxLeft1.Name = "textBoxLeft1";
            this.textBoxLeft1.ReadOnly = true;
            this.textBoxLeft1.Size = new System.Drawing.Size(29, 20);
            this.textBoxLeft1.TabIndex = 5;
            // 
            // textBoxLeft2
            // 
            this.textBoxLeft2.Location = new System.Drawing.Point(329, 272);
            this.textBoxLeft2.Name = "textBoxLeft2";
            this.textBoxLeft2.ReadOnly = true;
            this.textBoxLeft2.Size = new System.Drawing.Size(29, 20);
            this.textBoxLeft2.TabIndex = 6;
            // 
            // textBoxLeft3
            // 
            this.textBoxLeft3.Location = new System.Drawing.Point(385, 272);
            this.textBoxLeft3.Name = "textBoxLeft3";
            this.textBoxLeft3.ReadOnly = true;
            this.textBoxLeft3.Size = new System.Drawing.Size(29, 20);
            this.textBoxLeft3.TabIndex = 7;
            // 
            // textBoxLeft4
            // 
            this.textBoxLeft4.Location = new System.Drawing.Point(441, 272);
            this.textBoxLeft4.Name = "textBoxLeft4";
            this.textBoxLeft4.ReadOnly = true;
            this.textBoxLeft4.Size = new System.Drawing.Size(29, 20);
            this.textBoxLeft4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "+";
            // 
            // textBoxRight4
            // 
            this.textBoxRight4.Location = new System.Drawing.Point(688, 272);
            this.textBoxRight4.Name = "textBoxRight4";
            this.textBoxRight4.ReadOnly = true;
            this.textBoxRight4.Size = new System.Drawing.Size(29, 20);
            this.textBoxRight4.TabIndex = 19;
            // 
            // textBoxRight3
            // 
            this.textBoxRight3.Location = new System.Drawing.Point(632, 272);
            this.textBoxRight3.Name = "textBoxRight3";
            this.textBoxRight3.ReadOnly = true;
            this.textBoxRight3.Size = new System.Drawing.Size(29, 20);
            this.textBoxRight3.TabIndex = 18;
            // 
            // textBoxRight2
            // 
            this.textBoxRight2.Location = new System.Drawing.Point(576, 272);
            this.textBoxRight2.Name = "textBoxRight2";
            this.textBoxRight2.ReadOnly = true;
            this.textBoxRight2.Size = new System.Drawing.Size(29, 20);
            this.textBoxRight2.TabIndex = 17;
            // 
            // textBoxRight1
            // 
            this.textBoxRight1.Location = new System.Drawing.Point(520, 272);
            this.textBoxRight1.Name = "textBoxRight1";
            this.textBoxRight1.ReadOnly = true;
            this.textBoxRight1.Size = new System.Drawing.Size(29, 20);
            this.textBoxRight1.TabIndex = 16;
            // 
            // First_piece
            // 
            this.First_piece.Location = new System.Drawing.Point(64, 257);
            this.First_piece.Name = "First_piece";
            this.First_piece.ReadOnly = true;
            this.First_piece.Size = new System.Drawing.Size(48, 20);
            this.First_piece.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "benutzt Gewicht sind";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Second_piece
            // 
            this.Second_piece.Location = new System.Drawing.Point(118, 257);
            this.Second_piece.Name = "Second_piece";
            this.Second_piece.ReadOnly = true;
            this.Second_piece.Size = new System.Drawing.Size(48, 20);
            this.Second_piece.TabIndex = 25;
            // 
            // Third_piece
            // 
            this.Third_piece.Location = new System.Drawing.Point(172, 257);
            this.Third_piece.Name = "Third_piece";
            this.Third_piece.ReadOnly = true;
            this.Third_piece.Size = new System.Drawing.Size(48, 20);
            this.Third_piece.TabIndex = 26;
            // 
            // Forth_piece
            // 
            this.Forth_piece.Location = new System.Drawing.Point(118, 283);
            this.Forth_piece.Name = "Forth_piece";
            this.Forth_piece.ReadOnly = true;
            this.Forth_piece.Size = new System.Drawing.Size(48, 20);
            this.Forth_piece.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Forth_piece);
            this.Controls.Add(this.Third_piece);
            this.Controls.Add(this.Second_piece);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.First_piece);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRight4);
            this.Controls.Add(this.textBoxRight3);
            this.Controls.Add(this.textBoxRight2);
            this.Controls.Add(this.textBoxRight1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLeft4);
            this.Controls.Add(this.textBoxLeft3);
            this.Controls.Add(this.textBoxLeft2);
            this.Controls.Add(this.textBoxLeft1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Given_weights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Balkenwaage.v584.2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abautToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Given_weights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLeft1;
        private System.Windows.Forms.TextBox textBoxLeft2;
        private System.Windows.Forms.TextBox textBoxLeft3;
        private System.Windows.Forms.TextBox textBoxLeft4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRight4;
        private System.Windows.Forms.TextBox textBoxRight3;
        private System.Windows.Forms.TextBox textBoxRight2;
        private System.Windows.Forms.TextBox textBoxRight1;
        private System.Windows.Forms.TextBox First_piece;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Second_piece;
        private System.Windows.Forms.TextBox Third_piece;
        private System.Windows.Forms.TextBox Forth_piece;
    }
}

