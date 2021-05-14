
namespace Lab__04
{
    partial class fBike
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLenghth = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasHydraulicSeatPost = new System.Windows.Forms.CheckBox();
            this.chbHasHydraulicBrake = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLenghth);
            this.groupBox1.Controls.Add(this.tbWeight);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.tbBrand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(81, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbLenghth
            // 
            this.tbLenghth.Location = new System.Drawing.Point(290, 344);
            this.tbLenghth.Name = "tbLenghth";
            this.tbLenghth.Size = new System.Drawing.Size(272, 43);
            this.tbLenghth.TabIndex = 11;
            this.tbLenghth.TextChanged += new System.EventHandler(this.tbLenghth_TextChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(290, 284);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(272, 43);
            this.tbWeight.TabIndex = 10;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbWeight_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(290, 223);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(272, 43);
            this.tbPrice.TabIndex = 9;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(290, 165);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(272, 43);
            this.tbRegion.TabIndex = 8;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(290, 109);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(272, 43);
            this.tbCountry.TabIndex = 7;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(290, 54);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(272, 43);
            this.tbBrand.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ціна, грн";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Довжина, См";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вага, Г";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Регіон виробника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва велосипеду";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Країна виробника";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(745, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Enter += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(745, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 51);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasHydraulicSeatPost);
            this.groupBox2.Controls.Add(this.chbHasHydraulicBrake);
            this.groupBox2.Location = new System.Drawing.Point(81, 521);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опції";
            // 
            // chbHasHydraulicSeatPost
            // 
            this.chbHasHydraulicSeatPost.AutoSize = true;
            this.chbHasHydraulicSeatPost.Location = new System.Drawing.Point(26, 105);
            this.chbHasHydraulicSeatPost.Name = "chbHasHydraulicSeatPost";
            this.chbHasHydraulicSeatPost.Size = new System.Drawing.Size(405, 36);
            this.chbHasHydraulicSeatPost.TabIndex = 1;
            this.chbHasHydraulicSeatPost.Text = "Гідравлічний підсидільний штир";
            this.chbHasHydraulicSeatPost.UseVisualStyleBackColor = true;
            this.chbHasHydraulicSeatPost.CheckedChanged += new System.EventHandler(this.chbHasHydraulicSeatPost_CheckedChanged);
            // 
            // chbHasHydraulicBrake
            // 
            this.chbHasHydraulicBrake.AutoSize = true;
            this.chbHasHydraulicBrake.Location = new System.Drawing.Point(26, 63);
            this.chbHasHydraulicBrake.Name = "chbHasHydraulicBrake";
            this.chbHasHydraulicBrake.Size = new System.Drawing.Size(250, 36);
            this.chbHasHydraulicBrake.TabIndex = 0;
            this.chbHasHydraulicBrake.Text = "Гідравлічні гальма";
            this.chbHasHydraulicBrake.UseVisualStyleBackColor = true;
            this.chbHasHydraulicBrake.CheckedChanged += new System.EventHandler(this.chbHasHydraulicBrake_CheckedChanged);
            // 
            // fBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fBike";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий велосипед";
            this.Load += new System.EventHandler(this.fBike_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbHasHydraulicBrake;
        private System.Windows.Forms.TextBox tbLenghth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasHydraulicSeatPost;
    }
}