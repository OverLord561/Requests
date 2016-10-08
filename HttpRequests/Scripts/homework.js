document.body.onload = function ()
{

  //  var radioBtn = document.querySelector('input[name = "optradio"]');
   // for ( radio in radioBtn)
   // {
    //    radioBtn[radio].addEventListener("click", radioBtnClick);
   // }
    

    //var btnR = document.getElementById('SendRequest');
   // btnSubmit.addEventListener('onclick', changeTypeOfRequest);
};


function changeTypeOfRequest(typeOfRequest)
{
   // alert(typeOfRequest);
};

function radioBtnClick() {
    var typeOfRequest = document.querySelector('input[name = "optradio"]:checked').value;
    alert(typeOfRequest);
};
