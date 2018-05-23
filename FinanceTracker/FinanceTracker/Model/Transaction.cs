using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Model {
	class Transaction {

		//Fields
		private string participant;
		private DateTime date;
		private double amount;
		private string type;

		//Constructor
		public Transaction(string participant, DateTime date, double amount) {
			this.participant = participant;
			this.date = date;
			this.amount = amount;
		}

		//Getters
		public string getParticipant() {
			return participant;
		}

		public DateTime getDate() {
			return date;
		}

		public double getAmount() {
			return amount;
		}
		
		public string getType() {
			return type;
		}
	}
}
