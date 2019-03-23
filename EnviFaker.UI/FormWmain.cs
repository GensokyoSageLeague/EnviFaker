using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviFaker.UI {
	public partial class FormWmain : Form {
		public FormWmain() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			this.Text = Config.appNameTitile;
		}
	}
}
