namespace SinekAvlamaApp
{
    partial class frmOyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOyun));
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 500;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.Color.DimGray;
            this.pnlGosterge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGosterge.BackgroundImage")));
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Controls.Add(this.lblSkor);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(1117, 0);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(233, 729);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.White;
            this.lblSkor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSkor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(40, 196);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(101, 33);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "Skor:0";
            this.lblSkor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.White;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(40, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(155, 110);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "30";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSure.Click += new System.EventHandler(this.lblSure_Click);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "unnamed1.png");
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlGosterge);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOyun";
            this.Text = "Sinekleri Avla!";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.ImageList imglist;
    }
}