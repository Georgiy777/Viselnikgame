﻿//<copyright file="Form5.Designer.cs" company="OmGTU"> 
//Copyright (c) OmGTU. All rights reserved.
//</copyright> 
//<author>
//Kalita Aleksandr, Valyn Ivan, Loshchinina Tatyana
//</author> 
namespace OmGTU.Advance.Profit.Loyal.ViselnikGame
{
    /// <summary>
    /// Copy of a class of the form.
    /// </summary>
    partial class Form5
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::ViselnikGame.Properties.Resources.buttonBack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 76);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ViselnikGame.Properties.Resources.Gf60xc4hVzU;
            this.ClientSize = new System.Drawing.Size(1292, 732);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HANGED MAN";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button back
        /// </summary>
        private System.Windows.Forms.Button button1;
    }
}