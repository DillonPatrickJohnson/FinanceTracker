using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Model {
	class User {

		//Fields
		private string name;
		private List<Transaction> transactions;

		//Getters
		public string getName() {
			return name;
		}

		public List<Transaction> getTransactions() {
			return transactions;
		}
	}
}
