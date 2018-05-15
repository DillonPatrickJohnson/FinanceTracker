package model;

import java.util.HashMap;

public class User {

	private String name;
	private HashMap<Transaction, String> transactions;

	public String getName() {
		return name;
	}

	public String getTransactionCategory(Transaction transaction) {
		return transactions.get(transaction);
	}
}
