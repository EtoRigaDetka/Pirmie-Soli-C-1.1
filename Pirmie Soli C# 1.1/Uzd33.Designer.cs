namespace Pirmie_Soli_C__1._1
{
    partial class Uzd33
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uzd33));
            this.lbUzd33Main = new System.Windows.Forms.Label();
            this.tbToDouble = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbUzd33Main
            // 
            this.lbUzd33Main.AutoSize = true;
            this.lbUzd33Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUzd33Main.Location = new System.Drawing.Point(2, 9);
            this.lbUzd33Main.Name = "lbUzd33Main";
            this.lbUzd33Main.Size = new System.Drawing.Size(1275, 58);
            this.lbUzd33Main.TabIndex = 0;
            this.lbUzd33Main.Text = resources.GetString("lbUzd33Main.Text");
            // 
            // tbToDouble
            // 
            this.tbToDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToDouble.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbToDouble.Location = new System.Drawing.Point(50, 104);
            this.tbToDouble.Name = "tbToDouble";
            this.tbToDouble.Size = new System.Drawing.Size(255, 30);
            this.tbToDouble.TabIndex = 1;
            this.tbToDouble.Text = "Enter text";
            this.tbToDouble.Enter += new System.EventHandler(this.tbToDouble_Enter);
            this.tbToDouble.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbToDouble_KeyUp);
            // 
            // Uzd33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.tbToDouble);
            this.Controls.Add(this.lbUzd33Main);
            this.Name = "Uzd33";
            this.Text = "Uzd33";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUzd33Main;
        private System.Windows.Forms.TextBox tbToDouble;
    }
}