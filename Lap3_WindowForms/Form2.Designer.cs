namespace Lap3_WindowForms
{
    partial class Form2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.rdBtnLN = new System.Windows.Forms.RadioButton();
            this.rsBtnNN = new System.Windows.Forms.RadioButton();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumber2);
            this.groupBox1.Controls.Add(this.txtNumber1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rsBtnNN);
            this.groupBox2.Controls.Add(this.rdBtnLN);
            this.groupBox2.Location = new System.Drawing.Point(506, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btClose);
            this.groupBox3.Controls.Add(this.btBoqua);
            this.groupBox3.Controls.Add(this.btTim);
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Location = new System.Drawing.Point(25, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "B :";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(158, 41);
            this.txtNumber1.Multiline = true;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(259, 35);
            this.txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(158, 97);
            this.txtNumber2.Multiline = true;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(259, 35);
            this.txtNumber2.TabIndex = 3;
            // 
            // rdBtnLN
            // 
            this.rdBtnLN.AutoSize = true;
            this.rdBtnLN.Location = new System.Drawing.Point(32, 39);
            this.rdBtnLN.Name = "rdBtnLN";
            this.rdBtnLN.Size = new System.Drawing.Size(73, 20);
            this.rdBtnLN.TabIndex = 0;
            this.rdBtnLN.TabStop = true;
            this.rdBtnLN.Text = "USCLN";
            this.rdBtnLN.UseVisualStyleBackColor = true;
            // 
            // rsBtnNN
            // 
            this.rsBtnNN.AutoSize = true;
            this.rsBtnNN.Location = new System.Drawing.Point(32, 97);
            this.rsBtnNN.Name = "rsBtnNN";
            this.rsBtnNN.Size = new System.Drawing.Size(76, 20);
            this.rsBtnNN.TabIndex = 1;
            this.rsBtnNN.TabStop = true;
            this.rsBtnNN.Text = "USCNN";
            this.rsBtnNN.UseVisualStyleBackColor = true;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(159, 46);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(259, 35);
            this.txtKetqua.TabIndex = 4;
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(159, 131);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(109, 37);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoqua.Location = new System.Drawing.Point(309, 131);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(109, 37);
            this.btBoqua.TabIndex = 6;
            this.btBoqua.Text = "Bỏ Qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(513, 131);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(109, 37);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rsBtnNN;
        private System.Windows.Forms.RadioButton rdBtnLN;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}