$(document).ready(function(){
	
	/* validate query conditions and show the error message
	 * there are seven fields to consider, I took the fields: author, publisher and pubishDate as the main conditions
	 * and took the fields authorChoice, publisherChoice and operator as the nested conditions to get various query 
	 * statements. 
	 */
	$("#btnSub").click(function() {
		console.log("test");
		var author = $("#authorName").val();
		var authorChoice = $("#authorChoice").val();
		var publisher = $("#publisherName").val();
		var publisherChoice = $("#publisherChoice").val();
		var publishDate = $("#publishDate").val();
		var laterDate = $("#laterDate").val();
		var operator = $("#operatorChoice").val();

		// if the main three fields are empty, the app will show message
		if (author == "" && publisher == "" && publishDate == "") {
			alert("Invalid query conditions. Input again.");
		}
		
		/* author is not empty, the other two are empty, then check the nested conditions to 
		 * show the message
		 * */
		if (author != "" && publisher == "" && publishDate == "") {
			if (authorChoice != "" || publisherChoice != "") {
				alert("Invalid query conditions. Input again.");
			}
		}

		/*
		 * author and publisher are not empty, then if the authorChoice is empty,the app will show message.  
		 */
		if (author != "" && publisher != "" && publishDate == "") {

			if (authorChoice == "") {
				alert("Invalid query conditions. Input again.");
			}
		}
		
		/*
		 * author and publishDate are not empty, then if the authorChoice is empty,the app will show message.  
		 * then if the authorChoice is not empty, if you choose 'between' for operator, if the second date is 
		 * earlier than the previous date, the app will show message.
		 */
		if (author != "" && publisher == "" && publishDate != "") {
			if (authorChoice == "") {

				alert("Invalid query conditions. Input again.");
			} else {
				if (operator == "between") {
					if (laterDate < publishDate) {
						alert("Invalid query conditions. Input again.");
					}
				}
			}
		}

		/*
		 * publisher and publishDate are not empty, then if the publisherChoice is empty,the app will show message.
		 * then if the publisherChoice is not empty, and if you choose 'between' for operator, if the second date is 
		 * earlier than the previous date, the app will show message. 
		 */
		if (author == "" && publisher != "" && publishDate != "") {
			if (publisherChoice == "") {
				alert("Invalid query conditions. Input again.");
			} else {
				if (operator == "between") {
					if (laterDate < publishDate) {
						alert("Invalid query conditions. Input again.");
					}
				}
			}
		}
		
		/*
		 * publisher is not empty, if the publisherChoice or authorChoice is not empty, the app 
		 * will show message.		 
		 */
		if (author == "" && publisher != "" && publishDate == "") {
			if (publisherChoice != "" || authorChoice != "") {
				alert("Invalid query conditions. Input again.");
			}			
		}

		/*
		 * publishDate is not empty, if the publisherChoice or authorChoice is not empty, the app 
		 * will show message. Then if the publisherChoice and authorChoice are empty, if you choose 'between'
		 * as operator, if the second date is earlier than the previous date, the app will show message. 
		 */
		if (author == "" && publisher == "" && publishDate != "") {
			if (publisherChoice != "" || authorChoice != "") {

				alert("Invalid query conditions. Input again.");

			}
			if (publisherChoice == "" && authorChoice == "") {
				if (operator == "between") {
					if (laterDate < publishDate) {
						alert("Invalid query conditions. Input again.");
					}
				}
			}
		}

		/*
		 * three main fields are not empty, but the authorChoice and publisherChoice are emtpy,the app
		 * will show the message. Then if the authorChoice and publisherChoice are not empty, if you choose 'between'
		 * as operator, if the second date is earlier than the previous date, the app will show message. 
		 */
		if (author != "" && publisher != "" && publishDate != "") {
			if (publisherChoice == "" || authorChoice == "") {

				alert("Invalid query conditions. Input again.");
			}else{
				if (operator == "between") {
					if (laterDate < publishDate) {
						alert("Invalid query conditions. Input again.");
					}
				}
			}
			
		}

	})
	
	//if you choose 'between' as the operator, there will be two inputs for date 
	$("#operatorChoice").change(function() {
		if (this.value == "between") {
			$("#laterDate").show();

		} else {
			$("#laterDate").hide();
		}

	})
	
	// when you click reset button, there will only one input for Date left
	$("#btnReset").click(function() {
		$("#laterDate").hide();
	})
})
