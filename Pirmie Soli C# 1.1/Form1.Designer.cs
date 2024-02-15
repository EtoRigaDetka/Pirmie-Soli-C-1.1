namespace Pirmie_Soli_C__1._1
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
            this.lbMain = new System.Windows.Forms.Label();
            this.btUzd33 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(287, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(756, 92);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "\tPirmie soļi C#\r\nVizuālie komponenti, īpašības, notikumi";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUzd33
            // 
            this.btUzd33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUzd33.Location = new System.Drawing.Point(27, 128);
            this.btUzd33.Name = "btUzd33";
            this.btUzd33.Size = new System.Drawing.Size(189, 66);
            this.btUzd33.TabIndex = 1;
            this.btUzd33.Text = "Uzdevums 33";
            this.btUzd33.UseVisualStyleBackColor = true;
            this.btUzd33.Click += new System.EventHandler(this.btUzd33_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 450);
            this.Controls.Add(this.btUzd33);
            this.Controls.Add(this.lbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button btUzd33;
    }
}

