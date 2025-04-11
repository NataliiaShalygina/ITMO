var popupOverlay = document.getElementById("popup-overlay");
var popup = document.getElementById("popup");

if (popupOverlay== null || popup== null) {
           alert("Ошибка, пустое значение") 
        	     } else {
function showPopup() {
  popupOverlay.style.display = "block";
}
function hidePopup() {
  popupOverlay.style.display = "none";
}
popupOverlay.addEventListener("click", hidePopup);
popup.addEventListener("click", (event) => event.stopPropagation());
}



var popupOverlay1 = document.getElementById("popup-overlay1");
var popup1 = document.getElementById("popup1");

if (popupOverlay1== null || popup1== null) {
           alert("Ошибка, пустое значение") 
        	     } else {
function showPopup1() {
  popupOverlay1.style.display = "block";
}
function hidePopup1() {
  popupOverlay1.style.display = "none";
}
popupOverlay1.addEventListener("click", hidePopup);
popup1.addEventListener("click", (event) => event.stopPropagation());
}


var popupOverlay2 = document.getElementById("popup-overlay2");
var popup2 = document.getElementById("popup2");

if (popupOverlay2== null || popup2== null) {
           alert("Ошибка, пустое значение") 
        	     } else {
function showPopup2() {
  popupOverlay2.style.display = "block";
}
function hidePopup2() {
  popupOverlay2.style.display = "none";
}
popupOverlay2.addEventListener("click", hidePopup);
popup2.addEventListener("click", (event) => event.stopPropagation());
}

