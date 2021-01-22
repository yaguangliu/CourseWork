<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<!-- Bootstrap CSS -->
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">

	<!--Awesome font CSS-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css">

    <!--link to the css file-->
    <link rel="stylesheet" type="text/css" href="<%= request.getContextPath() %>/css/index.css">

	<title>Homepage | Wisdom Library</title>
</head>

<body>

	<div class="container-fluid p-0 whole-container">

  		<!-- header part -->
		<div class="header-part container-fluid position-relative">
			<p class="display-3 text-center header-title h-100">
				Welcome to Wisdom Library
			</p>
		</div>

		<!--navigation for CRUD operation page-->
		<div class="navigation-part container justify-content-center pt-5 mt-5 position-relative">
			   
		   	<div class="offset-4 col-4 rounded-pill bg-green">
		   		<a href="book/showFormForAdding" class="d-block text-decoration-none link-blocks">		   		
			   		<i class="fas fa-bible book-icons"></i>
			   		<span class="fs-5">Add a Book</span>
		   		</a>
		    </div>

		    <div class="offset-4 col-4 rounded-pill bg-green mt-3" >
		   		<a href="book/listAllBooks" class="d-block text-decoration-none link-blocks">		   		
			   		<i class="fas fa-list-alt book-icons" ></i>				   		
				   	<span class="fs-5" >List all Books</span>
		   		</a>
		    </div>
			   
		    <div class="offset-4 col-4 rounded-pill bg-green mt-3" >
		   		<a href="book/showPageForGettingById" class="d-block text-decoration-none link-blocks " >		   		
			   		<i class="fas fa-book-reader book-icons" ></i>				   		
				   	<span class="fs-5" >Read a Book</span>
		   		</a>
		    </div>
			 
		    <div class="offset-4 col-4 rounded-pill bg-green mt-3">
		   		<a href="book/showPageForSearching" class="d-block text-decoration-none link-blocks">		   		
			   		<i class="fas fa-search book-icons" ></i>				   		
				   	<span class="fs-5" >Search Books</span>
		   		</a>
		    </div>
			    
		    <div class="offset-4 col-4 rounded-pill bg-green mt-3">
		   		<a href="book/deleteAllBooks" class="d-block text-decoration-none link-blocks" onclick="if(!(confirm('Are you sure to delete all Books permanently?'))) return false">		   		
			   		<i class="fas fa-folder-minus book-icons" ></i>				   		
				   	<span class="fs-5" >Delete Books</span>
		   		</a>
		    </div>

			<div class="offset-4 col-4 rounded-pill bg-green mt-3" >
		   		<a href="book/showUpdatePage" class="d-block text-decoration-none link-blocks" >		   		
			   		<i class="fas fa-user-edit book-icons" ></i>				   		
				   	<span class="fs-5" >Update Books</span>
		   		</a>
		    </div>		
			
		</div>		

	</div>	

    <!-- Option 1: Bootstrap Bundle with Popper -->
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
	
</body>
</html>

