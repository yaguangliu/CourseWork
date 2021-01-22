<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
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
    
    <!-- custom css file for header -->
    <link rel="stylesheet" href="<%=request.getContextPath()%>/css/header-footer.css" type="text/css">

  </head>
  
  <body>
  	<!-- set the link for navigation bar -->
  	<c:url var="addLink" value="/book/showFormForAdding"/>
	<c:url var="listLink" value="/book/listAllBooks"/>
	<c:url var="getABookLink" value="/book/showPageForGettingById"/>
	<c:url var="searchLink" value="/book/showPageForSearching"/>
	<c:url var="deleteAllLink" value="/book/deleteAllBooks"/>
	<c:url var="updateLink" value="/book/showUpdatePage"/>							
						
    <!-- header -->
    <div class="container-fluid">
      <div class="row">
        <div class="card text-white border-0 w-100 header-img">
          <img src="../img/header3.jpg" class="card-img rounded-0 " alt="background image" style="height: 100px;">
          <div class="d-flex flex-column card-img-overlay align-items-center justify-content-center" style="z-index: 99;">
            <a href="/book-manager" class="text-decoration-none" id="header-title"><h1 class="text-center font-weight-bolder display-4">Wisdom Library</h1> </a>           
          </div>
        </div>
      </div>
    </div>

    <!--navigation-->
    <div class="container-fluid nav-bar text-info shadow d-none d-md-block">
      <ul class="nav justify-content-around ">
        <li class="nav-item text-light">
          <a class="nav-link text-light" href="${addLink}">Add a Book</a>
        </li>
        <li class="nav-item">
          <a class="nav-link text-light" href="${listLink}">List Books</a>
        </li>
        <li class="nav-item">
          <a class="nav-link text-light" href="${getABookLink}">Get a Book</a>
        </li>
        <li class="nav-item">
          <a class="nav-link text-light" href="${searchLink}">Search Books</a>
        </li>        
        <li class="nav-item">
          <a class="nav-link text-light" href="${deleteAllLink}" onclick="if(!(confirm('Are you sure to delete all Books permanently?'))) return false">Delete Books</a>
        </li>
        <li class="nav-item">
          <a class="nav-link text-light" href="${updateLink}">Update Books</a>
        </li>
      </ul>
    </div>
    
  <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
  
  </body>
</html>