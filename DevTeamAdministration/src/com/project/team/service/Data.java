package com.project.team.service;

public class Data {
	public static final int EMPLOYEE = 10;
	public static final int PROGRAMMER = 11;
	public static final int DESIGNER = 12;
	public static final int ARCHITECT = 13;
	
	public static final int PC = 21;
	public static final int NOTEBOOK = 22;
	public static final int PRINTER = 23;
	
	/*
	 * Employee  :  10, id, name, age, salary
	 * Programmer:  11, id, name, age, salary
	 * Designer  :  12, id, name, age, salary, bonus
	 * Architect :  13, id, name, age, salary, bonus, stock
	 */
	public static final String[][] EMPLOYEES = {
			{"10","1","Bill","22","3000"},
			{"13","2","Adam","32","18000","15000","2000"},
			{"11","3","Alex","26","7000"},
			{"11","4","Zuck","35","7300"},
			{"12","5","Grace","29","10000","5000"},
			{"11","6","Darun","35","6800"},
			{"12","7","William","32","10800","5200"},
			{"13","8","Musk","46","19800","15000","2500"},
			{"12","9","Charlie","31","9800","5500"},
			{"11","10","Tommy","42","6600"},
			{"11","11","Frank","39","7100"},
			{"12","12","Devin","46","9600","4800"},
	};
	
	/*
	 * PC      : 21, model, display
	 * NOTEBOOK: 22, model, price
	 * PRINTER : 23, name, type
	 */
	public static final String[][] EQUIPMENTS = {
			{},
			{"22", "Lenovo Flex", "849.99"},
			{"21", "HP", "21.5 HD"},
			{"21", "HP", "24 HD"},
			{"23", "Canon2900", "Laser"},
			{"21", "ASUS", "24 HD"},
			{"21", "Acer", "24 HD"},
			{"23", "HP M130NW", "Laser"},
			{"22", "HP X360", "899.99"},
			{"21", "HP", "21.5 HD"},
			{"21", "HP", "24 HD"},
			{"22", "Microsoft Surface", "1749.99"},
	};
}
