<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">

    <!--Awesome font CSS-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css">

    <!--Google font CSS-->
    <link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Open+Sans&family=Parisienne&display=swap" 
    rel="stylesheet">  
    
    <!-- jQuery -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>  
    
    <!-- css file for the page -->
	<link rel="stylesheet" href="<%=request.getContextPath()%>/css/style.css" type="text/css">

    <title>List Books | Wisdom Library</title>
  </head>
  
  <body>
	<!-- include the custom header -->
  	<jsp:include page="header.jsp"/>
  	
  	<!-- main part of the page -->
  	<div class="container px-3 mt-3 d-md-block d-none">
  	
  		<!-- subtitle -->
    	<div class="row pt-3">
    		<div class="col-12">
    			<h4>Book List</h4>
    		</div>
    	</div>
  	
  		<!-- table to show the book list -->
	  	<div class="row mt-3">
	 		<table class="table table-striped">
	 			<thead>
	 				<tr class="text-dark bg-light-green" id="listHeader">
	 					<th >Book_id</th>
	 					<th >Author</th>
	 					<th >Publisher</th>
	 					<th>Publish Date</th>
	           			<th >Action</th> 					
	 				</tr>
	 			</thead>
	 			
		 		<tbody>
	 				<c:forEach var="book" items="${books}">
						<c:url var="updateLink" value="/book/showPageForUpdatingById">
							<c:param name="bookId" value="${book.id }" />
						</c:url>
						
						<c:url var="deleteLink" value="/book/deleteBookById">
							<c:param name="bookId" value="${book.id }" />
						</c:url>
						<tr>
							<td >${book.id }</td>
							<td>${book.authorName }</td>
							<td>${book.publisherName }</td>
							<td>${book.publishDate }</td>
							<td><a href="${updateLink}" class="text-decoration-none text-danger">Update</a> | 
								<a href="${deleteLink}" onclick="if(!(confirm('Are you sure to delete this Book permanently?'))) return false" class="text-decoration-none text-danger">Delete</a>
							</td>
						</tr>		  
					</c:forEach>
		 		</tbody>		
		 	</table>
		  </div>
	    </div>
			
		<!-- include the custom footer -->
	    <jsp:include page="footer.jsp"/>
	    <script>
		var bookList = <%= request.getAttribute("books") %>;
		if(bookList.length == 0){
			document.getElementById("listHeader").innerText = "No record found";
		}
	    </script> 

	</body>
</html>