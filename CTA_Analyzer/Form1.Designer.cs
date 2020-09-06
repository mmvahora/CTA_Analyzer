namespace CTA_Analyzer
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
            this.listboxStations = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxStops = new System.Windows.Forms.ListBox();
            this.textboxPercent = new System.Windows.Forms.TextBox();
            this.textboxAVG = new System.Windows.Forms.TextBox();
            this.textboxRidership = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxWeekday = new System.Windows.Forms.TextBox();
            this.textboxSaturday = new System.Windows.Forms.TextBox();
            this.textboxSunday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxHandicap = new System.Windows.Forms.TextBox();
            this.textboxDirection = new System.Windows.Forms.TextBox();
            this.textboxLocation = new System.Windows.Forms.TextBox();
            this.listboxLines = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxNumberStations = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxStations
            // 
            this.listboxStations.FormattingEnabled = true;
            this.listboxStations.Location = new System.Drawing.Point(12, 47);
            this.listboxStations.Name = "listboxStations";
            this.listboxStations.Size = new System.Drawing.Size(184, 290);
            this.listboxStations.TabIndex = 0;
            this.listboxStations.SelectedIndexChanged += new System.EventHandler(this.listboxStations_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.top10ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.top10ToolStripMenuItem.Text = "Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // listboxStops
            // 
            this.listboxStops.FormattingEnabled = true;
            this.listboxStops.Location = new System.Drawing.Point(261, 164);
            this.listboxStops.Name = "listboxStops";
            this.listboxStops.Size = new System.Drawing.Size(181, 173);
            this.listboxStops.TabIndex = 2;
            this.listboxStops.SelectedIndexChanged += new System.EventHandler(this.listboxStops_SelectedIndexChanged);
            // 
            // textboxPercent
            // 
            this.textboxPercent.Location = new System.Drawing.Point(342, 120);
            this.textboxPercent.Name = "textboxPercent";
            this.textboxPercent.Size = new System.Drawing.Size(102, 20);
            this.textboxPercent.TabIndex = 3;
            // 
            // textboxAVG
            // 
            this.textboxAVG.Location = new System.Drawing.Point(342, 80);
            this.textboxAVG.Name = "textboxAVG";
            this.textboxAVG.Size = new System.Drawing.Size(102, 20);
            this.textboxAVG.TabIndex = 4;
            // 
            // textboxRidership
            // 
            this.textboxRidership.Location = new System.Drawing.Point(342, 43);
            this.textboxRidership.Name = "textboxRidership";
            this.textboxRidership.Size = new System.Drawing.Size(100, 20);
            this.textboxRidership.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Ridership:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Avg Ridership:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "% Ridership:";
            // 
            // textboxWeekday
            // 
            this.textboxWeekday.Location = new System.Drawing.Point(597, 43);
            this.textboxWeekday.Name = "textboxWeekday";
            this.textboxWeekday.Size = new System.Drawing.Size(100, 20);
            this.textboxWeekday.TabIndex = 9;
            // 
            // textboxSaturday
            // 
            this.textboxSaturday.Location = new System.Drawing.Point(597, 80);
            this.textboxSaturday.Name = "textboxSaturday";
            this.textboxSaturday.Size = new System.Drawing.Size(100, 20);
            this.textboxSaturday.TabIndex = 10;
            // 
            // textboxSunday
            // 
            this.textboxSunday.Location = new System.Drawing.Point(597, 117);
            this.textboxSunday.Name = "textboxSunday";
            this.textboxSunday.Size = new System.Drawing.Size(100, 20);
            this.textboxSunday.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Weekday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saturday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sunday/Holiday:";
            // 
            // textboxHandicap
            // 
            this.textboxHandicap.Location = new System.Drawing.Point(646, 164);
            this.textboxHandicap.Name = "textboxHandicap";
            this.textboxHandicap.Size = new System.Drawing.Size(49, 20);
            this.textboxHandicap.TabIndex = 15;
            // 
            // textboxDirection
            // 
            this.textboxDirection.Location = new System.Drawing.Point(646, 190);
            this.textboxDirection.Name = "textboxDirection";
            this.textboxDirection.Size = new System.Drawing.Size(49, 20);
            this.textboxDirection.TabIndex = 16;
            // 
            // textboxLocation
            // 
            this.textboxLocation.Location = new System.Drawing.Point(511, 241);
            this.textboxLocation.Name = "textboxLocation";
            this.textboxLocation.Size = new System.Drawing.Size(184, 20);
            this.textboxLocation.TabIndex = 17;
            // 
            // listboxLines
            // 
            this.listboxLines.FormattingEnabled = true;
            this.listboxLines.Location = new System.Drawing.Point(511, 291);
            this.listboxLines.Name = "listboxLines";
            this.listboxLines.Size = new System.Drawing.Size(186, 95);
            this.listboxLines.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Handicap accessible?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Direction of travel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Lines:";
            // 
            // textboxNumberStations
            // 
            this.textboxNumberStations.Location = new System.Drawing.Point(129, 366);
            this.textboxNumberStations.Name = "textboxNumberStations";
            this.textboxNumberStations.Size = new System.Drawing.Size(67, 20);
            this.textboxNumberStations.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Number of Stations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 398);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textboxNumberStations);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listboxLines);
            this.Controls.Add(this.textboxLocation);
            this.Controls.Add(this.textboxDirection);
            this.Controls.Add(this.textboxHandicap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxSunday);
            this.Controls.Add(this.textboxSaturday);
            this.Controls.Add(this.textboxWeekday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxRidership);
            this.Controls.Add(this.textboxAVG);
            this.Controls.Add(this.textboxPercent);
            this.Controls.Add(this.listboxStops);
            this.Controls.Add(this.listboxStations);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cta Ridership Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxStations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ListBox listboxStops;
        private System.Windows.Forms.TextBox textboxPercent;
        private System.Windows.Forms.TextBox textboxAVG;
        private System.Windows.Forms.TextBox textboxRidership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxWeekday;
        private System.Windows.Forms.TextBox textboxSaturday;
        private System.Windows.Forms.TextBox textboxSunday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxHandicap;
        private System.Windows.Forms.TextBox textboxDirection;
        private System.Windows.Forms.TextBox textboxLocation;
        private System.Windows.Forms.ListBox listboxLines;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxNumberStations;
        private System.Windows.Forms.Label label11;
    }
}

