$(document).ready(function(){
	
	/*
	 * if you choose to update field publishDate, the type of input 
	 * will be changed to date type
	 * 
	 */
	$("#updateField").change(function(){
		var updateField = this.value;
		if(updateField == "publishDate"){
			$("#updateValue")[0].type = "date";
		}else{
			$("#updateValue")[0].type = "text";
		}
	})
	
	/*
	 * when click reset button, the input will be set to text type again
	 */
	$("#btnReset").click(function(){
		$("#updateValue")[0].type = "text";
	})
	
	/*
	 * when you click the submit button, please ensure the input date is not later than current 
	 * date, otherwise the app will show message.
	 * and ensure you input the new value for the chosen field.
	 */
	$("#btnSub").click(function(){
		var updateField = $("#updateField").val();
		var updateValue = $("#updateValue").val();
		if(updateField == ""){
			alert("Choose the field you want to update.");
		}else{
			if(updateValue == ""){
				alert("Input the new value for the field.")
			}
		}
		
		var today = new Date();
		var year = today.getFullYear();
		var month = today.getMonth() + 1;
		var day = today.getDate();
		
		today = year + "-" + month + "-" + day;
		if(updateField == "publishDate"){
			if(updateValue > today){
				alert("Publish Date can not be later than today.");
			}
		}
		
	})
})