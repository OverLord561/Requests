document.body.onload = function ()
{
    var sendBtn = document.getElementById('SendRequest');


    sendBtn.addEventListener('click', changeTypeOfRequest);

};


function changeTypeOfRequest(typeOfRequest)
{
    var form = document.getElementById('form');
    var typeOfRequest = document.querySelector('input[name = "optradio"]:checked').value;

    form.method = '';
    form.method = typeOfRequest;

};

