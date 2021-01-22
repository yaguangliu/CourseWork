package com.project.team.service;
/**
 * @Description custom exception class
 * @author yaguang
 *
 */
public class TeamException extends Exception{
	
	static final long serialVersionUID = -3387514229923L;

	public TeamException() {
		super();
		
	}
	
	public TeamException(String msg) {
		super(msg);
	}

}
