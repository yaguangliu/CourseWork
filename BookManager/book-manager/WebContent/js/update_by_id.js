$(document).ready(function(){
	/*
	 * when update publishDate field, if the input date is later than current date, 
	 * the app will show message.
	 */ 
	$("#btnSub").click(function(){
		var today = new Date();
		var year = today.getFullYear();
		var month = today.getMonth() + 1;
		var day = today.getDate();
		
		today = year + "-" + month + "-" + day;
		if($("#publishDate").val() > today){
			alert("Publish Date can not be later than today.");
		}
	})
})