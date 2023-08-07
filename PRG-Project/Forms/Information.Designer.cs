namespace PRG_Project.Forms
{
    partial class Information
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
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpecs = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelHD = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(376, 239);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            this.pictureBoxProduct.MouseEnter += new System.EventHandler(this.pictureBoxProduct_MouseEnter);
            this.pictureBoxProduct.MouseLeave += new System.EventHandler(this.pictureBoxProduct_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Gold;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 280);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSpecs
            // 
            this.labelSpecs.AutoSize = true;
            this.labelSpecs.BackColor = System.Drawing.Color.Gold;
            this.labelSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelSpecs.Location = new System.Drawing.Point(421, 12);
            this.labelSpecs.Name = "labelSpecs";
            this.labelSpecs.Size = new System.Drawing.Size(110, 37);
            this.labelSpecs.TabIndex = 2;
            this.labelSpecs.Text = "Specs";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.Location = new System.Drawing.Point(423, 70);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(70, 25);
            this.labelRAM.TabIndex = 3;
            this.labelRAM.Text = "label1";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(14, 329);
            this.labelDescription.MaximumSize = new System.Drawing.Size(400, 5000);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(51, 20);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "label1";
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Lime;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(428, 317);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(139, 57);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            this.buttonBuy.MouseEnter += new System.EventHandler(this.buttonSubmit_MouseEnter);
            this.buttonBuy.MouseLeave += new System.EventHandler(this.buttonSubmit_MouseLeave);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(428, 397);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(139, 59);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            this.buttonReturn.MouseEnter += new System.EventHandler(this.buttonReturn_MouseEnter);
            this.buttonReturn.MouseLeave += new System.EventHandler(this.buttonReturn_MouseLeave);
            // 
            // labelHD
            // 
            this.labelHD.AutoSize = true;
            this.labelHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHD.Location = new System.Drawing.Point(423, 112);
            this.labelHD.Name = "labelHD";
            this.labelHD.Size = new System.Drawing.Size(70, 25);
            this.labelHD.TabIndex = 7;
            this.labelHD.Text = "label1";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(423, 159);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(70, 25);
            this.labelCPU.TabIndex = 8;
            this.labelCPU.Text = "label1";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 518);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelHD);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelSpecs);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxProduct);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpecs;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelHD;
        private System.Windows.Forms.Label labelCPU;
    }
}