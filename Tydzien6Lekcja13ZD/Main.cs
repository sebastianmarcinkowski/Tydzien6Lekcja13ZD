using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tydzien6Lekcja13ZD
{
	public partial class Main : Form
	{
		private string _imagePath = Path.Combine(
			Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
			"image.png");

		private bool _imageIsSet = false;

		public Main()
		{
			InitializeComponent();
			SetImageIfSet();
			HideTrash();
		}

		private void SetImageIfSet()
		{
			if (File.Exists(_imagePath))
			{
				// Po wykonaniu tego fragmentu przy próbie usunięcia pliku image.png rzucany jest wyjątek informujący o tym że plik jest używany przez inny proces.
				pbImage.Image = Image.FromFile(_imagePath);
				

				_imageIsSet = true;

			}
		}

		public void HideTrash()
		{
			pbTrash.Visible = false;
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			using (var openFD = new OpenFileDialog())
			{
				openFD.Filter = "Pliki obrazów (*.jpg, *.jpeg, *.gif) | *.jpg; *.jpeg; *.gif";
				if (openFD.ShowDialog() == DialogResult.OK)
				{
					pbImage.Image = new Bitmap(openFD.FileName);
					_imageIsSet = true;

					pbImage.Image.Save(_imagePath);
				}
			}
		}

		private void pbImage_MouseEnter(object sender, EventArgs e)
		{
			if (_imageIsSet)
				pbTrash.Visible = true;
		}

		private async void pbImage_MouseLeave(object sender, EventArgs e)
		{
			if (_imageIsSet)
				await HideTrashAsync();
		}

		private async Task HideTrashAsync()
		{
			var action = new Action(ActionDelegateHideTrash);
			await Task.Run(action);
		}

		public void ActionDelegateHideTrash()
		{
			Thread.Sleep(3000);
			if (_imageIsSet)
				HideTrash();
		}

		private void pbTrash_Click(object sender, EventArgs e)
		{
			pbImage.Image = Tydzien6Lekcja13ZD.Properties.Resources.default_image;
			_imageIsSet = false;
			HideTrash();

			if (File.Exists(_imagePath))
				File.Delete(_imagePath);
		}
	}
}
