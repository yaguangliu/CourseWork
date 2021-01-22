package com.project.team.service;
/**
 * @Description encapsulate the data of Data class into the array Employee[], and provide some operations for Employee[]
 * @author yaguang
 *
 */

import com.project.team.domain.Architect;
import com.project.team.domain.Designer;
import com.project.team.domain.Employee;
import com.project.team.domain.Equipment;
import com.project.team.domain.NoteBook;
import com.project.team.domain.PC;
import com.project.team.domain.Printer;
import com.project.team.domain.Programmer;

import static com.project.team.service.Data.*;

public class NameListService {
	
	private Employee[] employees;

	/**
	 * initialize the employees array and elements
	 */
	public NameListService() {
		/*
		 * 1.provide the employees array according to Data class
		 * 2.create Employee, Designer, Programmer, Architect objects
		 * 3.save the objects to array
		 * 
		 */
		employees = new Employee[EMPLOYEES.length];
		for(int i = 0; i < employees.length; i++) {
			
			// get the employee type
			int type = Integer.parseInt(EMPLOYEES[i][0]);
			
			// get the basic information for employee
			int id = Integer.parseInt(EMPLOYEES[i][1]);
			String name = EMPLOYEES[i][2];
			int age = Integer.parseInt(EMPLOYEES[i][3]);
			double salary = Double.parseDouble(EMPLOYEES[i][4]);
			Equipment equipment;
			double bonus;
			int stock;
			
			switch(type) {
			case EMPLOYEE:
				employees[i] = new Employee(id,name,age,salary);
				break;
			case PROGRAMMER:
				equipment = createEquipment(i);
				
				employees[i] = new Programmer(id,name,age, salary,equipment);
				break;
			case DESIGNER:
				equipment = createEquipment(i);
				bonus = Double.parseDouble(EMPLOYEES[i][5]);
				employees[i] = new Designer(id, name, age, salary, equipment, bonus);
				break;
			case ARCHITECT:
				equipment = createEquipment(i);
				bonus = Double.parseDouble(EMPLOYEES[i][5]);
				stock = Integer.parseInt(EMPLOYEES[i][6]);
				employees[i] = new Architect(id, name, age, salary, equipment, bonus, stock);
				break;
			}
		}
	}
	
	/**
	 * @Description get the equipment of the specific employee 
	 * @param index
	 * @return Equipment
	 */
	private Equipment createEquipment(int index) {
		int key = Integer.parseInt(EQUIPMENTS[index][0]);
		String modelOrName = EQUIPMENTS[index][1];
		
		switch (key) {
		case PC:
			String display = EQUIPMENTS[index][2];
			return new PC(modelOrName,display);
		case NOTEBOOK:
			double price = Double.parseDouble(EQUIPMENTS[index][2]);
			return new NoteBook(modelOrName,price);
		case PRINTER:
			String type = EQUIPMENTS[index][2];
			return new Printer(modelOrName,type);
		}
		return null;
		
	}
	/**
	 * @Description get all employees
	 * @return
	 */
	public Employee[] getAllEmployees() {
		return employees;
	}
	/**
	 * @Description get the employee with specific id
	 * @param id
	 * @return employee
	 * @throws TeamException 
	 */
	public Employee getEmployee(int id) throws TeamException {
		for(int i = 0; i < employees.length; i++) {
			if(employees[i].getId() == id) {
				return employees[i];
			}
		}
		throw new TeamException("Can't find the employee with this id");
	}
	
	

}
