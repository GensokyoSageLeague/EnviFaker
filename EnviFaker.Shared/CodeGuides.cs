// 在commit前利用vs的重构功能删掉不必要的using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 使用XML注释注释类、字段、属性、函数、函数参数等
// 使用普通注释注释其他内容

/// <summary>
/// 示例命名空间
/// </summary>
/// <remarks>
/// 该源文件不参与编译
/// </remarks>
namespace EnviFaker.Shared {
	/// <summary>
	/// 示例类
	/// </summary>
	public class ClassExample {
		/// <summary>
		/// 字段声明
		/// </summary>
		int FieldExample;

		/// <summary>
		/// 属性声明
		/// </summary>
		/// <remarks>
		/// 不要在属性里使用lambda表达式！！
		/// </remarks>
		public int PropertyExample {
			get {
				return _PropertyExample;
			}
			set {
				_PropertyExample = value;
			}
		}

		int _PropertyExample;

		/// <summary>
		/// 示例公开函数
		/// </summary>
		/// <param name="para">传入参数para</param>
		public void FuncExample(int para) {
			// 普通注释的内容与双斜杠需要空一个空格
			// 表达式运算符、变量名等要素间加入空格
			var TempVar = 1;

			// 循环、判断等包含多行语句的程序块
			for (int i = 0; i < FieldExample; i++) {
				PrivateFunc(i);
				PrivateFunc(i);
			}

			if (true) {
				PrivateFunc(FieldExample);
				PrivateFunc(FieldExample);
			}

			// 只有单个语句的循环、判断
			for (int i = 0; i < length; i++)
				PrivateFunc(i);

			if (true)
				PrivateFunc(FieldExample);
		}

		/// <summary>
		/// 示例私有函数
		/// </summary>
		/// <param name="para"></param>
		private void PrivateFunc(int para) {
			return;
		}
	}
}
