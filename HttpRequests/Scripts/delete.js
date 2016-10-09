//$(document).ready(function () {
//    $("#1").on("click", function () {
//        var id = $(this).context.id;
        
//        $.ajax({
//            type: 'Delete',
//            url: '/Home/Index',
//            data: { id:id },
//            success: function reload() {
//                document.location.reload();
                
//        },
//        error: function (data) {
//            alert(data.x);
//        }
//    });
//});
//});
$(document).ready(function () {
    $("#1").on("click", function () {
        $.ajax({
            url: '/Home/Index',
            dataType: "json",
            type: "DELETE",
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify({ id: 20 }),
            async: true,
            processData: false,
            cache: false,
            success: function (data) {
                alert(data);
            },
            error: function (xhr) {
                alert('error');
            }
        });
    });
});