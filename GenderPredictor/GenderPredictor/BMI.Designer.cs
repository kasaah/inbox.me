namespace GenderPredictor
{
    partial class BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bmi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblMESSAGE = new System.Windows.Forms.Label();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(86, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body Mass Index";
            // 
            // btn_back1
            // 
            this.btn_back1.BackColor = System.Drawing.Color.Transparent;
            this.btn_back1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back1.BackgroundImage")));
            this.btn_back1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back1.FlatAppearance.BorderSize = 0;
            this.btn_back1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back1.Location = new System.Drawing.Point(292, 476);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(81, 29);
            this.btn_back1.TabIndex = 11;
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1.Location = new System.Drawing.Point(251, 93);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 26);
            this.txt1.TabIndex = 14;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.SystemColors.Window;
            this.txt2.Location = new System.Drawing.Point(251, 56);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 26);
            this.txt2.TabIndex = 15;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Weight(kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter Height(meters)";
            // 
            // btn_bmi
            // 
            this.btn_bmi.BackColor = System.Drawing.Color.Transparent;
            this.btn_bmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bmi.BackgroundImage")));
            this.btn_bmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bmi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bmi.FlatAppearance.BorderSize = 0;
            this.btn_bmi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bmi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bmi.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bmi.Location = new System.Drawing.Point(273, 136);
            this.btn_bmi.Name = "btn_bmi";
            this.btn_bmi.Size = new System.Drawing.Size(100, 41);
            this.btn_bmi.TabIndex = 18;
            this.btn_bmi.UseVisualStyleBackColor = false;
            this.btn_bmi.Click += new System.EventHandler(this.btn_bmi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(159, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 78);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Result";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.White;
            this.lblBMI.Location = new System.Drawing.Point(168, 214);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 13);
            this.lblBMI.TabIndex = 21;
            // 
            // lblMESSAGE
            // 
            this.lblMESSAGE.AutoSize = true;
            this.lblMESSAGE.BackColor = System.Drawing.Color.White;
            this.lblMESSAGE.Location = new System.Drawing.Point(168, 243);
            this.lblMESSAGE.Name = "lblMESSAGE";
            this.lblMESSAGE.Size = new System.Drawing.Size(0, 13);
            this.lblMESSAGE.TabIndex = 22;
            // 
            // rtxt
            // 
            this.rtxt.BackColor = System.Drawing.Color.LightCyan;
            this.rtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt.ForeColor = System.Drawing.Color.Black;
            this.rtxt.Location = new System.Drawing.Point(48, 295);
            this.rtxt.Name = "rtxt";
            this.rtxt.ReadOnly = true;
            this.rtxt.Size = new System.Drawing.Size(325, 155);
            this.rtxt.TabIndex = 23;
            this.rtxt.Text = "";
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Transparent;
            this.resetbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetbtn.BackgroundImage")));
            this.resetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbtn.FlatAppearance.BorderSize = 0;
            this.resetbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Location = new System.Drawing.Point(159, 476);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 29);
            this.resetbtn.TabIndex = 24;
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tips";
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.lblMESSAGE);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bmi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblMESSAGE;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label label5;
    }
}