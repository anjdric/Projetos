namespace BrowserPc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TextBoxHTML = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtURLVisitadas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxURL = new System.Windows.Forms.TextBox();
            this.HomePage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.PictureBox();
            this.PrevPage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevPage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 503);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabControl1_Layout);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Navegador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(781, 471);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://funnylogo.info/engines/Google/Red/Anjdric.aspx", System.UriKind.Absolute);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBoxHTML);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Código Fonte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBoxHTML
            // 
            this.TextBoxHTML.BackColor = System.Drawing.Color.LemonChiffon;
            this.TextBoxHTML.Location = new System.Drawing.Point(0, -2);
            this.TextBoxHTML.Multiline = true;
            this.TextBoxHTML.Name = "TextBoxHTML";
            this.TextBoxHTML.Size = new System.Drawing.Size(787, 494);
            this.TextBoxHTML.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtURLVisitadas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Histórico Navegação";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtURLVisitadas
            // 
            this.txtURLVisitadas.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtURLVisitadas.Location = new System.Drawing.Point(0, 0);
            this.txtURLVisitadas.Multiline = true;
            this.txtURLVisitadas.Name = "txtURLVisitadas";
            this.txtURLVisitadas.Size = new System.Drawing.Size(787, 494);
            this.txtURLVisitadas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextBoxURL);
            this.groupBox1.Controls.Add(this.HomePage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NextPage);
            this.groupBox1.Controls.Add(this.PrevPage);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // TextBoxURL
            // 
            this.TextBoxURL.AcceptsTab = true;
            this.TextBoxURL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxURL.Location = new System.Drawing.Point(175, 15);
            this.TextBoxURL.Name = "TextBoxURL";
            this.TextBoxURL.Size = new System.Drawing.Size(374, 20);
            this.TextBoxURL.TabIndex = 10;
            this.TextBoxURL.Text = "http://www.google.com.br/Anjdric";
            this.TextBoxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxURL_KeyDown);
            this.TextBoxURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxURL_KeyPress);
            // 
            // HomePage
            // 
            this.HomePage.Image = global::BrowserPc.Properties.Resources.Home;
            this.HomePage.Location = new System.Drawing.Point(75, 15);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(23, 23);
            this.HomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePage.TabIndex = 8;
            this.HomePage.TabStop = false;
            this.toolTip1.SetToolTip(this.HomePage, "Ir Para HomePage");
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // NextPage
            // 
            this.NextPage.Image = global::BrowserPc.Properties.Resources.direita_azul;
            this.NextPage.Location = new System.Drawing.Point(46, 15);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(23, 23);
            this.NextPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextPage.TabIndex = 6;
            this.NextPage.TabStop = false;
            this.toolTip1.SetToolTip(this.NextPage, "Avançar");
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            this.NextPage.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.NextPage.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // PrevPage
            // 
            this.PrevPage.Image = global::BrowserPc.Properties.Resources.esquerda_azul;
            this.PrevPage.Location = new System.Drawing.Point(14, 15);
            this.PrevPage.Name = "PrevPage";
            this.PrevPage.Size = new System.Drawing.Size(23, 23);
            this.PrevPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrevPage.TabIndex = 5;
            this.PrevPage.TabStop = false;
            this.toolTip1.SetToolTip(this.PrevPage, "Voltar");
            this.PrevPage.Click += new System.EventHandler(this.PrevPage_Click);
            this.PrevPage.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.PrevPage.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "All Rights Reserved Paulo César Luna 2013.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador FireChrome ^Anjdric^";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox NextPage;
        private System.Windows.Forms.PictureBox PrevPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HomePage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TextBoxURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtURLVisitadas;
        private System.Windows.Forms.TextBox TextBoxHTML;
        private System.Windows.Forms.Label label2;
    }
}

