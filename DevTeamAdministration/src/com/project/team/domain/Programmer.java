package com.project.team.domain;

import com.project.team.service.Status;

public class Programmer extends Employee{
	
	private int memberId;// id for the developing team member
	private Status status = Status.FREE;
	private Equipment equipment;
	
	public Programmer() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Programmer(int id, String name, int age, double salary, Equipment equipment) {
		super(id, name, age, salary);
		
		this.equipment = equipment;
	}
	
	@Override
	public String toString() {
		
		return super.toString() + "\tProgrammer\t" + status + "\t\t\t" + equipment.getDescription();
	}



	public int getMemberId() {
		return memberId;
	}

	public void setMemberId(int memberId) {
		this.memberId = memberId;
	}

	public Status getStatus() {
		return status;
	}

	public void setStatus(Status status) {
		this.status = status;
	}

	public Equipment getEquipment() {
		return equipment;
	}

	public void setEquipment(Equipment equipment) {
		this.equipment = equipment;
	}
	
	public String getDetailsForTeam() {
		return memberId+"/" + getId() + "\t" + getName() + "\t" + getAge() + "\t" + getSalary() + "\tProgrammer" ;
	}
	
	
	

}
