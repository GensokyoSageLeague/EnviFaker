using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnviFaker.Data;

namespace EnviFaker.UI {
	public partial class FormPictureBox : Form {
		public FormPictureBox() {
			InitializeComponent();
		}

		private void showHistogramToolStripMenuItem_Click(object sender, EventArgs e) {
			Histogram.ShowHistogram(pictureBox.Image as Bitmap);
		}
	}
}
