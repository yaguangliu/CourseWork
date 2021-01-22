package com.project.team.view;

import com.project.team.domain.Employee;
import com.project.team.domain.Programmer;
import com.project.team.service.NameListService;
import com.project.team.service.TeamException;
import com.project.team.service.TeamService;

public class TeamView {
	
	private NameListService listSvc = new NameListService();
	private TeamService teamService = new TeamService();
	
	public void enterMainMenu() {
		boolean loopFlag = true;
		char menu = '0';
		while(loopFlag) {
			if(menu != '1') {
				listAllEmployees();
			}
			
			System.out.print("1-List Teams 2-Add Team Member 3-Remove Team Member 4-Exit Please choose(1-4): ");
		    menu = TSUtility.readMenuSelection();
			switch (menu) {
			case '1':
				getTeam();
				break;
			case '2':
				addMember();
				break;
			case '3':
				deleteMember();
				break;
			case '4':
				System.out.print("Are you sure to exit(Y/N): ");
				char isExit = TSUtility.readConfirmSelection();
				if(isExit == 'Y') {
					loopFlag = false;
				}
				break;

			}
		}
		
	}
	
	/**
	 * @Description list all information of employees
	 * @author yaguang
	 */
	private void listAllEmployees() {
		System.out.println("------------------------------------ Development Team Administration -------------------------------\n");
		Employee[] allEmployees = listSvc.getAllEmployees();
		if(allEmployees == null || allEmployees.length == 0) {
			System.out.println("No employee record.");
		}else {
			System.out.println("ID\tName\tAge\tSalary\tPosition\tStatus\tBonus\tStock\tEquipment");
			for(int i = 0; i < allEmployees.length; i++) {
				System.out.println(allEmployees[i]);
			}
		}
		System.out.println("----------------------------------------------------------------------------------------------------");
	}
	
	private void getTeam() {
		System.out.println("------------------------- Development Team -------------------------");
		Programmer[] team = teamService.getTeam();
		if(team == null || team.length == 0) {
			System.out.println("There is no member in the team presently.");
			
		}else {
			System.out.println("TID/ID\tName\tAge\tSalary\tPosition\tBonus\tStock\n");
			for(int i = 0; i < team.length; i++) {
				System.out.println(team[i].getDetailsForTeam());
			}
		}
		
		System.out.println("--------------------------------------------------------------------");
		
	}
	
	private void addMember() {
		System.out.println("---------------------------- Add Member --------------------------");
		System.out.print("Please enter the employee ID you want to add to the team: ");
		int id = TSUtility.readInt();
		try {
			Employee employee = listSvc.getEmployee(id);
			teamService.addMember(employee);
			System.out.println("Add successfully.");
			TSUtility.readReturn();
		} catch (Exception e) {
			System.out.println("Add Failure: " + e.getMessage());
		}	
		
	}
	private void deleteMember() {
		System.out.println("---------------------------- Delete Member --------------------------");
		System.out.print("Please enter the memberId you want to delete from the team: ");
		int memberId = TSUtility.readInt();
		System.out.print("Are you sure to delete(Y/N): ");
		char isDelete = TSUtility.readConfirmSelection();
		if(isDelete == 'N') {
			return;
		}
		try {
			teamService.removeMember(memberId);
			System.out.println("Delete successfully.");
			TSUtility.readReturn();
		} catch (TeamException e) {
			System.out.println("Failure deletion: " + e.getMessage());
		}
		
	}
	public static void main(String[] args) {
		TeamView teamView = new TeamView();
		teamView.enterMainMenu();
	}

}
