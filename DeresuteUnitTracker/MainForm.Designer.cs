namespace DeresuteUnitTracker
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpIdols = new System.Windows.Forms.TabPage();
            this.tpUnits = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpIdols);
            this.tabControl1.Controls.Add(this.tpUnits);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tpIdols
            // 
            this.tpIdols.Location = new System.Drawing.Point(4, 22);
            this.tpIdols.Name = "tpIdols";
            this.tpIdols.Padding = new System.Windows.Forms.Padding(3);
            this.tpIdols.Size = new System.Drawing.Size(767, 399);
            this.tpIdols.TabIndex = 0;
            this.tpIdols.Text = "Idols";
            this.tpIdols.UseVisualStyleBackColor = true;
            // 
            // tpUnits
            // 
            this.tpUnits.Location = new System.Drawing.Point(4, 22);
            this.tpUnits.Name = "tpUnits";
            this.tpUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnits.Size = new System.Drawing.Size(767, 399);
            this.tpUnits.TabIndex = 1;
            this.tpUnits.Text = "Units";
            this.tpUnits.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Unit Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpIdols;
        private System.Windows.Forms.TabPage tpUnits;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

