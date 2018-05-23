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
using System.IO;

namespace FinanceTracker.Views {
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window {

		User currentUser;

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
			currentUser = createNewUser();
			writeToFile(currentUser);
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
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
			return new User(usernameTextBox.GetLineText(0), passwordTextBox.GetLineText(0));
		}

		private bool doesUserExist() {
			
			return false;
		}

		private User findUser(string username, string password) {
			return null;
		}

		private void writeToFile(User currentUser) {
			string path = "...\\users.txt";
			
			//Load original CSV.
			FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			fs.Close();

			//Append.
			string line = string.Format(currentUser.getName() + "," + currentUser.getPassword() + Environment.NewLine);

			//TODO
			//write class as a JSON file for saving and loading.
		}
	}
}
