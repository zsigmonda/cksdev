namespace CKS.Dev.Core.VisualStudio.SharePoint.Environment.Dialogs
{
    partial class PackagesViewerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.lbPackages = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 19);
      this.label1.TabIndex = 10;
      this.label1.Text = "F&ilter:";
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbFilter.Location = new System.Drawing.Point(58, 16);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(285, 25);
      this.tbFilter.TabIndex = 11;
      this.tbFilter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
      // 
      // lbPackages
      // 
      this.lbPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbPackages.FormattingEnabled = true;
      this.lbPackages.ItemHeight = 17;
      this.lbPackages.Location = new System.Drawing.Point(14, 76);
      this.lbPackages.Name = "lbPackages";
      this.lbPackages.Size = new System.Drawing.Size(329, 242);
      this.lbPackages.TabIndex = 21;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 19);
      this.label2.TabIndex = 20;
      this.label2.Text = "&Packages:";
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnAdd.Location = new System.Drawing.Point(256, 330);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(87, 31);
      this.btnAdd.TabIndex = 30;
      this.btnAdd.Text = "&Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(162, 330);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(87, 31);
      this.btnCancel.TabIndex = 40;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // PackagesViewerForm
      // 
      this.AcceptButton = this.btnAdd;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(358, 375);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbPackages);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "PackagesViewerForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Select Package";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ListBox lbPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}