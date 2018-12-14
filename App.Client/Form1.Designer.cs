namespace App.Client
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.TboxRegistrationNumber = new System.Windows.Forms.TextBox();
			this.TboxBrand = new System.Windows.Forms.TextBox();
			this.TboxModel = new System.Windows.Forms.TextBox();
			this.TboxYear = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.checkBoxAvaliable = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(683, 404);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkBoxAvaliable);
			this.tabPage1.Controls.Add(this.btnCreate);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.TboxYear);
			this.tabPage1.Controls.Add(this.TboxModel);
			this.tabPage1.Controls.Add(this.TboxBrand);
			this.tabPage1.Controls.Add(this.TboxRegistrationNumber);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(675, 375);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 71);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// TboxRegistrationNumber
			// 
			this.TboxRegistrationNumber.Location = new System.Drawing.Point(44, 53);
			this.TboxRegistrationNumber.Name = "TboxRegistrationNumber";
			this.TboxRegistrationNumber.Size = new System.Drawing.Size(100, 22);
			this.TboxRegistrationNumber.TabIndex = 0;
			this.TboxRegistrationNumber.Text = "TboxRegistrationNumber";
			// 
			// TboxBrand
			// 
			this.TboxBrand.Location = new System.Drawing.Point(44, 96);
			this.TboxBrand.Name = "TboxBrand";
			this.TboxBrand.Size = new System.Drawing.Size(100, 22);
			this.TboxBrand.TabIndex = 1;
			this.TboxBrand.Text = "Brand";
			// 
			// TboxModel
			// 
			this.TboxModel.Location = new System.Drawing.Point(44, 137);
			this.TboxModel.Name = "TboxModel";
			this.TboxModel.Size = new System.Drawing.Size(100, 22);
			this.TboxModel.TabIndex = 2;
			this.TboxModel.Text = "TboxModel";
			// 
			// TboxYear
			// 
			this.TboxYear.Location = new System.Drawing.Point(44, 181);
			this.TboxYear.Name = "TboxYear";
			this.TboxYear.Size = new System.Drawing.Size(100, 22);
			this.TboxYear.TabIndex = 3;
			this.TboxYear.Text = "Year ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(44, 266);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 6;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// checkBoxAvaliable
			// 
			this.checkBoxAvaliable.AutoSize = true;
			this.checkBoxAvaliable.Location = new System.Drawing.Point(46, 218);
			this.checkBoxAvaliable.Name = "checkBoxAvaliable";
			this.checkBoxAvaliable.Size = new System.Drawing.Size(87, 21);
			this.checkBoxAvaliable.TabIndex = 7;
			this.checkBoxAvaliable.Text = "Avaliable";
			this.checkBoxAvaliable.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TboxYear;
		private System.Windows.Forms.TextBox TboxModel;
		private System.Windows.Forms.TextBox TboxBrand;
		private System.Windows.Forms.TextBox TboxRegistrationNumber;
		private System.Windows.Forms.CheckBox checkBoxAvaliable;
	}
}

