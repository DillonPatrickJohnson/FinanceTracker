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
using FinanceTracker.Global;
using System.IO;
using Newtonsoft.Json;

namespace FinanceTracker.Views {
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window {

		User currentUser;

		public LoginWindow() {
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();
			usernameTextBox.Focus();
		}

		//Events
		private void loginButton_Click(object sender, RoutedEventArgs e) {
			Console.WriteLine("Attempting to login");
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
			Session.user = currentUser;
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}

		private void passwordTextBox_OnKeyDown(object sender, KeyEventArgs e) {
			if (e.Key == Key.Return || e.Key == Key.Enter) {
				loginButton_Click(this, new RoutedEventArgs());
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
			return new User(usernameTextBox.GetLineText(0), passwordTextBox.GetLineText(0));
		}

		private bool doesUserExist() {
			
			return false;
		}

		private User findUser(string username, string password) {
			return null;
		}

		//todo
		private void writeToFile(User currentUser) {
			string path = "...\\users.json";
			
			//Load original json
			FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			fs.Close();

			//Append.
			string line = string.Format(currentUser.name + "," + currentUser.password + Environment.NewLine);

			//Converting object to json using Newtonsoft JSON
			string json = JsonConvert.SerializeObject(currentUser);
			//Writing to file to save
			File.AppendAllText(@"...\\users.json", json);
		}
	}
}
