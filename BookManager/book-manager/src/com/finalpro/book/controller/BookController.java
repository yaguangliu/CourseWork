package com.finalpro.book.controller;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.validation.Valid;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.boot.archive.scan.spi.ClassDescriptor.Categorization;
import org.hibernate.cfg.Configuration;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import com.finalpro.book.entity.Book;


@Controller
@RequestMapping("/book")
public class BookController {
	
	@RequestMapping("/showFormForAdding")
	public String showFormForAdding(Model theModel) {
		//create a new book
		Book newBook = new Book();
		
		// add to theModel
		theModel.addAttribute("book", newBook);
		
		// display the page for adding book
		return "add-book-page";
	}
	
	@RequestMapping("/addingBook")
	public String addingBook(@Valid @ModelAttribute("book") Book theBook, Model theModel,HttpServletRequest request) {
		
		// get the input date from client using HttpServletRequest
		String inputDate = request.getParameter("publishDate");
		
		// get the date of today 
		Date today = new Date();
		
		// transfer the string type date to the Date type
		Date inputDay = parseDate(inputDate);

		// compare the inputDay with today, if inputDay is later than today, the application will give some info
		if(inputDay.getTime() > today.getTime()) {
			return "add-book-page";
		}	
		
		// create the session factory
		SessionFactory factory = getFactory();
		
		// create the session
		Session session = factory.getCurrentSession();
		
		try {
			// start a transaction
			session.beginTransaction();
			
			
			//save the book object
			session.save(theBook);
			
			// commit transaction
			session.getTransaction().commit();
			
			// call the method with the parameters to display books
			listBooks(theModel, factory);
			
		} finally {
			factory.close();
		}
		
		// show the books 
		return "list-all-books";
	}	
	
	@RequestMapping("/listAllBooks")
	public String listAllBooks(Model theModel) {
		// create factory
        SessionFactory factory = getFactory();
		
		try {
			// call the method with the parameters to display books
			listBooks(theModel, factory);
			
		} finally {
			factory.close();
		}
		return "list-all-books";	
	}
	
	/**
	 * 
	 * @return a web page for searching books by id
	 */
	@RequestMapping("/showPageForGettingById")
	public String showGetABookForm() {
		
		return "get-a-book";
	}
	
	@RequestMapping("/getABookById")
	public String getABookById(HttpServletRequest request, Model theModel) {
		
		// get input data from client using HttpServeletRequest
		String idStr = request.getParameter("id");
		
		// create a regex pattern to validate the book id
		String pattern = "^[1-9]\\d*$";
		
		// if input book id is not positive integer, the sever won't process your request
		if(!idStr.matches(pattern)) {
			return "get-a-book";
		}					
		
		// call method getFactory() to create factory
		SessionFactory factory = getFactory();
		
		// create session
		Session session = factory.getCurrentSession();
		
		try {
			// begin transaction
			session.beginTransaction();
			
			// get the bookList with the id
			List<Book> bookList = session.createQuery("from Book b where b.id=" + idStr ).getResultList();
			
			// add the list to theModel
			theModel.addAttribute("books",bookList);
			
			// commit transaction
			session.getTransaction().commit();			
			
		} finally {
			factory.close();
		}
		return "list-all-books";
	}
	
	/**
	 * 
	 * @return the web page for searching
	 */
	@RequestMapping("/showPageForSearching")
	public String showPageForSearching() {
		return "search-book-page";
	}
	
	/**
	 * using HttpServletRequest to get the parameters from the client side 
	 * 
	 * validate query conditions and show the error message
	 * 
	 * there are seven fields to consider, I took the fields: author, publisher and pubishDate as the main conditions
	 * and took the fields authorChoice, publisherChoice and operator as the nested conditions to get various query 
	 * statements. 
	 *
	 * @param request
	 * @param theModel
	 * @return the books according to the user's input conditions
	 * @throws ParseException 
	 */
	@RequestMapping("/searchBooks")
	public String searchBooks(HttpServletRequest request, Model theModel) throws ParseException {
		
		// get all the parameters from the web page
		String author = request.getParameter("authorName");
		String authorChoice = request.getParameter("authorChoice");
		String publisher = request.getParameter("publisherName");
		String publisherChoice = request.getParameter("publisherChoice");
		String publishDate = request.getParameter("publishDate");
		String operator = request.getParameter("operators");
		String later = request.getParameter("laterDate");	
		
		// create and concatenate queryStr
		String queryStr = "from Book b where ";
		
		// if the main three fields are empty, the app will stay at the same page
		if(author == "" && publisher == "" && publishDate == "") {
			return "search-book-page";
		}
		
		/* author is not empty, the other two are empty, then check the nested conditions to 
		 * get the queryStr, otherwise the app won't send data
		 */
		if(author != "" && publisher == "" && publishDate == "") {
			if(authorChoice == "") {
				queryStr += "b.authorName LIKE '%" + author + "%' ";
			}else {
				return "search-book-page";
			}
			if(publisherChoice != "") {
				return "search-book-page";
			}
			
		}
		
		/*
		 * author and publisher are not empty, then if the authorChoice is not empty, get the queryStr, 
		 * otherwise stay at the same page and input the condition again  
		 */
		if(author != "" && publisher != "" && publishDate == "") {
			if(authorChoice != "") {
				queryStr += "b.authorName LIKE '%" + author + "%' " + authorChoice + " b.publisherName LIKE '%" + publisher + "%' ";
			}else {
				return "search-book-page";
			}				
		}
		
		/*
		 * author and publishDate are not empty, then if the authorChoice is not empty, check the value of operator field, 
		 * if it is 'between',validate the date. if the value is not 'between',get the queryStr. 
		 * the authorChoice is empty, stay at the page and input conditions again. 
		 * 
		 */
		if(author != "" && publisher == "" && publishDate != "") {
			if(authorChoice != "") {
				if(operator.equals("between")) {
					SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
					Date date1 = sdf.parse(publishDate);
					Date date2 = sdf.parse(later);
					if(date1.getTime() > date2.getTime()) {
						return "search-book-page";
					}
					queryStr += "b.authorName LIKE '%" + author + "%' " + authorChoice +  " b.publishDate " + operator + " '" + publishDate + "' " + "and" + "'" + later + "'"; 
				}else {
					queryStr += "b.authorName LIKE '%" + author + "%' " + authorChoice + " b.publishDate " + operator + " '" + publishDate + "'";
				}
				
			}else {
				return "search-book-page";
			}				
		}
		
		/*
		 * publisher and publishDate are not empty, then if the publisherChoice is not empty, check the value of operator field, 
		 * if it is 'between',validate the date. if the value is not 'between',get the queryStr. 
		 * the publisherChoice is empty, stay at the page and input conditions again. 
		 * 
		 */
		if(author == "" && publisher != "" && publishDate != "") {
			if(publisherChoice != "") {
				if(operator.equals("between")) {
					SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
					Date date1 = sdf.parse(publishDate);
					Date date2 = sdf.parse(later);
					if(date1.getTime() > date2.getTime()) {
						return "search-book-page";
					}
					queryStr += " b.publisherName LIKE '%" + publisher + "%' " + publisherChoice + " b.publishDate " + operator + " '" + publishDate + "' " + "and" + "'" + later + "'"; 
				}else {
					queryStr += " b.publisherName LIKE '%" + publisher + "%' " + publisherChoice + " b.publishDate " + operator + " '" + publishDate + "'";
				}
				
			}else {
				return "search-book-page";
			}				
		}
		
		/*
		 * publisher is not empty, if the publisherChoice is, get the queryStr. 
		 * otherwise input conditions again. morevoer, if the authorChoice is not empty, 
		 * input conditions again too. 
		 * 		 
		 */
		if(author == "" && publisher != "" && publishDate == "") {
			if(publisherChoice == "") {
				queryStr += " b.publisherName LIKE '%" + publisher + "%' ";
			}else {
				return "search-book-page";
			}	
			if(authorChoice != "") {
				return "search-book-page";
			}
		}
		
		/*
		 * publishDate is not empty, if the publisherChoice and authorChoice are empty,check the value of operator,
		 * if it is 'between',validate the date. 
		 */
		if(author == "" && publisher == "" && publishDate != "") {
			if(publisherChoice == "" && authorChoice == "") {
				if(operator.equals("between")) {
					SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
					Date date1 = sdf.parse(publishDate);
					Date date2 = sdf.parse(later);
					if(date1.getTime() > date2.getTime()) {
						return "search-book-page";
					}
					queryStr += " b.publishDate " + operator + " '" + publishDate + "' " + "and" + "'" + later + "'"; 
				}else {
					queryStr += " b.publishDate " + operator + " '" + publishDate + "'";
				}
				
			}else {
				return "search-book-page";
			}				
		}
		
		/*
		 * three main fields are not empty, and the authorChoice and publisherChoice are not empty, check the value of 
		 * operator,if it is 'between',validate it. 
		 * if operator is 'between' and the input dates are valid, get the queryStr
		 * if the operator is not 'between',get another queryStr
		 * if the authorChoice or publisherChoice is empty, stay at the page and input conditions again.
		 * 
		 */
		if(author != "" && publisher != "" && publishDate != "") {
			if(publisherChoice != "" && authorChoice != "") {
				if(operator.equals("between")) {
					SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
					Date date1 = sdf.parse(publishDate);
					Date date2 = sdf.parse(later);
					if(date1.getTime() > date2.getTime()) {
						return "search-book-page";
					}
					queryStr += "b.authorName LIKE '%" + author + "%' " + authorChoice + " b.publisherName LIKE '%" + publisher + "%' " + publisherChoice +" b.publishDate " + operator + " '" + publishDate + "' " + "and" + "'" + later + "'"; 
				}else {
					queryStr += "b.authorName LIKE '%" + author + "%' " + authorChoice + " b.publisherName LIKE '%" + publisher + "%' " + publisherChoice + " b.publishDate " + operator + " '" + publishDate + "'";
				}
				
			}else {
				return "search-book-page";
			}				
		}
	
		// create factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();
		
		try {
			session.beginTransaction();				
			
			// get the bookList and add them to the model 
			List<Book> bookList = session.createQuery(queryStr).getResultList();
		
			theModel.addAttribute("books", bookList);
			
			session.getTransaction().commit();			
			
		} finally {
			factory.close();
		}
		
		return "list-all-books";
	}
	
	/**
	 * to remove all the data from the table permanently
	 * @param theModel
	 * @return a book list page without any book
	 */
	@RequestMapping("/deleteAllBooks")
	public String deleteAllBooks(Model theModel) {
		// create factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();
		
		try {
			session.beginTransaction();
			
			// use "truncate table Book" statement to delete all records without exception, zero pages are left in the table.
			session.createSQLQuery("truncate table Book").executeUpdate();
			
			// commit transaction
			session.getTransaction().commit();
			
			// call the method to display the empty table with "no record found"
			listBooks(theModel, factory);			
			
		} finally {
			factory.close();
		}
		
		return "list-all-books";
	}
	
	/**
	 * 
	 * @return a page for updating a field
	 */
	@RequestMapping("/showUpdatePage")
	public String showUpdatePage() {
		
		return "update-book-page";
	}
	
	/**
	 * update the specified field 
	 * @param request
	 * @param theModel
	 * @return a list of books with new value for the specified column
	 */
	@RequestMapping("/updateBooks")
	public String updateBooks(HttpServletRequest request, Model theModel) {
		
		// get data from client side using HttpServletRequest
		String fieldUpdate = request.getParameter("fieldChoice");
		String newValue = request.getParameter("newValue");
		
		// check the value of the field the user wants to update, if it is empty, stay the page 
		if(fieldUpdate == "" || newValue == "") {
			return "update-book-page";
		}	
		if("publishDate".equals(fieldUpdate)) {
			// get the date of today 
			Date today = new Date();
			
			// parse string to date
			Date inputDay = parseDate(newValue);
			
			// compare the inputDay with today, if inputDay is later than today, the server won't get the data
			if(inputDay.getTime() > today.getTime()) {
				return "update-book-page";
			}
		}

		// create factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();		
		
		try {
			
			// if it is not empty, begin transaction 
			session.beginTransaction();
			
			// update the selected field to the new value
			session.createQuery("update Book b set b." + fieldUpdate + " = '" + newValue + "'").executeUpdate();
			
			// commit transaction
			session.getTransaction().commit();
			
			// call method listBooks to display the updated result
			listBooks(theModel, factory);
			
		   } finally {
				factory.close();
		   }
		
		return "list-all-books";		
	}

	
	/**
	 * update book by id
	 * @param theId
	 * @param theModel
	 * @return a page for updating the book with the id
	 */
	@RequestMapping("/showPageForUpdatingById")
	public String showPageForUpdatingById(@RequestParam("bookId") int theId, Model theModel) {
		
		// create factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();
		
		try {
			
			// begin transaction
			session.beginTransaction();
			
			// get the book with specified id
			Book theBook = session.get(Book.class, theId);
			
			// add the object to the model
			theModel.addAttribute("book",theBook);
			
			// commit transaction
			session.getTransaction().commit();			
			
		} finally {
			factory.close();
		}
		return "update-by-id";
	}
	
	@RequestMapping("/updatingBookById")
	public String updatingBookById(@RequestParam("bookId") int theId, Model theModel, @ModelAttribute("book") Book newBook) {
		
		// create session factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();
		
		try {
			// begin transaction
			session.beginTransaction();
			
			// get the book to be updated
			Book theBook = session.get(Book.class, theId);
			newBook.setId(theId);
			Date newDate = newBook.getPublishDate();
			Date today = new Date();
			if(newDate.getTime() > today.getTime()) {
				return "update-by-id";
			}
			
			// set the new value to the book
			theBook.setAuthorName(newBook.getAuthorName());			
			theBook.setPublishDate(newBook.getPublishDate());			
			theBook.setPublisherName(newBook.getPublisherName());
			
			//commit transaction
			session.getTransaction().commit();
			
			//create new session to display the updated book 
			Session session2 = factory.getCurrentSession();
			session2.beginTransaction();
			
			// get the bookList with the specified id
			List<Book> bookList = session2.createQuery("from Book b where b.id=" + theId).getResultList();
			theModel.addAttribute("books",bookList);
			session2.getTransaction().commit();	           
			 
		} finally {
			
			// close factory
			factory.close();
		}
		return "list-all-books";
	}
	
	/**
	 * delete one book with specified id
	 * @param theId
	 * @param theModel
	 * @return a book list without the deleted book
	 */
	@RequestMapping("/deleteBookById")
	public String deleteBookById(@RequestParam("bookId") int theId, Model theModel) {
		
		//create factory and session
		SessionFactory factory = getFactory();
		Session session = factory.getCurrentSession();
		
		try {
			
			// begin transaction
			session.beginTransaction();
			
			// get the book with the id
			Book theBook = session.get(Book.class, theId);
			
			//delete the book 
			session.delete(theBook);
			
			// get the bookList after the deletion
			List<Book> bookList = session.createQuery("from Book").getResultList();
			
			// add object to the model
			theModel.addAttribute("books",bookList);
			
			// commit transaction
			session.getTransaction().commit();
			
		} finally {
			factory.close();
		}
		return "list-all-books";
	}

	/**
	 * create a session factory
	 * @return factory
	 */
	private SessionFactory getFactory() {
		SessionFactory factory = new Configuration().configure("hibernate.cfg.xml")
								.addAnnotatedClass(Book.class).buildSessionFactory();
		return factory;
	}
	
	/**
	 * iterate books and add the list to the model
	 * @param theModel
	 * @param factory
	 */
	private void listBooks(Model theModel, SessionFactory factory) {
		Session session = factory.getCurrentSession();
		session.beginTransaction();
		List<Book> bookList = session.createQuery("from Book").getResultList();
		theModel.addAttribute("books",bookList);
		session.getTransaction().commit();
	}
	
	/**
	 * parse the date to the same format
	 * @param dateValue
	 * @return Date type value
	 */
	private Date parseDate(String dateValue) {
		// create an instance of SimpleDateFormat class
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
		
		// parse the inputDate string to Date format using sdf formatter
		Date inputDay = new Date();
		try {
			inputDay = sdf.parse(dateValue);
			
		} catch (ParseException e) {
			e.printStackTrace();
		}
		return inputDay;
	}
}
