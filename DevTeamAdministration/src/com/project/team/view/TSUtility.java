package com.project.team.view;

import java.util.Scanner;

/**
 * @Description this class facilitates keyboard access
 * @author Yaguang
 * @version
 * @date November 12,2020
 *
 */
public class TSUtility {
	private static Scanner scanner = new Scanner(System.in);
	
	/**
	 * @Description This method reads the user's input from keyboard. 
	 * @author Yaguang
	 * @date
	 * @return 
	 */
	public static char readMenuSelection() {
		char c;
		for(; ;) {
			String str = readKeyBoard(1,false);
			c = str.charAt(0);
			if(c != '1' && c != '2' && c != '3' && c != '4') {
				System.out.print("Invalid input, please input again:");
			}else {
				break;
			}
		}
		return c;
	}
	
	/**
	 * @Description: This method gives information and wait until the user click "Enter"
	 * @author yaguang
	 * @date
	 */
	public static void readReturn() {
		System.out.print("Press 'Enter' to continue...");
		readKeyBoard(100,true);
		
	}
	
	/**
	 * @Description This method reads the integer,whose length is not more than 2, then return the integer
	 * @author yaguang
	 * @date
	 * @return int
	 */
	public static int readInt() {
		int in;
		for(; ;) {
			String str = readKeyBoard(2,false);
			try {
				in= Integer.parseInt(str);
				break;
			} catch (NumberFormatException e) {
				System.out.print("Invalid input, please input again: ");
			}
		}
		return in;
	}
	/**
	 * @Description This method reads 'Y' or 'N' from keyboard then returns the character
	 * @return char
	 */
	public static char readConfirmSelection() {
		char c;
		for(; ;) {
			String str = readKeyBoard(1,false).toUpperCase();
			c = str.charAt(0);
			if(c == 'Y' || c == 'N') {
				break;
			}else {
				System.out.print("Invalid input, please input again: ");
			}
		}
		return c;
	}
	
	private static String readKeyBoard(int limit, boolean blankReturn) {
		String line = "";
		
		while(scanner.hasNextLine()) {
			line = scanner.nextLine();
			if(line.length() == 0) {
				if(blankReturn) {
					return line;
				}else {
					continue;
				}				
			}
			
			if(line.length() < 1 || line.length() > limit) {
				System.out.print("The length of input is (not more than " + limit + " ),please input again: ");
				continue;
			}else {
				break;
			}			
		}
		return line;
	}
}
