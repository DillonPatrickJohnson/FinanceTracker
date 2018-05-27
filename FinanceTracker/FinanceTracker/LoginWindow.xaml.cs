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

		string path = "...\\users.json";
		User currentUser;

		public LoginWindow() {
			this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			InitializeComponent();
			usernameTextBox.Focus();
		}

		//Events
		private void loginButton_Click(object sender, RoutedEventArgs e) {
			Console.WriteLine("Attempting to login");
			if (CheckUserInput()) {
				if (FindUser(usernameTextBox.Text, passwordTextBox.Text) != null) {
					currentUser = FindUser(usernameTextBox.Text, passwordTextBox.Text);
					CompleteLogin();
				}
				else {
					//add alert
					usernameTextBox.Clear();
					passwordTextBox.Clear();
					incorrectLoginLabel.Content = "Incorrect Login";
				}
			}
		}

		private void createUserButton_Click(object sender, RoutedEventArgs e) {
			if (!CheckUserInput()) {
				return;
			}
			currentUser = CreateNewUser();
			WriteToFile(currentUser);
			CompleteLogin();
		}

		private void passwordTextBox_OnKeyDown(object sender, KeyEventArgs e) {
			if (e.Key == Key.Return || e.Key == Key.Enter) {
				loginButton_Click(this, new RoutedEventArgs());
			}
		}

		//Utility methods
		private bool CheckUserInput() {
			if (usernameTextBox.GetLineText(0) == "" || passwordTextBox.GetLineText(0) == "") {
				Console.WriteLine("Please enter username and password");
				return false;
			}
			return true;
		}

		private User CreateNewUser() {
			if (FindUser(currentUser.name, currentUser.password) != null) {
				Console.WriteLine("Cannot create a duplicate user.");
				return null;
			}
			return new User(usernameTextBox.GetLineText(0), passwordTextBox.GetLineText(0));
		}

		private User FindUser(string username, string password) {
			try {
				List<User> users = new List<User>();
				string fileText = File.ReadAllText(path);
				if (fileText.Length != 0) {
					users = JsonConvert.DeserializeObject<List<User>>(fileText);
				}
				foreach (User user in users) {
					if (user.name == username && user.password == password) {
						return user;
					}
				}
			} catch (Exception e) {
				Console.WriteLine("No users recorded, please create an account.");
			}
			return null;
		}
		
		private void WriteToFile(User currentUser) {
			List<User> users = new List<User>();

			//Load original json
			FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			fs.Close();

			//Append.
			string fileText = File.ReadAllText(path);
			if (fileText.Length != 0) {
				users = JsonConvert.DeserializeObject<List<User>>(fileText);
			}
			users.Add(currentUser);

			//Converting object to json using Newtonsoft JSON
			string json = JsonConvert.SerializeObject(users, Formatting.Indented);
			//Writing to file to save
			File.WriteAllText(@"...\\users.json", json);
		}

		private void CompleteLogin() {
			Session.user = currentUser;
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}
	}
}
