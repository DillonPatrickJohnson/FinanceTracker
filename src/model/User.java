package model;

import model.TransactionCategories.TransactionCategory;

import java.util.HashMap;

public class User {

	private String name;
	private HashMap<Transaction, TransactionCategory> transactions;

	public String getName() {
		return name;
	}

	public String getTransactionCategory(Transaction transaction) {
		return transactions.get(transaction).getTransactionCategory();
	}
}
