﻿
namespace TrabalhoNilton
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
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.txtTer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Segunda";
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(12, 29);
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(100, 20);
            this.txtSeg.TabIndex = 1;
            this.txtSeg.Text = "0";
            // 
            // txtTer
            // 
            this.txtTer.Location = new System.Drawing.Point(162, 29);
            this.txtTer.Name = "txtTer";
            this.txtTer.Size = new System.Drawing.Size(100, 20);
            this.txtTer.TabIndex = 3;
            this.txtTer.Text = "0";
            this.txtTer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terça";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQua
            // 
            this.txtQua.Location = new System.Drawing.Point(312, 29);
            this.txtQua.Name = "txtQua";
            this.txtQua.Size = new System.Drawing.Size(100, 20);
            this.txtQua.TabIndex = 5;
            this.txtQua.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quarta";
            // 
            // txtQui
            // 
            this.txtQui.Location = new System.Drawing.Point(462, 29);
            this.txtQui.Name = "txtQui";
            this.txtQui.Size = new System.Drawing.Size(100, 20);
            this.txtQui.TabIndex = 7;
            this.txtQui.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quinta";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(611, 29);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 9;
            this.txtSex.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexta";
            // 
            // BtnMedia
            // 
            this.BtnMedia.Location = new System.Drawing.Point(745, 26);
            this.BtnMedia.Name = "BtnMedia";
            this.BtnMedia.Size = new System.Drawing.Size(75, 23);
            this.BtnMedia.TabIndex = 10;
            this.BtnMedia.Text = "btnMedia";
            this.BtnMedia.UseVisualStyleBackColor = true;
            this.BtnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 239);
            this.Controls.Add(this.BtnMedia);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Media do Dólar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.TextBox txtTer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnMedia;
    }
}

