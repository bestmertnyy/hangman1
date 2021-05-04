
namespace shybenytsia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.classbutton3 = new shybenytsia.Classbutton();
            this.classbutton2 = new shybenytsia.Classbutton();
            this.classbutton1 = new shybenytsia.Classbutton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(633, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 4;
            // 
            // classbutton3
            // 
            this.classbutton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classbutton3.BackColor = System.Drawing.Color.Gray;
            this.classbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classbutton3.ForeColor = System.Drawing.Color.White;
            this.classbutton3.Location = new System.Drawing.Point(632, 68);
            this.classbutton3.Name = "classbutton3";
            this.classbutton3.RoundingEnable = true;
            this.classbutton3.Size = new System.Drawing.Size(204, 59);
            this.classbutton3.TabIndex = 9;
            this.classbutton3.Text = "Додати гравця";
            this.classbutton3.TextHover = null;
            this.classbutton3.Click += new System.EventHandler(this.classbutton3_Click);
            // 
            // classbutton2
            // 
            this.classbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.classbutton2.BackColor = System.Drawing.Color.Gray;
            this.classbutton2.Enabled = false;
            this.classbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classbutton2.ForeColor = System.Drawing.Color.White;
            this.classbutton2.Location = new System.Drawing.Point(633, 391);
            this.classbutton2.Name = "classbutton2";
            this.classbutton2.RoundingEnable = true;
            this.classbutton2.Size = new System.Drawing.Size(204, 59);
            this.classbutton2.TabIndex = 8;
            this.classbutton2.Text = "Грати";
            this.classbutton2.TextHover = null;
            this.classbutton2.Click += new System.EventHandler(this.classbutton2_Click);
            // 
            // classbutton1
            // 
            this.classbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.classbutton1.BackColor = System.Drawing.Color.Gray;
            this.classbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classbutton1.ForeColor = System.Drawing.Color.White;
            this.classbutton1.Location = new System.Drawing.Point(39, 391);
            this.classbutton1.Name = "classbutton1";
            this.classbutton1.RoundingEnable = true;
            this.classbutton1.Size = new System.Drawing.Size(204, 59);
            this.classbutton1.TabIndex = 7;
            this.classbutton1.Text = "На головну";
            this.classbutton1.TextHover = null;
            this.classbutton1.Click += new System.EventHandler(this.classbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 293);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.classbutton3);
            this.Controls.Add(this.classbutton2);
            this.Controls.Add(this.classbutton1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Шибениця";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private Classbutton classbutton1;
        private Classbutton classbutton2;
        private Classbutton classbutton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}