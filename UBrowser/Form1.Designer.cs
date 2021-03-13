namespace UBrowser
{
    partial class FormUBrowser
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.webUBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripButton_Back = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Home = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Go = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Back,
            this.toolStripButton_Forward,
            this.toolStripButton_Home,
            this.toolStripButton_Refresh,
            this.toolStripButton_Stop,
            this.toolStripButton_Go});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_URL.Location = new System.Drawing.Point(103, 0);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(1209, 25);
            this.textBox_URL.TabIndex = 4;
            // 
            // webUBrowser
            // 
            this.webUBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webUBrowser.Location = new System.Drawing.Point(0, 25);
            this.webUBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webUBrowser.Name = "webUBrowser";
            this.webUBrowser.Size = new System.Drawing.Size(1370, 526);
            this.webUBrowser.TabIndex = 6;
            // 
            // toolStripButton_Back
            // 
            this.toolStripButton_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Back.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Back.Image")));
            this.toolStripButton_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Back.Name = "toolStripButton_Back";
            this.toolStripButton_Back.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Back.Text = "toolStripButton_Back";
            this.toolStripButton_Back.Click += new System.EventHandler(this.toolStripButton_Back_Click);
            // 
            // toolStripButton_Forward
            // 
            this.toolStripButton_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Forward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Forward.Image")));
            this.toolStripButton_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Forward.Name = "toolStripButton_Forward";
            this.toolStripButton_Forward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Forward.Text = "toolStripButton_Forward";
            this.toolStripButton_Forward.Click += new System.EventHandler(this.toolStripButton_Forward_Click);
            // 
            // toolStripButton_Home
            // 
            this.toolStripButton_Home.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Home.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Home.Image")));
            this.toolStripButton_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Home.Name = "toolStripButton_Home";
            this.toolStripButton_Home.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Home.Text = "toolStripButton3";
            this.toolStripButton_Home.Click += new System.EventHandler(this.toolStripButton_Home_Click);
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Refresh.Image")));
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Refresh.Text = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Click += new System.EventHandler(this.toolStripButton_Refresh_Click);
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Stop.Text = "toolStripButton_Stop";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
            // 
            // toolStripButton_Go
            // 
            this.toolStripButton_Go.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Go.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Go.Image")));
            this.toolStripButton_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Go.Name = "toolStripButton_Go";
            this.toolStripButton_Go.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Go.Text = "toolStripButton4";
            this.toolStripButton_Go.Click += new System.EventHandler(this.toolStripButton_Go_Click);
            // 
            // FormUBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 551);
            this.ControlBox = false;
            this.Controls.Add(this.webUBrowser);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.WebBrowser webUBrowser;
        private System.Windows.Forms.ToolStripButton toolStripButton_Back;
        private System.Windows.Forms.ToolStripButton toolStripButton_Forward;
        private System.Windows.Forms.ToolStripButton toolStripButton_Home;
        private System.Windows.Forms.ToolStripButton toolStripButton_Go;
        private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
    }
}

