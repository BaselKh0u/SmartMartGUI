namespace SmartMart
{
    partial class AllDetailsForm
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
            this.lbDetails = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnDetails = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.Location = new System.Drawing.Point(32, 40);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(174, 36);
            this.lbDetails.TabIndex = 1;
            this.lbDetails.Text = "Full Details";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnDetails
            // 
            this.pnDetails.Location = new System.Drawing.Point(37, 101);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(1159, 740);
            this.pnDetails.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(38, 859);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(204, 53);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AllDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 924);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnDetails);
            this.Controls.Add(this.lbDetails);
            this.Name = "AllDetailsForm";
            this.Text = "AllDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.Button btnClose;
    }
}