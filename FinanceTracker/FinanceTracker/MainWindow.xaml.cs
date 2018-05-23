using System.Windows;
using FinanceTracker.Model;

namespace FinanceTracker {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		User currentUser;

		public MainWindow() {
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();
		}

		private void importButton_Click(object sender, RoutedEventArgs e) {
			Parser parser = new Parser();
			parser.loadFile();
		}
	}
}
