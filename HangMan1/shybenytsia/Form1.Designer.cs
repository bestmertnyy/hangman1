
namespace shybenytsia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.classbutton1 = new shybenytsia.Classbutton();
            this.classbutton2 = new shybenytsia.Classbutton();
            this.SuspendLayout();
            // 
            // classbutton1
            // 
            this.classbutton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.classbutton1.BackColor = System.Drawing.Color.Gray;
            this.classbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classbutton1.ForeColor = System.Drawing.Color.White;
            this.classbutton1.Location = new System.Drawing.Point(281, 359);
            this.classbutton1.Name = "classbutton1";
            this.classbutton1.RoundingEnable = true;
            this.classbutton1.Size = new System.Drawing.Size(273, 61);
            this.classbutton1.TabIndex = 3;
            this.classbutton1.Text = "Грати";
            this.classbutton1.TextHover = null;
            this.classbutton1.Click += new System.EventHandler(this.classbutton1_Click);
            // 
            // classbutton2
            // 
            this.classbutton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.classbutton2.BackColor = System.Drawing.Color.Gray;
            this.classbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classbutton2.ForeColor = System.Drawing.Color.White;
            this.classbutton2.Location = new System.Drawing.Point(695, 425);
            this.classbutton2.Name = "classbutton2";
            this.classbutton2.RoundingEnable = true;
            this.classbutton2.Size = new System.Drawing.Size(34, 30);
            this.classbutton2.TabIndex = 4;
            this.classbutton2.Text = "?";
            this.classbutton2.TextHover = null;
            this.classbutton2.Click += new System.EventHandler(this.classbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 488);
            this.Controls.Add(this.classbutton2);
            this.Controls.Add(this.classbutton1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Шибениця";
            this.ResumeLayout(false);

        }

        #endregion
        private Classbutton classbutton1;
        private Classbutton classbutton2;
    }
}

