namespace PRG_Project
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.computerTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerPeripheralsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchBox = new System.Windows.Forms.Label();
            this.textBoxSearchBox = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerTypeToolStripMenuItem,
            this.dealsToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(965, 34);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // computerTypeToolStripMenuItem
            // 
            this.computerTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desktopsToolStripMenuItem,
            this.laptopsToolStripMenuItem,
            this.computerPeripheralsToolStripMenuItem,
            this.videoGameToolStripMenuItem});
            this.computerTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerTypeToolStripMenuItem.Name = "computerTypeToolStripMenuItem";
            this.computerTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.computerTypeToolStripMenuItem.Text = "Computer Type";
            // 
            // desktopsToolStripMenuItem
            // 
            this.desktopsToolStripMenuItem.Name = "desktopsToolStripMenuItem";
            this.desktopsToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.desktopsToolStripMenuItem.Text = "Desktops";
            // 
            // laptopsToolStripMenuItem
            // 
            this.laptopsToolStripMenuItem.Name = "laptopsToolStripMenuItem";
            this.laptopsToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.laptopsToolStripMenuItem.Text = "Laptops";
            // 
            // computerPeripheralsToolStripMenuItem
            // 
            this.computerPeripheralsToolStripMenuItem.Name = "computerPeripheralsToolStripMenuItem";
            this.computerPeripheralsToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.computerPeripheralsToolStripMenuItem.Text = "Computer Peripherals";
            // 
            // videoGameToolStripMenuItem
            // 
            this.videoGameToolStripMenuItem.Name = "videoGameToolStripMenuItem";
            this.videoGameToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.videoGameToolStripMenuItem.Text = "Home Security";
            // 
            // dealsToolStripMenuItem
            // 
            this.dealsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealsToolStripMenuItem.Name = "dealsToolStripMenuItem";
            this.dealsToolStripMenuItem.Size = new System.Drawing.Size(75, 30);
            this.dealsToolStripMenuItem.Text = "Deals";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(96, 30);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.comboBoxFilter);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnSearchBox);
            this.groupBox1.Controls.Add(this.textBoxSearchBox);
            this.groupBox1.Controls.Add(this.picBoxLogo);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(824, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchBox
            // 
            this.btnSearchBox.AutoSize = true;
            this.btnSearchBox.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBox.ForeColor = System.Drawing.Color.Black;
            this.btnSearchBox.Location = new System.Drawing.Point(281, 19);
            this.btnSearchBox.Name = "btnSearchBox";
            this.btnSearchBox.Size = new System.Drawing.Size(185, 41);
            this.btnSearchBox.TabIndex = 2;
            this.btnSearchBox.Text = "Search Box";
            // 
            // textBoxSearchBox
            // 
            this.textBoxSearchBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearchBox.Location = new System.Drawing.Point(376, 77);
            this.textBoxSearchBox.Name = "textBoxSearchBox";
            this.textBoxSearchBox.Size = new System.Drawing.Size(418, 20);
            this.textBoxSearchBox.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.BackgroundImage")));
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 19);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(208, 122);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 205);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(615, 318);
            this.dataGridProducts.TabIndex = 2;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "ComputerType",
            "Model"});
            this.comboBoxFilter.Location = new System.Drawing.Point(273, 77);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(87, 21);
            this.comboBoxFilter.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 569);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainPage";
            this.Text = "Tenzin Computers";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem computerTypeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label btnSearchBox;
        private System.Windows.Forms.TextBox textBoxSearchBox;
        private System.Windows.Forms.ToolStripMenuItem dealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laptopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerPeripheralsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoGameToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}

