function myFunc() {
var dropdownContent =document.getElementById("myDropdown");
if (dropdownContent== null) {
           alert("Ошибка, пустое значение") 
        	     } else {
if (dropdownContent.style.display === "block") {
				dropdownContent.style.display = "none";
						} else {
				dropdownContent.style.display = "block";
							}
		}
}
