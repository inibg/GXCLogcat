namespace GXCLogcatWindow
{
    partial class GXCLogcatWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectDeviceLabel = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectDeviceLabel
            // 
            this.SelectDeviceLabel.AutoSize = true;
            this.SelectDeviceLabel.Location = new System.Drawing.Point(4, 4);
            this.SelectDeviceLabel.Name = "SelectDeviceLabel";
            this.SelectDeviceLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectDeviceLabel.TabIndex = 0;
            this.SelectDeviceLabel.Text = "Device";
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(52, 0);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(121, 21);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.SelectDeviceLabel);
            this.Name = "ToolWindow";
            this.Size = new System.Drawing.Size(282, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectDeviceLabel;
        private System.Windows.Forms.ComboBox cmbDevices;
    }
}
