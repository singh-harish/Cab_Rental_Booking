namespace Car_Rental_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentACar = new System.Windows.Forms.Button();
            this.carsDatabase = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Button();
            this.changeUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Val";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "#val";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Control Level:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(526, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 50);
            this.button9.TabIndex = 10;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.rentACar);
            this.panel1.Controls.Add(this.carsDatabase);
            this.panel1.Controls.Add(this.adminPanel);
            this.panel1.Controls.Add(this.changeUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 458);
            this.panel1.TabIndex = 11;
            // 
            // rentACar
            // 
            this.rentACar.FlatAppearance.BorderSize = 0;
            this.rentACar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentACar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentACar.ForeColor = System.Drawing.Color.White;
            this.rentACar.Image = ((System.Drawing.Image)(resources.GetObject("rentACar.Image")));
            this.rentACar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentACar.Location = new System.Drawing.Point(0, 55);
            this.rentACar.Name = "rentACar";
            this.rentACar.Size = new System.Drawing.Size(207, 88);
            this.rentACar.TabIndex = 12;
            this.rentACar.Text = "  Rent a Car";
            this.rentACar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentACar.UseVisualStyleBackColor = true;
            this.rentACar.Click += new System.EventHandler(this.rentACar_Click);
            // 
            // carsDatabase
            // 
            this.carsDatabase.FlatAppearance.BorderSize = 0;
            this.carsDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsDatabase.ForeColor = System.Drawing.Color.White;
            this.carsDatabase.Image = ((System.Drawing.Image)(resources.GetObject("carsDatabase.Image")));
            this.carsDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsDatabase.Location = new System.Drawing.Point(0, 149);
            this.carsDatabase.Name = "carsDatabase";
            this.carsDatabase.Size = new System.Drawing.Size(201, 73);
            this.carsDatabase.TabIndex = 13;
            this.carsDatabase.Text = "  Car\'s Database";
            this.carsDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.carsDatabase.UseVisualStyleBackColor = true;
            this.carsDatabase.Click += new System.EventHandler(this.carsDatabase_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Enabled = false;
            this.adminPanel.FlatAppearance.BorderSize = 0;
            this.adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanel.ForeColor = System.Drawing.Color.White;
            this.adminPanel.Image = ((System.Drawing.Image)(resources.GetObject("adminPanel.Image")));
            this.adminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPanel.Location = new System.Drawing.Point(0, 228);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(207, 77);
            this.adminPanel.TabIndex = 14;
            this.adminPanel.Text = "  Admin Panel";
            this.adminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminPanel.UseVisualStyleBackColor = true;
            this.adminPanel.Click += new System.EventHandler(this.adminPanel_Click);
            // 
            // changeUser
            // 
            this.changeUser.FlatAppearance.BorderSize = 0;
            this.changeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUser.ForeColor = System.Drawing.Color.White;
            this.changeUser.Image = ((System.Drawing.Image)(resources.GetObject("changeUser.Image")));
            this.changeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeUser.Location = new System.Drawing.Point(0, 311);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(201, 81);
            this.changeUser.TabIndex = 15;
            this.changeUser.Text = "  Change User";
            this.changeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeUser.UseVisualStyleBackColor = true;
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(626, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button rentACar;
        internal System.Windows.Forms.Button carsDatabase;
        internal System.Windows.Forms.Button adminPanel;
        internal System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}