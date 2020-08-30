namespace WinFormsTests.Forms
{
	partial class PassTestForm
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
			this.TestList = new System.Windows.Forms.ListBox();
			this.PassTest = new System.Windows.Forms.Button();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TestList
			// 
			this.TestList.FormattingEnabled = true;
			this.TestList.Location = new System.Drawing.Point(0, 0);
			this.TestList.Name = "TestList";
			this.TestList.Size = new System.Drawing.Size(477, 446);
			this.TestList.TabIndex = 0;
			this.TestList.SelectedIndexChanged += new System.EventHandler(this.TestList_SelectedIndexChanged);
			// 
			// PassTest
			// 
			this.PassTest.Location = new System.Drawing.Point(483, 12);
			this.PassTest.Name = "PassTest";
			this.PassTest.Size = new System.Drawing.Size(305, 23);
			this.PassTest.TabIndex = 1;
			this.PassTest.Text = "Пройти выбранный тест";
			this.PassTest.UseVisualStyleBackColor = true;
			this.PassTest.Click += new System.EventHandler(this.PassTest_Click);
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimeLabel.Location = new System.Drawing.Point(483, 165);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(0, 31);
			this.TimeLabel.TabIndex = 2;
			// 
			// PassTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.PassTest);
			this.Controls.Add(this.TestList);
			this.Name = "PassTestForm";
			this.Text = "Пройти тест";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox TestList;
		private System.Windows.Forms.Button PassTest;
		private System.Windows.Forms.Label TimeLabel;
	}
}