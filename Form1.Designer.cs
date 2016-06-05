namespace BeetrootUI
{
    partial class mainForm
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
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_webToggle = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.output_box = new System.Windows.Forms.TextBox();
            this.tooltipController = new System.Windows.Forms.ToolTip(this.components);
            this.folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(12, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(87, 27);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Import...";
            this.tooltipController.SetToolTip(this.btn_import, "Import songs into your Beetroot Library.");
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(105, 12);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(87, 27);
            this.btn_config.TabIndex = 1;
            this.btn_config.Text = "Configure...";
            this.tooltipController.SetToolTip(this.btn_config, "Configure Beetroot to change things like destination folders and web UI port.");
            this.btn_config.UseVisualStyleBackColor = true;
            // 
            // btn_webToggle
            // 
            this.btn_webToggle.Location = new System.Drawing.Point(198, 12);
            this.btn_webToggle.Name = "btn_webToggle";
            this.btn_webToggle.Size = new System.Drawing.Size(87, 27);
            this.btn_webToggle.TabIndex = 2;
            this.btn_webToggle.Text = "Enable Web";
            this.tooltipController.SetToolTip(this.btn_webToggle, "Enable or Disable the Web UI");
            this.btn_webToggle.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(291, 12);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(87, 27);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "About...";
            this.tooltipController.SetToolTip(this.btn_about, "Show information about this app.");
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // output_box
            // 
            this.output_box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.Location = new System.Drawing.Point(12, 45);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_box.Size = new System.Drawing.Size(366, 214);
            this.output_box.TabIndex = 4;
            this.output_box.WordWrap = false;
            // 
            // folderSelector
            // 
            this.folderSelector.Description = "Select the folder where your music sits.";
            this.folderSelector.ShowNewFolderButton = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 271);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_webToggle);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_import);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Beetroot Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_webToggle;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.ToolTip tooltipController;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.FolderBrowserDialog folderSelector;
    }
}

