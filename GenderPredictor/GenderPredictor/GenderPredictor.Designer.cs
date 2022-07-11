namespace GenderPredictor
{
    partial class GenderPredictor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenderPredictor));
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gender Predictor";
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.CausesValidation = false;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.Location = new System.Drawing.Point(215, 324);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 29);
            this.btn3.TabIndex = 5;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // cmb1
            // 
            this.cmb1.BackColor = System.Drawing.Color.Cyan;
            this.cmb1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1.ForeColor = System.Drawing.Color.Black;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.cmb1.Location = new System.Drawing.Point(8, 74);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(141, 25);
            this.cmb1.TabIndex = 6;
            // 
            // cmb2
            // 
            this.cmb2.BackColor = System.Drawing.Color.Cyan;
            this.cmb2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2.ForeColor = System.Drawing.Color.Black;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb2.Location = new System.Drawing.Point(8, 142);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(141, 25);
            this.cmb2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select mother\'s lunar age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select mother\'s lunar pregnant month";
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
            this.btn_back1.Location = new System.Drawing.Point(375, 324);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(81, 29);
            this.btn_back1.TabIndex = 10;
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.BackColor = System.Drawing.Color.Transparent;
            this.rbt1.FlatAppearance.BorderSize = 0;
            this.rbt1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rbt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1.Location = new System.Drawing.Point(8, 185);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(388, 23);
            this.rbt1.TabIndex = 12;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Have you taken any fertility drug (e.g Clomid) before?";
            this.rbt1.UseVisualStyleBackColor = false;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.BackColor = System.Drawing.Color.Transparent;
            this.rbt2.FlatAppearance.BorderSize = 0;
            this.rbt2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbt2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rbt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt2.Location = new System.Drawing.Point(8, 226);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(417, 23);
            this.rbt2.TabIndex = 13;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Are you exposed to farming chemicals (e.g dioxin, DBCP)?";
            this.rbt2.UseVisualStyleBackColor = false;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.BackColor = System.Drawing.Color.Transparent;
            this.rbt3.FlatAppearance.BorderSize = 0;
            this.rbt3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbt3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbt3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rbt3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3.Location = new System.Drawing.Point(8, 267);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(519, 23);
            this.rbt3.TabIndex = 14;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Have you been hospitalised for severe hyperemesis gravidarum (nuasea)?";
            this.rbt3.UseVisualStyleBackColor = false;
            // 
            // GenderPredictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 371);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenderPredictor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenderPredictor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt3;
    }
}