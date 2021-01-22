$(document).ready(function(){
	// validate the input date
	$("#btnSub").click(function() {
		var today = new Date();
		var year = today.getFullYear();
		var month = today.getMonth() + 1;
		var day = today.getDate();

		today = year + "-" + month + "-" + day;
		if ($("#publishDate").val() > today) {
			alert("Publish Date can not be later than today.");
		}
	})
})