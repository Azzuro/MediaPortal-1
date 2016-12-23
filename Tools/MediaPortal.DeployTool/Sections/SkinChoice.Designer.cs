﻿namespace MediaPortal.DeployTool.Sections
{
  partial class SkinChoice
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
      this.lblChooseSkin = new System.Windows.Forms.Label();
      this.btnTitan = new System.Windows.Forms.Button();
      this.btnDefaultWide = new System.Windows.Forms.Button();
      this.lblTitan = new System.Windows.Forms.Label();
      this.lblDefaultWide = new System.Windows.Forms.Label();
      this.pbSkin = new System.Windows.Forms.PictureBox();
      this.lblExisting = new System.Windows.Forms.Label();
      this.btnExisting = new System.Windows.Forms.Button();
      this.btnAres = new System.Windows.Forms.Button();
      this.lblAres = new System.Windows.Forms.Label();
      this.chkAllSkinSetup = new System.Windows.Forms.CheckBox();
      this.labelAllSkins = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbSkin)).BeginInit();
      this.SuspendLayout();
      // 
      // lblChooseSkin
      // 
      this.lblChooseSkin.AutoSize = true;
      this.lblChooseSkin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblChooseSkin.ForeColor = System.Drawing.Color.White;
      this.lblChooseSkin.Location = new System.Drawing.Point(293, 31);
      this.lblChooseSkin.Name = "lblChooseSkin";
      this.lblChooseSkin.Size = new System.Drawing.Size(108, 16);
      this.lblChooseSkin.TabIndex = 1;
      this.lblChooseSkin.Text = "Choose a skin";
      // 
      // btnTitan
      // 
      this.btnTitan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTitan.FlatAppearance.BorderSize = 0;
      this.btnTitan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnTitan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnTitan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTitan.Image = global::MediaPortal.DeployTool.Images.Choose_button_off;
      this.btnTitan.Location = new System.Drawing.Point(292, 96);
      this.btnTitan.Name = "btnTitan";
      this.btnTitan.Size = new System.Drawing.Size(33, 23);
      this.btnTitan.TabIndex = 2;
      this.btnTitan.UseVisualStyleBackColor = true;
      this.btnTitan.Click += new System.EventHandler(this.btnSkin1_Click);
      // 
      // btnDefaultWide
      // 
      this.btnDefaultWide.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDefaultWide.FlatAppearance.BorderSize = 0;
      this.btnDefaultWide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnDefaultWide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnDefaultWide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDefaultWide.Image = global::MediaPortal.DeployTool.Images.Choose_button_off;
      this.btnDefaultWide.Location = new System.Drawing.Point(292, 129);
      this.btnDefaultWide.Name = "btnDefaultWide";
      this.btnDefaultWide.Size = new System.Drawing.Size(33, 23);
      this.btnDefaultWide.TabIndex = 3;
      this.btnDefaultWide.UseVisualStyleBackColor = true;
      this.btnDefaultWide.Click += new System.EventHandler(this.btnSkin2_Click);
      // 
      // lblTitan
      // 
      this.lblTitan.AutoSize = true;
      this.lblTitan.ForeColor = System.Drawing.Color.White;
      this.lblTitan.Location = new System.Drawing.Point(331, 101);
      this.lblTitan.Name = "lblTitan";
      this.lblTitan.Size = new System.Drawing.Size(137, 13);
      this.lblTitan.TabIndex = 5;
      this.lblTitan.Text = "Titan - Full HD (1920x1080)";
      // 
      // lblDefaultWide
      // 
      this.lblDefaultWide.AutoSize = true;
      this.lblDefaultWide.ForeColor = System.Drawing.Color.White;
      this.lblDefaultWide.Location = new System.Drawing.Point(331, 134);
      this.lblDefaultWide.Name = "lblDefaultWide";
      this.lblDefaultWide.Size = new System.Drawing.Size(147, 13);
      this.lblDefaultWide.TabIndex = 6;
      this.lblDefaultWide.Text = "DefaultWide HD (1920x1080)";
      // 
      // pbSkin
      // 
      this.pbSkin.Image = global::MediaPortal.DeployTool.Images.preview_titan;
      this.pbSkin.Location = new System.Drawing.Point(32, 55);
      this.pbSkin.Name = "pbSkin";
      this.pbSkin.Size = new System.Drawing.Size(255, 144);
      this.pbSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbSkin.TabIndex = 8;
      this.pbSkin.TabStop = false;
      // 
      // lblExisting
      // 
      this.lblExisting.AutoSize = true;
      this.lblExisting.ForeColor = System.Drawing.Color.White;
      this.lblExisting.Location = new System.Drawing.Point(331, 68);
      this.lblExisting.Name = "lblExisting";
      this.lblExisting.Size = new System.Drawing.Size(270, 13);
      this.lblExisting.TabIndex = 11;
      this.lblExisting.Text = "Use Existing Skin (This will be checked for compatibility)";
      this.lblExisting.Visible = false;
      // 
      // btnExisting
      // 
      this.btnExisting.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExisting.FlatAppearance.BorderSize = 0;
      this.btnExisting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnExisting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExisting.Image = global::MediaPortal.DeployTool.Images.Choose_button_off;
      this.btnExisting.Location = new System.Drawing.Point(292, 63);
      this.btnExisting.Name = "btnExisting";
      this.btnExisting.Size = new System.Drawing.Size(33, 23);
      this.btnExisting.TabIndex = 10;
      this.btnExisting.UseVisualStyleBackColor = true;
      this.btnExisting.Visible = false;
      this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
      // 
      // btnAres
      // 
      this.btnAres.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAres.FlatAppearance.BorderSize = 0;
      this.btnAres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnAres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnAres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAres.Image = global::MediaPortal.DeployTool.Images.Choose_button_off;
      this.btnAres.Location = new System.Drawing.Point(292, 162);
      this.btnAres.Name = "btnAres";
      this.btnAres.Size = new System.Drawing.Size(33, 23);
      this.btnAres.TabIndex = 4;
      this.btnAres.UseVisualStyleBackColor = true;
      this.btnAres.Click += new System.EventHandler(this.btnSkin3_Click);
      // 
      // lblAres
      // 
      this.lblAres.AutoSize = true;
      this.lblAres.ForeColor = System.Drawing.Color.White;
      this.lblAres.Location = new System.Drawing.Point(331, 167);
      this.lblAres.Name = "lblAres";
      this.lblAres.Size = new System.Drawing.Size(90, 13);
      this.lblAres.TabIndex = 12;
      this.lblAres.Text = "Ares (1920x1080)";
      // 
      // chkAllSkinSetup
      // 
      this.chkAllSkinSetup.AutoSize = true;
      this.chkAllSkinSetup.ForeColor = System.Drawing.Color.White;
      this.chkAllSkinSetup.Location = new System.Drawing.Point(364, 225);
      this.chkAllSkinSetup.Name = "chkAllSkinSetup";
      this.chkAllSkinSetup.Size = new System.Drawing.Size(201, 17);
      this.chkAllSkinSetup.TabIndex = 14;
      this.chkAllSkinSetup.Text = "Install All Skins provided by the setup";
      this.chkAllSkinSetup.UseVisualStyleBackColor = true;
      this.chkAllSkinSetup.CheckedChanged += new System.EventHandler(this.chkAllSkinSetup_CheckedChanged);
      // 
      // labelAllSkins
      // 
      this.labelAllSkins.AutoSize = true;
      this.labelAllSkins.ForeColor = System.Drawing.Color.White;
      this.labelAllSkins.Location = new System.Drawing.Point(353, 196);
      this.labelAllSkins.Name = "labelAllSkins";
      this.labelAllSkins.Size = new System.Drawing.Size(236, 26);
      this.labelAllSkins.TabIndex = 13;
      this.labelAllSkins.Text = "Selector above will install only the skin selected, \r\ninfo: Titan will always be " +
    "installed as safe skin";
      this.labelAllSkins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.labelAllSkins.Visible = false;
      // 
      // SkinChoice
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.chkAllSkinSetup);
      this.Controls.Add(this.labelAllSkins);
      this.Controls.Add(this.lblAres);
      this.Controls.Add(this.btnAres);
      this.Controls.Add(this.lblExisting);
      this.Controls.Add(this.btnExisting);
      this.Controls.Add(this.pbSkin);
      this.Controls.Add(this.lblChooseSkin);
      this.Controls.Add(this.lblTitan);
      this.Controls.Add(this.lblDefaultWide);
      this.Controls.Add(this.btnTitan);
      this.Controls.Add(this.btnDefaultWide);
      this.Name = "SkinChoice";
      this.Controls.SetChildIndex(this.btnDefaultWide, 0);
      this.Controls.SetChildIndex(this.btnTitan, 0);
      this.Controls.SetChildIndex(this.lblDefaultWide, 0);
      this.Controls.SetChildIndex(this.lblTitan, 0);
      this.Controls.SetChildIndex(this.lblChooseSkin, 0);
      this.Controls.SetChildIndex(this.pbSkin, 0);
      this.Controls.SetChildIndex(this.btnExisting, 0);
      this.Controls.SetChildIndex(this.lblExisting, 0);
      this.Controls.SetChildIndex(this.btnAres, 0);
      this.Controls.SetChildIndex(this.lblAres, 0);
      this.Controls.SetChildIndex(this.labelAllSkins, 0);
      this.Controls.SetChildIndex(this.chkAllSkinSetup, 0);
      this.Controls.SetChildIndex(this.labelSectionHeader, 0);
      ((System.ComponentModel.ISupportInitialize)(this.pbSkin)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblChooseSkin;
    private System.Windows.Forms.Button btnTitan;
    private System.Windows.Forms.Button btnDefaultWide;
    private System.Windows.Forms.Label lblTitan;
    private System.Windows.Forms.Label lblDefaultWide;
    private System.Windows.Forms.PictureBox pbSkin;
    private System.Windows.Forms.Label lblExisting;
    private System.Windows.Forms.Button btnExisting;
    private System.Windows.Forms.Button btnAres;
    private System.Windows.Forms.Label lblAres;
    private System.Windows.Forms.CheckBox chkAllSkinSetup;
    private System.Windows.Forms.Label labelAllSkins;
  }
}
