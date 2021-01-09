namespace Könyvtári_HTML_Generátor
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
            this.button_kodgeneralas = new System.Windows.Forms.Button();
            this.button_1_adatbazis_betoltese = new System.Windows.Forms.Button();
            this.button_vagolapra = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_fajlnev = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_webbongeszo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_About = new System.Windows.Forms.Button();
            this.richTextBox_kezdoszoveg = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_kodgeneralas
            // 
            this.button_kodgeneralas.Enabled = false;
            this.button_kodgeneralas.Location = new System.Drawing.Point(12, 96);
            this.button_kodgeneralas.Name = "button_kodgeneralas";
            this.button_kodgeneralas.Size = new System.Drawing.Size(199, 59);
            this.button_kodgeneralas.TabIndex = 1;
            this.button_kodgeneralas.Text = "2. HTML kódgenerálás\r\nKIK szerver részére\r\n";
            this.button_kodgeneralas.UseVisualStyleBackColor = true;
            this.button_kodgeneralas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_1_adatbazis_betoltese
            // 
            this.button_1_adatbazis_betoltese.Location = new System.Drawing.Point(12, 12);
            this.button_1_adatbazis_betoltese.Name = "button_1_adatbazis_betoltese";
            this.button_1_adatbazis_betoltese.Size = new System.Drawing.Size(199, 58);
            this.button_1_adatbazis_betoltese.TabIndex = 0;
            this.button_1_adatbazis_betoltese.Text = "1. Adatbázis betöltése";
            this.button_1_adatbazis_betoltese.UseVisualStyleBackColor = true;
            this.button_1_adatbazis_betoltese.Click += new System.EventHandler(this.button_1_adatbazis_betoltese_Click);
            // 
            // button_vagolapra
            // 
            this.button_vagolapra.Enabled = false;
            this.button_vagolapra.Location = new System.Drawing.Point(12, 265);
            this.button_vagolapra.Name = "button_vagolapra";
            this.button_vagolapra.Size = new System.Drawing.Size(199, 60);
            this.button_vagolapra.TabIndex = 2;
            this.button_vagolapra.Text = "4. Adatok vágólapra másolása";
            this.button_vagolapra.UseVisualStyleBackColor = true;
            this.button_vagolapra.Click += new System.EventHandler(this.button_vagolapra_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel fájlok|*.xlsx|Excel 2003 fájlok|*.xls|Minden fájl|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ora,
            this.toolStripStatusLabel_fajlnev,
            this.toolStripStatusLabel_version});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1051, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_ora
            // 
            this.toolStripStatusLabel_ora.Name = "toolStripStatusLabel_ora";
            this.toolStripStatusLabel_ora.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel_ora.Text = "00:00";
            // 
            // toolStripStatusLabel_fajlnev
            // 
            this.toolStripStatusLabel_fajlnev.Name = "toolStripStatusLabel_fajlnev";
            this.toolStripStatusLabel_fajlnev.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_fajlnev.Text = "\\";
            // 
            // toolStripStatusLabel_version
            // 
            this.toolStripStatusLabel_version.Name = "toolStripStatusLabel_version";
            this.toolStripStatusLabel_version.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel_version.Text = "Ver. ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(238, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(402, 469);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button_webbongeszo
            // 
            this.button_webbongeszo.Enabled = false;
            this.button_webbongeszo.Location = new System.Drawing.Point(12, 180);
            this.button_webbongeszo.Name = "button_webbongeszo";
            this.button_webbongeszo.Size = new System.Drawing.Size(199, 60);
            this.button_webbongeszo.TabIndex = 5;
            this.button_webbongeszo.Text = "3. Webböngésző indítása";
            this.button_webbongeszo.UseVisualStyleBackColor = true;
            this.button_webbongeszo.Click += new System.EventHandler(this.button_webbongeszo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(646, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(393, 469);
            this.webBrowser1.TabIndex = 6;
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(12, 458);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(199, 23);
            this.button_About.TabIndex = 7;
            this.button_About.Text = "A programról...";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // richTextBox_kezdoszoveg
            // 
            this.richTextBox_kezdoszoveg.Location = new System.Drawing.Point(12, 345);
            this.richTextBox_kezdoszoveg.Name = "richTextBox_kezdoszoveg";
            this.richTextBox_kezdoszoveg.Size = new System.Drawing.Size(199, 98);
            this.richTextBox_kezdoszoveg.TabIndex = 8;
            this.richTextBox_kezdoszoveg.Text = resources.GetString("richTextBox_kezdoszoveg.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 527);
            this.Controls.Add(this.richTextBox_kezdoszoveg);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_webbongeszo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_vagolapra);
            this.Controls.Add(this.button_1_adatbazis_betoltese);
            this.Controls.Add(this.button_kodgeneralas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Könyvtári Liferay Portal HTML Generátor és Oktatóprogram © 2018 Dr. Devosa Iván P" +
    "h.D. ISBN:978-615-5817-06-9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kodgeneralas;
        private System.Windows.Forms.Button button_1_adatbazis_betoltese;
        private System.Windows.Forms.Button button_vagolapra;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_fajlnev;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_webbongeszo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_version;
        private System.Windows.Forms.RichTextBox richTextBox_kezdoszoveg;
    }
}

