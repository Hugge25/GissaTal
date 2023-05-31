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
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.btnGissa = new System.Windows.Forms.Button();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
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
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(383, 257);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 2;
            this.tbxMinaResultat.TextChanged += new System.EventHandler(this.tbxMinaResultat_TextChanged_1);
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(408, 113);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(83, 23);
            this.btnStartaSpelet.TabIndex = 3;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(408, 151);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(83, 23);
            this.btnSpelaIgen.TabIndex = 4;
            this.btnSpelaIgen.Text = "Spela Igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(383, 228);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(76, 15);
            this.lblMinaResultat.TabIndex = 5;
            this.lblMinaResultat.Text = "Mina resultat";
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(255, 289);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 6;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(42, 257);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(67, 15);
            this.lblDator.TabIndex = 7;
            this.lblDator.Text = "Datorns tal:";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(39, 292);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(70, 15);
            this.lblGissa.TabIndex = 8;
            this.lblGissa.Text = "Gissa ett tal:";
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(125, 289);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(100, 23);
            this.tbxGissa.TabIndex = 10;
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(125, 253);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsTal.TabIndex = 11;
            this.lblDatornsTal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(68, 353);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(100, 23);
            this.lblResultat.TabIndex = 12;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 440);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblDatornsTal);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.lblGissa);
            this.Controls.Add(this.lblDator);
            this.Controls.Add(this.btnGissa);
            this.Controls.Add(this.lblMinaResultat);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.tbxMinaResultat);
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
        private TextBox tbxMinaResultat;
        private Button btnStartaSpelet;
        private Button btnSpelaIgen;
        private Label lblMinaResultat;
        private Button btnGissa;
        private Label lblDator;
        private Label lblGissa;
        private TextBox tbxGissa;
        private Label lblDatornsTal;
        private Label lblResultat;
    }
}