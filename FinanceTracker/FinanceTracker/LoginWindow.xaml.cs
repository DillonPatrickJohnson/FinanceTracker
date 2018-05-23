using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FinanceTracker.Model;

namespace FinanceTracker.Views {
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window {
		public LoginWindow() {
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();
		}

		private void loginButton_Click(object sender, RoutedEventArgs e) {
			if (!checkUserInput()) {
				return;
			}
		}

		private void createUserButton_Click(object sender, RoutedEventArgs e) {
			if (!checkUserInput()) {
				return;
			}
		}

		//Utility methods
		private bool checkUserInput() {
			if (usernameTextBox.GetLineText(0) == "" || passwordTextBox.GetLineText(0) == "") {
				Console.WriteLine("Please enter username and password");
				return false;
			}
			return true;
		}

		private User createNewUser() {
			if (doesUserExist()) {
				Console.WriteLine("Cannot create a duplicate user.");
				return null;
			}
			return new User();
		}

		private bool doesUserExist() {
			if (true) {
				return true;
			}
			return false;
		}
	}
}
