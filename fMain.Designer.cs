
namespace Lab__04
{
    partial class fMain
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
            this.tbBikeInfo = new System.Windows.Forms.TextBox();
            this.btnAddBike = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBikeInfo
            // 
            this.tbBikeInfo.Location = new System.Drawing.Point(52, 74);
            this.tbBikeInfo.Multiline = true;
            this.tbBikeInfo.Name = "tbBikeInfo";
            this.tbBikeInfo.ReadOnly = true;
            this.tbBikeInfo.Size = new System.Drawing.Size(1219, 371);
            this.tbBikeInfo.TabIndex = 0;
            // 
            // btnAddBike
            // 
            this.btnAddBike.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddBike.Location = new System.Drawing.Point(1311, 74);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(235, 61);
            this.btnAddBike.TabIndex = 1;
            this.btnAddBike.Text = "Додати велосипед";
            this.btnAddBike.UseVisualStyleBackColor = false;
            this.btnAddBike.Click += new System.EventHandler(this.btnAddBike_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(1311, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 61);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 505);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddBike);
            this.Controls.Add(this.tbBikeInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBikeInfo;
        private System.Windows.Forms.Button btnAddBike;
        private System.Windows.Forms.Button btnClose;
    }
}

