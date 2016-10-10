document.body.onload = function ()
{
    var sendBtn = document.getElementById('SendRequest');

    //var requestBtn = document.getElementById('256');
    //requestBtn.addEventListener("click", function () {deleteRecord(requestBtn.id); }, false);

    sendBtn.addEventListener('click', changeTypeOfRequest);

};


function changeTypeOfRequest(typeOfRequest)
{
    var form = document.getElementById('form');
    var typeOfRequest = document.querySelector('input[name = "optradio"]:checked').value;

    form.method = '';
    form.method = typeOfRequest;

};

//function deleteRecord(recordId) {
//    // Perform delete
//    //var action = "/Home/Index/" + recordId;

//    //var request = new XMLHttpRequest();
    
//    //request.set_httpVerb("DELETE");
//    //request.set_url(action);
//    //request.add_completed(deleteCompleted);
//    //request.invoke();
//    var xhr = new XMLHttpRequest();

//    // настройка объекта запроса с указание метода отправи запроса и данных
//    var xhr = new XMLHttpRequest();
//    xhr.open("Delete", "/Home/Delete/256");
//    // Content-Type - HTTP заголовок, который указывает серверу, как интерпретировать тело запроса.
//    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
//    //xhr.onreadystatechange = function () {
//    //    if (xhr.readyState == 4 && xhr.status == 200) {
//    //        document.getElementById("output").innerHTML = xhr.responseText;
//    //    }
//    //}

//    // отправка запроса с указанием данных.
//    xhr.send();


//}

//function deleteCompleted() {
//    // Reload page
//    window.location.reload();
//}
