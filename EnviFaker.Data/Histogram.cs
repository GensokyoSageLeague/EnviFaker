using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviFaker.Data {
	public static class Histogram {
		public static void ShowHistogram(Bitmap bitmap) {
			var formHistogram = new FormHistogram();
			formHistogram.bmpHist = bitmap;
			formHistogram.ShowDialog();
		}
	}
}
