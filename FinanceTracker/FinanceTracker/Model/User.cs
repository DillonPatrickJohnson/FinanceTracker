using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Model {
	class User {

		//Fields
		public string name { get; set; }
		public string password { get; set; }
		public List<Transaction> transactions { get; set; }

		//Constructors
		public User() { }
		public User(string name, string password) {
			this.name = name;
			this.password = password;
			transactions = new List<Transaction>();
		}
	}
}
