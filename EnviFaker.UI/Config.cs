using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviFaker.UI {
	internal static class Config {
		// AppInfo
		public static string appNameTitile = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute))).Title;
		public static string appNameProduct = Application.ProductName;
		public static string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public static string appBuildTime = System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString();
	}
}
