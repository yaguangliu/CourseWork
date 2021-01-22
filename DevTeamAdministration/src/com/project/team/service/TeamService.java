package com.project.team.service;
/**
 * @Description manage the development teams,including add member, remove member etc. 
 * @author yaguang
 *
 */

import com.project.team.domain.Architect;
import com.project.team.domain.Designer;
import com.project.team.domain.Employee;
import com.project.team.domain.Programmer;

public class TeamService {
	
	private static int counter = 1; // for the memberId
	private final int MAX_MEMBER = 5;// max members of the development team
	private Programmer[] team = new Programmer[MAX_MEMBER]; // save the development members
	private int total;// the actual number of members in the development team
	
	public TeamService() {
		super();
		
	}
	
	/**
	 * @Description get all development members
	 * @author yaguang
	 * @return Programmer[]
	 */
	public Programmer[] getTeam() {
		Programmer[] team = new Programmer[total];
		for(int i = 0; i < team.length; i++) {
			team[i] = this.team[i];
		}
		return team;
	}
	
	/**
	 * @Description add specific member to the team
	 * @author yaguang
	 * @param e
	 * @throws TeamException 
	 */
	public void addMember(Employee e) throws TeamException {
		// the number of programmers equals the MAX_SIZE
		if(total >= MAX_MEMBER) {
			throw new TeamException("The team is full, can not add again.");
		}
		
		// this employee is not a programmer
		if(!(e instanceof Programmer)) {
			throw new TeamException("This employee is not programmer, can not be added to team.");
		}
		
		// this programmer has been in the team
		if(isExist(e)) {
			throw new TeamException("This programmer has been in the team, can not be added to the team again");
		};
		
		// this programmer has been in another team		
		// this programmer is on vocation
		Programmer p = (Programmer)e;
		if("BUSY".equalsIgnoreCase(p.getStatus().getNAME())) {
			throw new TeamException("This programmer has been in some team.");
		}else if("VOCATION".equalsIgnoreCase(p.getStatus().getNAME())) {
			throw new TeamException("This programmer is on vocation.");
		}			
		 
		/*  
		 * maximum one architect for one team
		 * maximum two designers for one team
		 * maximum three programmers for one team 
		 */
		// get the number of architect, designer and programmer in the team
		int numOfArch = 0, numOfDe = 0, numOfPro = 0;
		for(int i = 0; i < total; i++) {
			if(team[i] instanceof Architect) {
				numOfArch++;
			}else if(team[i] instanceof Designer) {
				numOfDe++;
			}else {
				numOfPro++;
			}
		}
		
		if(p instanceof Architect) {
			if(numOfArch >= 1) {
				throw new TeamException("Maximum one architect in one team.");
			}
		}else if(p instanceof Designer) {
			if(numOfDe >= 2) {
				throw new TeamException("Maximum two designers in one team.");
			}
		}else {
			if(numOfPro >= 3) {
				throw new TeamException("Maximum three programmers in one team");
			}
		}
		
		// add p to the team
		team[total] = p;
		total++;
		
		// give value to p
		p.setStatus(Status.BUSY);
		p.setMemberId(counter++);
		
	}
	
	/**
	 * @Description check whether this programmer has been in the team
	 * @author yaguang
	 * @param e
	 * @return
	 */
	private boolean isExist(Employee e) {
		for(int i = 0; i < total; i++) {
			/*
			 * if(team[i].getId() == e.getId()) { return true; }
			 */
			return team[i].getId() == e.getId();
		}
		return false;
	}

	/**
	 * @Description remove specific member from team
	 * @param memberId
	 * @throws TeamException 
	 */
	public void removeMember(int memberId) throws TeamException {
		int i = 0;
		for(; i < total; i++) {
			if(team[i].getMemberId() == memberId) {
				team[i].setStatus(Status.FREE);
				break;
			}
		}
		
		 // not find the specific memberid
		 if(i == total) {
			 throw new TeamException("Can't find the employee with the memberId. Failed deletion.");
		 }
		
		// the latter element cover the previous one, in this way, realize the operation of removing element
		 for(int j = i + 1; j < total; j++) { team[j - 1] = team[j]; }
		 
		/*
		 * for(int j = i; j = total + 1; j++) { team[j] = team[j+1]; }
		 */
		 team[--total] = null;
		 
		
	}
	
	

}
