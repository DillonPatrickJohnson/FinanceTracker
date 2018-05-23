using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Model {
	class User {

		//Fields
		private string name;
		private string password;
		private List<Transaction> transactions;

		//Constructors
		public User(string name, string password) {
			this.name = name;
			this.password = password;
		}

		//Getters
		public string getName() {
			return name;
		}

		public string getPassword() {
			return password;
		}

		public List<Transaction> getTransactions() {
			return transactions;
		}
	}
}
