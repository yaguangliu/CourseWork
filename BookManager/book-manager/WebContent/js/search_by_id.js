$(document).ready(function(){
	// validate the input book id
	$("#btnSub").click(function(){
    		var idStr = $("#idStr").val();
    		var num = Number(idStr);
    		if(isNaN(num)){
    			alert("You should input a positive integer.");
    		}
    		if((!isNaN(num)) && (num <= 0)){
    			alert("You should input a positive integer.");
    		}
    		
    	})
})