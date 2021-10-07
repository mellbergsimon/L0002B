
namespace Uppgift1_Simmel_9 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.PricetoPay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeCalc = new System.Windows.Forms.Button();
            this.PricePayed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PricetoPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePayed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // PricetoPay
            // 
            this.PricetoPay.Location = new System.Drawing.Point(73, 22);
            this.PricetoPay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PricetoPay.Name = "PricetoPay";
            this.PricetoPay.Size = new System.Drawing.Size(110, 20);
            this.PricetoPay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betalt:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(262, 22);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultBox.Size = new System.Drawing.Size(115, 115);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pris:";
            // 
            // ChangeCalc
            // 
            this.ChangeCalc.Location = new System.Drawing.Point(73, 114);
            this.ChangeCalc.Name = "ChangeCalc";
            this.ChangeCalc.Size = new System.Drawing.Size(110, 23);
            this.ChangeCalc.TabIndex = 9;
            this.ChangeCalc.Text = "Beräkna växel";
            this.ChangeCalc.UseVisualStyleBackColor = true;
            this.ChangeCalc.Click += new System.EventHandler(this.ChangeCalc_Click);
            // 
            // PricePayed
            // 
            this.PricePayed.Location = new System.Drawing.Point(74, 73);
            this.PricePayed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PricePayed.Name = "PricePayed";
            this.PricePayed.Size = new System.Drawing.Size(109, 20);
            this.PricePayed.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 166);
            this.Controls.Add(this.PricePayed);
            this.Controls.Add(this.ChangeCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PricetoPay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Växelberäknare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PricetoPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePayed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PricetoPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeCalc;
        private System.Windows.Forms.NumericUpDown PricePayed;
    }
}

