using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace EnviFaker.UI {
	public partial class FormWmain : Form {
		public FormWmain() {
			InitializeComponent();
		}

		public List<Image> images = new List<Image>();
		public List<FormPictureBox> forms = new List<FormPictureBox>();

		private void Form1_Load(object sender, EventArgs e) {
			this.Text = Config.appNameTitile;
			this.Height = menuStrip.Height + 50;
		}

		private void openImageToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "支持的图片格式|*.jpg;*.jepg;*.png;*.bmp;*.gif";
			openFileDialog.Title = "打开";
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				Bitmap bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
				images.Add(bitmap);

				FormPictureBox form = new FormPictureBox();
				forms.Add(form);
				form.Show();
				form.pictureBox.Image = bitmap.Clone() as Image;
				form.Text = openFileDialog.SafeFileName;
			}
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			new FormOptions().ShowDialog();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("To be placed...", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
