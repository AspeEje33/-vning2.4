namespace övning2._4
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
            this.skapa = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.btnLinje = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnArea = new System.Windows.Forms.Button();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxFigur = new System.Windows.Forms.ListBox();
            this.skapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // skapa
            // 
            this.skapa.Controls.Add(this.label2);
            this.skapa.Controls.Add(this.tbxHöjd);
            this.skapa.Controls.Add(this.label1);
            this.skapa.Controls.Add(this.tbxBredd);
            this.skapa.Controls.Add(this.btnLinje);
            this.skapa.Controls.Add(this.btnCirkel);
            this.skapa.Controls.Add(this.btnTriangel);
            this.skapa.Location = new System.Drawing.Point(33, 22);
            this.skapa.Name = "skapa";
            this.skapa.Size = new System.Drawing.Size(276, 349);
            this.skapa.TabIndex = 0;
            this.skapa.TabStop = false;
            this.skapa.Text = "Skapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Höjd";
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(61, 84);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 26);
            this.tbxHöjd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bredd";
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(61, 37);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(100, 26);
            this.tbxBredd.TabIndex = 5;
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(6, 243);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(155, 32);
            this.btnLinje.TabIndex = 3;
            this.btnLinje.Text = "Skapa Linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.btnLinje_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(6, 197);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(155, 30);
            this.btnCirkel.TabIndex = 2;
            this.btnCirkel.Text = "Skapa Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(6, 141);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(155, 33);
            this.btnTriangel.TabIndex = 1;
            this.btnTriangel.Text = "Skapa Triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.btnTriangel_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(58, 389);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(126, 49);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Sammanlagd Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(508, 387);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(143, 26);
            this.tbxArea.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Figurlista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sammanlagd Area";
            // 
            // lbxFigur
            // 
            this.lbxFigur.FormattingEnabled = true;
            this.lbxFigur.ItemHeight = 20;
            this.lbxFigur.Location = new System.Drawing.Point(508, 79);
            this.lbxFigur.Name = "lbxFigur";
            this.lbxFigur.Size = new System.Drawing.Size(234, 264);
            this.lbxFigur.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxFigur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.skapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.skapa.ResumeLayout(false);
            this.skapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox skapa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxFigur;
    }
}

