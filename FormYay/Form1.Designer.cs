namespace FormYay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.StörstTal = new System.Windows.Forms.ListBox();
            this.MinaResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Största talet:";
            // 
            // StörstTal
            // 
            this.StörstTal.FormattingEnabled = true;
            this.StörstTal.ItemHeight = 15;
            this.StörstTal.Items.AddRange(new object[] {
            "10",
            "20"});
            this.StörstTal.Location = new System.Drawing.Point(125, 113);
            this.StörstTal.Name = "StörstTal";
            this.StörstTal.Size = new System.Drawing.Size(90, 34);
            this.StörstTal.TabIndex = 1;
            // 
            // MinaResultat
            // 
            this.MinaResultat.Enabled = false;
            this.MinaResultat.Location = new System.Drawing.Point(312, 201);
            this.MinaResultat.Multiline = true;
            this.MinaResultat.Name = "MinaResultat";
            this.MinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MinaResultat.Size = new System.Drawing.Size(90, 60);
            this.MinaResultat.TabIndex = 2;
            this.MinaResultat.TextChanged += new System.EventHandler(this.tbxMinaResultat_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinaResultat);
            this.Controls.Add(this.StörstTal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox StörstTal;
        private TextBox MinaResultat;
    }
}