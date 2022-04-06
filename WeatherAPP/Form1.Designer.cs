
namespace WeatherAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPessure = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2MinimumTem = new System.Windows.Forms.Label();
            this.lbl3MaximumTem = new System.Windows.Forms.Label();
            this.lbl4MinTem = new System.Windows.Forms.Label();
            this.lbl5MaxTem = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(268, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPessure
            // 
            this.lblPessure.AutoSize = true;
            this.lblPessure.BackColor = System.Drawing.Color.Transparent;
            this.lblPessure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessure.ForeColor = System.Drawing.Color.White;
            this.lblPessure.Location = new System.Drawing.Point(418, 211);
            this.lblPessure.Name = "lblPessure";
            this.lblPessure.Size = new System.Drawing.Size(42, 24);
            this.lblPessure.TabIndex = 6;
            this.lblPessure.Text = "N/A";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.Color.White;
            this.lblWind.Location = new System.Drawing.Point(446, 169);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(42, 24);
            this.lblWind.TabIndex = 7;
            this.lblWind.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(327, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pressure:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(327, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Wind Speed:";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.BackColor = System.Drawing.Color.Transparent;
            this.lblSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.Color.White;
            this.lblSunset.Location = new System.Drawing.Point(88, 292);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(42, 24);
            this.lblSunset.TabIndex = 10;
            this.lblSunset.Text = "N/A";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lblSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.Color.White;
            this.lblSunrise.Location = new System.Drawing.Point(88, 253);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(42, 24);
            this.lblSunrise.TabIndex = 11;
            this.lblSunrise.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sunset";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sunrise";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(13, 202);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(65, 24);
            this.lblDetails.TabIndex = 14;
            this.lblDetails.Text = "Details";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.White;
            this.lblCondition.Location = new System.Drawing.Point(12, 169);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(90, 24);
            this.lblCondition.TabIndex = 15;
            this.lblCondition.Text = "Condition";
            this.lblCondition.Click += new System.EventHandler(this.lblCondition_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 75);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2MinimumTem
            // 
            this.lbl2MinimumTem.AutoSize = true;
            this.lbl2MinimumTem.BackColor = System.Drawing.Color.Transparent;
            this.lbl2MinimumTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2MinimumTem.ForeColor = System.Drawing.Color.White;
            this.lbl2MinimumTem.Location = new System.Drawing.Point(579, 169);
            this.lbl2MinimumTem.Name = "lbl2MinimumTem";
            this.lbl2MinimumTem.Size = new System.Drawing.Size(137, 24);
            this.lbl2MinimumTem.TabIndex = 17;
            this.lbl2MinimumTem.Text = "Minimum Tem:";
            this.lbl2MinimumTem.Click += new System.EventHandler(this.lbl2MinimumTem_Click);
            // 
            // lbl3MaximumTem
            // 
            this.lbl3MaximumTem.AutoSize = true;
            this.lbl3MaximumTem.BackColor = System.Drawing.Color.Transparent;
            this.lbl3MaximumTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3MaximumTem.ForeColor = System.Drawing.Color.White;
            this.lbl3MaximumTem.Location = new System.Drawing.Point(580, 219);
            this.lbl3MaximumTem.Name = "lbl3MaximumTem";
            this.lbl3MaximumTem.Size = new System.Drawing.Size(142, 24);
            this.lbl3MaximumTem.TabIndex = 18;
            this.lbl3MaximumTem.Text = "Maximum Tem:";
            this.lbl3MaximumTem.Click += new System.EventHandler(this.lbl3MaximumTem_Click);
            // 
            // lbl4MinTem
            // 
            this.lbl4MinTem.AutoSize = true;
            this.lbl4MinTem.BackColor = System.Drawing.Color.Transparent;
            this.lbl4MinTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4MinTem.ForeColor = System.Drawing.Color.White;
            this.lbl4MinTem.Location = new System.Drawing.Point(722, 169);
            this.lbl4MinTem.Name = "lbl4MinTem";
            this.lbl4MinTem.Size = new System.Drawing.Size(42, 24);
            this.lbl4MinTem.TabIndex = 19;
            this.lbl4MinTem.Text = "N/A";
            this.lbl4MinTem.Click += new System.EventHandler(this.lbl4MinTem_Click);
            // 
            // lbl5MaxTem
            // 
            this.lbl5MaxTem.AutoSize = true;
            this.lbl5MaxTem.BackColor = System.Drawing.Color.Transparent;
            this.lbl5MaxTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5MaxTem.ForeColor = System.Drawing.Color.White;
            this.lbl5MaxTem.Location = new System.Drawing.Point(728, 219);
            this.lbl5MaxTem.Name = "lbl5MaxTem";
            this.lbl5MaxTem.Size = new System.Drawing.Size(42, 24);
            this.lbl5MaxTem.TabIndex = 20;
            this.lbl5MaxTem.Text = "N/A";
            this.lbl5MaxTem.Click += new System.EventHandler(this.lbl5MaxTem_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.MistyRose;
            this.lblTemp.Location = new System.Drawing.Point(172, 100);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(51, 55);
            this.lblTemp.TabIndex = 28;
            this.lblTemp.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 521);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lbl5MaxTem);
            this.Controls.Add(this.lbl4MinTem);
            this.Controls.Add(this.lbl3MaximumTem);
            this.Controls.Add(this.lbl2MinimumTem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblPessure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPessure;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2MinimumTem;
        private System.Windows.Forms.Label lbl3MaximumTem;
        private System.Windows.Forms.Label lbl4MinTem;
        private System.Windows.Forms.Label lbl5MaxTem;
        private System.Windows.Forms.Label lblTemp;
    }
}

