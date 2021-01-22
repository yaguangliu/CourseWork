<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
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
   
    <!-- css and js files for the page -->
    <link rel="stylesheet" href="<%=request.getContextPath()%>/css/style.css" type="text/css">
    <script src="<%=request.getContextPath()%>/js/search.js"  type="text/javascript"></script>

    <title>Search Page | Wisdome Library</title>
  </head>
  
  <body>
    <!-- include the custom header -->
  	<jsp:include page="header.jsp"/>   

    <!-- the search form -->
    <div class="container px-3 pt-3 d-md-block d-none">
      <div class="row pt-3">
        <div class="col-12">
          <h4>Search Books</h4>
        </div>
      </div>

      <div class="row bg-light-green p-5 border-top">
        <form action="searchBooks" class="w-100">
          <div class="col-10 rounded bg-light offset-1">
            <div class="row mb-3 pt-3 align-items-center">
              <label for="authorName" class="col-form-label col-3" style="font-size: 1.2rem;" >Author Name</label>
              <div class="col-7">
                <input type="text" class="form-control" name="authorName" id="authorName" />
              </div>
              <div class="col-2">
              	<select name="authorChoice" id="authorChoice">
              		<option value="">Your choice</option>
              		<option value="and">And</option>
					<option value="or">Or</option>
              	</select>
              </div>
            </div>

            <div class="row mb-3 pt-2 align-items-center">
              <label for="publisherName" class="col-form-label col-3" style="font-size: 1.2rem;">Publisher Name</label>
              <div class="col-7">
                <input type="text" class="form-control" name="publisherName" id="publisherName"/>
              </div>
              <div class="col-2">
              	<select name="publisherChoice" id="publisherChoice">
              		<option value="">Your choice</option>
              		<option value="and">And</option>
					<option value="or">Or</option>
              	</select>
              </div>
            </div>

            <div class="row mb-3 pt-2 align-items-center">
              <label for="publishDate" class="col-form-label col-3" style="font-size: 1.2rem;" >Publish Date</label>
               <div class="col-2">
              	<select name="operators" id="operatorChoice">
              		<option value="=">=</option>
              		<option value=">=">>=</option>
					<option value="<="><=</option>
					<option value=">">></option>
					<option value="<"><</option>
					<option value="between">between</option>
              	</select>
              </div>
              <div class="col-5">               
                <input type="date" class="form-control" name="publishDate" id="publishDate"/>
                <input type="date" class="form-control mt-2" name="laterDate" style="display:none" id="laterDate"/>            
              </div>
            </div>

            <div class="row">
              <div class="col-3">
                <input type="submit" value="Submit" class="w-100 nav-bg-green text-white border-0 shadow rounded mb-3" style="height: 38px;" id="btnSub">
              </div>
               <div class="col-3">
                <input type="reset" value="Reset" class="w-100 nav-bg-green text-white border-0 shadow rounded mb-3" style="height: 38px;" id="btnReset">
              </div>
            </div>
          </div>          
        </form>
      </div>  
    </div>
    
    <!-- include the custom footer -->
    <jsp:include page="footer.jsp"/>  
 
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    
  </body>
</html>