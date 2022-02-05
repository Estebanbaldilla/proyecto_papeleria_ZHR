namespace Prueba
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_tipo3 = new System.Windows.Forms.CheckBox();
            this.check_tipo2 = new System.Windows.Forms.CheckBox();
            this.check_tipo1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(207)))), ((int)(((byte)(136)))));
            this.button1.Location = new System.Drawing.Point(342, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(342, 210);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(137, 21);
            this.txtnombre.TabIndex = 2;
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.Location = new System.Drawing.Point(342, 266);
            this.txtcontra.Multiline = true;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(137, 22);
            this.txtcontra.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // check_tipo3
            // 
            this.check_tipo3.AutoSize = true;
            this.check_tipo3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_tipo3.Location = new System.Drawing.Point(315, 173);
            this.check_tipo3.Name = "check_tipo3";
            this.check_tipo3.Size = new System.Drawing.Size(73, 17);
            this.check_tipo3.TabIndex = 7;
            this.check_tipo3.Text = "Empleado";
            this.check_tipo3.UseVisualStyleBackColor = false;
            this.check_tipo3.CheckedChanged += new System.EventHandler(this.check_tipo3_CheckedChanged);
            // 
            // check_tipo2
            // 
            this.check_tipo2.AutoSize = true;
            this.check_tipo2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.check_tipo2.Location = new System.Drawing.Point(384, 173);
            this.check_tipo2.Name = "check_tipo2";
            this.check_tipo2.Size = new System.Drawing.Size(64, 17);
            this.check_tipo2.TabIndex = 8;
            this.check_tipo2.Text = "Gerente";
            this.check_tipo2.UseVisualStyleBackColor = false;
            this.check_tipo2.CheckedChanged += new System.EventHandler(this.check_tipo2_CheckedChanged);
            // 
            // check_tipo1
            // 
            this.check_tipo1.AutoSize = true;
            this.check_tipo1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.check_tipo1.Location = new System.Drawing.Point(444, 173);
            this.check_tipo1.Name = "check_tipo1";
            this.check_tipo1.Size = new System.Drawing.Size(82, 17);
            this.check_tipo1.TabIndex = 9;
            this.check_tipo1.Text = "Control total";
            this.check_tipo1.UseVisualStyleBackColor = false;
            this.check_tipo1.CheckedChanged += new System.EventHandler(this.check_tipo1_CheckedChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.check_tipo1);
            this.Controls.Add(this.check_tipo2);
            this.Controls.Add(this.check_tipo3);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Papeleria zaherir";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox check_tipo3;
        private System.Windows.Forms.CheckBox check_tipo2;
        private System.Windows.Forms.CheckBox check_tipo1;
    }
}