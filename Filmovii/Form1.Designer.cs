namespace Filmovii
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstOne = new System.Windows.Forms.ListBox();
            this.lstTwo = new System.Windows.Forms.ListBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.btnUnesiOne = new System.Windows.Forms.Button();
            this.btnUnesiTwo = new System.Windows.Forms.Button();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.btnBrisiOne = new System.Windows.Forms.Button();
            this.btnBrisiTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoose.Location = new System.Drawing.Point(205, 360);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(170, 61);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "IZABERI";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrikaz.Location = new System.Drawing.Point(235, 281);
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(299, 31);
            this.txtPrikaz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IZABRANI FILM:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstOne
            // 
            this.lstOne.FormattingEnabled = true;
            this.lstOne.Location = new System.Drawing.Point(12, 12);
            this.lstOne.Name = "lstOne";
            this.lstOne.Size = new System.Drawing.Size(229, 95);
            this.lstOne.TabIndex = 4;
            // 
            // lstTwo
            // 
            this.lstTwo.FormattingEnabled = true;
            this.lstTwo.Location = new System.Drawing.Point(373, 12);
            this.lstTwo.Name = "lstTwo";
            this.lstTwo.Size = new System.Drawing.Size(229, 95);
            this.lstTwo.TabIndex = 5;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(12, 134);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(229, 20);
            this.txtOne.TabIndex = 6;
            // 
            // btnUnesiOne
            // 
            this.btnUnesiOne.Location = new System.Drawing.Point(12, 160);
            this.btnUnesiOne.Name = "btnUnesiOne";
            this.btnUnesiOne.Size = new System.Drawing.Size(78, 34);
            this.btnUnesiOne.TabIndex = 7;
            this.btnUnesiOne.Text = "Unesi";
            this.btnUnesiOne.UseVisualStyleBackColor = true;
            this.btnUnesiOne.Click += new System.EventHandler(this.btnUnesiOne_Click);
            // 
            // btnUnesiTwo
            // 
            this.btnUnesiTwo.Location = new System.Drawing.Point(373, 160);
            this.btnUnesiTwo.Name = "btnUnesiTwo";
            this.btnUnesiTwo.Size = new System.Drawing.Size(78, 34);
            this.btnUnesiTwo.TabIndex = 9;
            this.btnUnesiTwo.Text = "Unesi";
            this.btnUnesiTwo.UseVisualStyleBackColor = true;
            this.btnUnesiTwo.Click += new System.EventHandler(this.btnUnesiTwo_Click);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(373, 134);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(229, 20);
            this.txtTwo.TabIndex = 8;
            // 
            // btnBrisiOne
            // 
            this.btnBrisiOne.Location = new System.Drawing.Point(163, 160);
            this.btnBrisiOne.Name = "btnBrisiOne";
            this.btnBrisiOne.Size = new System.Drawing.Size(78, 34);
            this.btnBrisiOne.TabIndex = 10;
            this.btnBrisiOne.Text = "Ukloni";
            this.btnBrisiOne.UseVisualStyleBackColor = true;
            this.btnBrisiOne.Click += new System.EventHandler(this.btnBrisiOne_Click);
            // 
            // btnBrisiTwo
            // 
            this.btnBrisiTwo.Location = new System.Drawing.Point(524, 160);
            this.btnBrisiTwo.Name = "btnBrisiTwo";
            this.btnBrisiTwo.Size = new System.Drawing.Size(78, 34);
            this.btnBrisiTwo.TabIndex = 11;
            this.btnBrisiTwo.Text = "Ukloni";
            this.btnBrisiTwo.UseVisualStyleBackColor = true;
            this.btnBrisiTwo.Click += new System.EventHandler(this.btnBrisiTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 545);
            this.Controls.Add(this.btnBrisiTwo);
            this.Controls.Add(this.btnBrisiOne);
            this.Controls.Add(this.btnUnesiTwo);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.btnUnesiOne);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lstTwo);
            this.Controls.Add(this.lstOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.btnChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstOne;
        private System.Windows.Forms.ListBox lstTwo;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Button btnUnesiOne;
        private System.Windows.Forms.Button btnUnesiTwo;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Button btnBrisiOne;
        private System.Windows.Forms.Button btnBrisiTwo;
    }
}

