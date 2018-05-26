using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FinanceTracker {

	class Parser {

		string filename = "";

		public void loadFile() {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = ".csv";
			ofd.ShowDialog();
			filename = ofd.FileName;
			Console.WriteLine("Selected the file: " + filename);
		}
	}
}
