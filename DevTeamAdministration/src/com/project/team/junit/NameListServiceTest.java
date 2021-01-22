package com.project.team.junit;

import org.junit.Test;

import com.project.team.domain.Employee;
import com.project.team.service.NameListService;
import com.project.team.service.TeamException;

/**
 * @Description test the NameListService class
 * @author yaguang
 *
 */
public class NameListServiceTest {
	
	@Test
	public void testGetAllEmployees() {
		NameListService service = new NameListService();
		Employee[] allEmployees = service.getAllEmployees();
		for(int i = 0; i < allEmployees.length; i++) {
			System.out.println(allEmployees[i]);
		}
	}
	
	@Test
	public void testGetEmployee() {
		NameListService service = new NameListService();
		int id = 15;
		try {
			Employee employee = service.getEmployee(id);
			System.out.println(employee);
		} catch (TeamException e) {
			System.out.println(e.getMessage());
		}
	}

}
