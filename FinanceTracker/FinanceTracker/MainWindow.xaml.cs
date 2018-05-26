using System.Windows;
using FinanceTracker.Model;
using FinanceTracker.Global;
using System;

namespace FinanceTracker {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		public MainWindow() {
			//Window starting in center of screen
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();

			//Printing information about the user
			Console.WriteLine("\nSession info:");
			Console.WriteLine("user.name = " + Session.user.name);
			Console.WriteLine("user.password = " + Session.user.password);
			Console.WriteLine("Total transactions = " + Session.user.transactions.Count + "\n");
		}

		private void importButton_Click(object sender, RoutedEventArgs e) {
			//Loading csv from the user
			Parser parser = new Parser();
			parser.loadFile();
		}
	}
}
