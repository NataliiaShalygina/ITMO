function Is_Support_Localstorage() {
try {
return 'localStorage' in window &&
window['localStorage'] !== null;
}
catch(e) {
return false;
}
}

function myFunction() {
 var k = 0;
 var userName = document.getElementById("name").value;
 if (userName == "") {
           alert("Не заполнено обязательное поле: Имя ученика") 
        	     } else {
            	localStorage.setItem("userName",userName);
		k++;
			    };

 var userSurName = document.getElementById("surname").value;
 if (userSurName == "") {
            alert("Не заполнено обязательное поле: Фамилия ученика");
        	        } else {
            	localStorage.setItem("userSurName",userSurName);
	        k++;
			       };

 var userAge =  document.getElementById("age").value;
 if (userAge == "") {
            alert("Не заполнено обязательное поле: Возраст");
        	    } else {
            	localStorage.setItem("userAge",userAge);
		k++;};

 var userClass = document.getElementById("class").value;
 if (userClass == "") {
            alert("Не заполнено обязательное поле: Класс");
        	      } else {
            	localStorage.setItem("userClass",userClass);
		k++;
		             };

 var userEmail = document.getElementById("email").value;
 if (userEmail == "") {
            alert("Не заполнено обязательное поле: Email");
        	      } else {
            	localStorage.setItem("userEmail",userEmail);
		k++;
		             };
  
 var userProb = document.getElementById("prob").value;
 if (userProb == "") {
            alert("Не заполнено обязательное поле: Текущие проблемы в усвоении материала");
        	     } else {
            	localStorage.setItem("userProb",userProb);
		k++;
		            };

var userRes = document.getElementById("res").value;
 if (userRes == "") {
            alert("Не заполнено обязательное поле: Ожидаемые результаты от занятий");
        	    } else {
            	localStorage.setItem("userRes",userRes);
		k++;
			   };
if (k==7) {
	alert("Ваши данные сохранены!");
	  };
        }
