﻿using System.Collections.Generic;
using System.Linq;
namespace EAMapping
{
	partial class MappingControlGUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private EAMapping.LinkedTreeViews trees;
		private System.Windows.Forms.Button exportButton;
		private System.Windows.Forms.Button goToTargetButton;
		private System.Windows.Forms.Button goToSourceButton;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MappingControlGUI));
			this.trees = new EAMapping.LinkedTreeViews();
			this.exportButton = new System.Windows.Forms.Button();
			this.goToTargetButton = new System.Windows.Forms.Button();
			this.goToSourceButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// trees
			// 
			this.trees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.trees.BackColor = System.Drawing.Color.LightGray;
			this.trees.Location = new System.Drawing.Point(0, 0);
			this.trees.Name = "trees";
			this.trees.Size = new System.Drawing.Size(994, 552);
			this.trees.TabIndex = 0;
			// 
			// exportButton
			// 
			this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exportButton.Location = new System.Drawing.Point(916, 558);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(75, 23);
			this.exportButton.TabIndex = 8;
			this.exportButton.Text = "Export";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new System.EventHandler(this.ExportButtonClick);
			// 
			// goToTargetButton
			// 
			this.goToTargetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.goToTargetButton.Image = ((System.Drawing.Image)(resources.GetObject("goToTargetButton.Image")));
			this.goToTargetButton.Location = new System.Drawing.Point(33, 558);
			this.goToTargetButton.Name = "goToTargetButton";
			this.goToTargetButton.Size = new System.Drawing.Size(24, 23);
			this.goToTargetButton.TabIndex = 7;
			this.goToTargetButton.UseVisualStyleBackColor = true;
			// 
			// goToSourceButton
			// 
			this.goToSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.goToSourceButton.Image = ((System.Drawing.Image)(resources.GetObject("goToSourceButton.Image")));
			this.goToSourceButton.Location = new System.Drawing.Point(3, 558);
			this.goToSourceButton.Name = "goToSourceButton";
			this.goToSourceButton.Size = new System.Drawing.Size(24, 23);
			this.goToSourceButton.TabIndex = 6;
			this.goToSourceButton.UseVisualStyleBackColor = true;
			// 
			// MappingControlGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.exportButton);
			this.Controls.Add(this.goToTargetButton);
			this.Controls.Add(this.goToSourceButton);
			this.Controls.Add(this.trees);
			this.Name = "MappingControlGUI";
			this.Size = new System.Drawing.Size(994, 584);
			this.ResumeLayout(false);

		}
	}
}
