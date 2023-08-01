namespace Tydzien6Lekcja13ZD
{
	partial class Main
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
			this.pbTrash = new System.Windows.Forms.PictureBox();
			this.pbImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbTrash)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pbTrash
			// 
			this.pbTrash.BackColor = System.Drawing.Color.White;
			this.pbTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbTrash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbTrash.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbTrash.Image = global::Tydzien6Lekcja13ZD.Properties.Resources.trash;
			this.pbTrash.Location = new System.Drawing.Point(177, 12);
			this.pbTrash.Name = "pbTrash";
			this.pbTrash.Size = new System.Drawing.Size(25, 25);
			this.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbTrash.TabIndex = 1;
			this.pbTrash.TabStop = false;
			this.pbTrash.Click += new System.EventHandler(this.pbTrash_Click);
			// 
			// pbImage
			// 
			this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImage.Image = global::Tydzien6Lekcja13ZD.Properties.Resources.default_image;
			this.pbImage.Location = new System.Drawing.Point(0, 0);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(214, 211);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImage.TabIndex = 0;
			this.pbImage.TabStop = false;
			this.pbImage.Click += new System.EventHandler(this.pictureBox_Click);
			this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
			this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 211);
			this.Controls.Add(this.pbTrash);
			this.Controls.Add(this.pbImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(230, 250);
			this.MinimumSize = new System.Drawing.Size(230, 250);
			this.Name = "Main";
			this.Text = "Zdjęcie";
			((System.ComponentModel.ISupportInitialize)(this.pbTrash)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.PictureBox pbTrash;
	}
}

