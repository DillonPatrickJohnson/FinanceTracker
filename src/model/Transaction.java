package model;

import model.TransactionCategories.TransactionCategory;

import java.util.Date;

public class Transaction {

	//Fields
	private double amount;
	private String party;	//name of the store, person, etc. that the transaction is going to/came from.
	private Date date;
	private TransactionCategory category;

	//Methods
	public void DetermineCategory() {
		//based on the party String
	}

	//Getters and Setters
	public double getAmount() {
		return amount;
	}

	public void setAmount(double amount) {
		this.amount = amount;
	}

	public String getParty() {
		return party;
	}

	public void setParty(String party) {
		this.party = party;
	}

	public Date getDate() {
		return date;
	}

	public void setDate(Date date) {
		this.date = date;
	}
}
