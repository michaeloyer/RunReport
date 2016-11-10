namespace DataPull
{
    partial class DataPullGeneratorForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStandard = new System.Windows.Forms.TabPage();
            this.treStandard = new System.Windows.Forms.TreeView();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cmdGenerateAndClose = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabStandard);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(362, 576);
            this.tabControl.TabIndex = 0;
            // 
            // tabStandard
            // 
            this.tabStandard.Controls.Add(this.treStandard);
            this.tabStandard.Location = new System.Drawing.Point(4, 22);
            this.tabStandard.Name = "tabStandard";
            this.tabStandard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStandard.Size = new System.Drawing.Size(354, 550);
            this.tabStandard.TabIndex = 0;
            this.tabStandard.Text = "Standard";
            this.tabStandard.UseVisualStyleBackColor = true;
            // 
            // treStandard
            // 
            this.treStandard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treStandard.HideSelection = false;
            this.treStandard.Location = new System.Drawing.Point(7, 6);
            this.treStandard.Name = "treStandard";
            this.treStandard.Size = new System.Drawing.Size(340, 538);
            this.treStandard.TabIndex = 0;
            this.treStandard.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treStandard_AfterSelect);
            this.treStandard.DoubleClick += new System.EventHandler(this.treStandard_DoubleClick);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGenerate.Location = new System.Drawing.Point(135, 594);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(107, 35);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "Generate Report";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdGenerateAndClose
            // 
            this.cmdGenerateAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGenerateAndClose.Location = new System.Drawing.Point(135, 635);
            this.cmdGenerateAndClose.Name = "cmdGenerateAndClose";
            this.cmdGenerateAndClose.Size = new System.Drawing.Size(107, 35);
            this.cmdGenerateAndClose.TabIndex = 3;
            this.cmdGenerateAndClose.Text = "Generate Report and Close";
            this.cmdGenerateAndClose.UseVisualStyleBackColor = true;
            this.cmdGenerateAndClose.Click += new System.EventHandler(this.cmdGenerateAndClose_Click);
            // 
            // DataPullGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 677);
            this.Controls.Add(this.cmdGenerateAndClose);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.tabControl);
            this.Name = "DataPullGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pull Generator";
            this.tabControl.ResumeLayout(false);
            this.tabStandard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStandard;
        private System.Windows.Forms.TreeView treStandard;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Button cmdGenerateAndClose;
    }
}

