<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
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
    
    <!-- jQuery file -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
 	
 	<!-- custom js and css file -->
 	<link rel="stylesheet" href="<%=request.getContextPath()%>/css/style.css" type="text/css">
 	<script type="text/javascript" src="<%=request.getContextPath()%>/js/update_by_id.js"></script>
 
    <title>Update By Id</title>
  </head>
  
  <body>
  	<!-- set the parameter bookId -->
  	<c:url var="updateByIdLink" value="/book/updatingBookById" >
  		<c:param name="bookId" value="${book.id}"/>  	
  	</c:url>
  	
    <!-- include the custom header -->
  	<jsp:include page="header.jsp"/>   

    <!-- -->
    <div class="container px-3 pt-3">
      <div class="row pt-3">
        <div class="col-12">
          <h4>Update a Book</h4>
        </div>
      </div>

      <div class="row bg-light-green p-5 border-top">
        <form:form action="${updateByIdLink}" class="w-100" modelAttribute="book">
          <div class="col-8 rounded bg-light offset-1">
          	
          	<div class="row pt-3">
              <label for="bookId" class="col-form-label col-4" style="font-size: 1.2rem;">Book ID</label>
              <div class="col-8">
                ${book.id }
              </div>
            </div>
            
            <div class="row mb-3 pt-3">
              <label for="authorName" class="col-form-label col-4" style="font-size: 1.2rem;">Author Name</label>
              <div class="col-8">
                <form:input type="text" class="form-control" path="authorName"/>
              </div>
            </div>

            <div class="row mb-3 pt-2">
              <label for="publisherName" class="col-form-label col-4" style="font-size: 1.2rem;">Publisher Name</label>
              <div class="col-8">
                <form:input type="text" class="form-control" path="publisherName"/>
              </div>
            </div>

            <div class="row mb-3 pt-2">
              <label for="publishDate" class="col-form-label col-4" style="font-size: 1.2rem;">Publish Date</label>
              <div class="col-8">
                <form:input type="date" class="form-control" path="publishDate" id="publishDate"/>               
              </div>
            </div>

            <div class="row">
              <div class="col-3">
                <input type="submit" value="Submit" class="w-100 nav-bg-green text-white border-0 shadow rounded mb-3" style="height: 38px;" id="btnSub">
              </div>
               <div class="col-3">
                <input type="reset" value="Reset" class="w-100 nav-bg-green text-white border-0 shadow rounded mb-3" style="height: 38px;">
              </div>
            </div>
          </div>          
        </form:form>
      </div>   
    </div>
    
    <!-- include the custom footer -->
    <jsp:include page="footer.jsp"/>  
   
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->   
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    
  </body>
</html>