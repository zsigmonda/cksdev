namespace CKS.Dev.Core.VisualStudio.SharePoint.Environment.Dialogs
{
  /// <summary>
  /// 
  /// </summary>
  partial class FeaturesViewerForm
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.lbFeatures = new System.Windows.Forms.ListBox();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cbProject = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(285, 370);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(87, 30);
      this.btnCancel.TabIndex = 50;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnAdd.Location = new System.Drawing.Point(378, 370);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(87, 30);
      this.btnAdd.TabIndex = 40;
      this.btnAdd.Text = "&Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 17);
      this.label2.TabIndex = 30;
      this.label2.Text = "&Features:";
      // 
      // lbFeatures
      // 
      this.lbFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbFeatures.FormattingEnabled = true;
      this.lbFeatures.ItemHeight = 17;
      this.lbFeatures.Location = new System.Drawing.Point(14, 110);
      this.lbFeatures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.lbFeatures.Name = "lbFeatures";
      this.lbFeatures.Size = new System.Drawing.Size(451, 242);
      this.lbFeatures.TabIndex = 31;
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbFilter.Location = new System.Drawing.Point(85, 12);
      this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(380, 25);
      this.tbFilter.TabIndex = 11;
      this.tbFilter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 17);
      this.label1.TabIndex = 10;
      this.label1.Text = "F&ilter:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 54);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 17);
      this.label3.TabIndex = 20;
      this.label3.Text = "&Project:";
      // 
      // cbProject
      // 
      this.cbProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbProject.FormattingEnabled = true;
      this.cbProject.Location = new System.Drawing.Point(85, 51);
      this.cbProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cbProject.Name = "cbProject";
      this.cbProject.Size = new System.Drawing.Size(380, 25);
      this.cbProject.TabIndex = 21;
      this.cbProject.SelectedIndexChanged += new System.EventHandler(this.Project_SelectedIndexChanged);
      // 
      // FeaturesViewerForm
      // 
      this.AcceptButton = this.btnAdd;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(481, 413);
      this.Controls.Add(this.cbProject);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbFeatures);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "FeaturesViewerForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Select Feature";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lbFeatures;
    private System.Windows.Forms.TextBox tbFilter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbProject;
  }
}