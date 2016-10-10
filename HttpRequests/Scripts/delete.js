
$(document).ready(function () {
    $(".delete").on("click", function () {
        var movieId = $(this).context.id;
        $.ajax({
            url: '/Home/Delete',
            dataType: "json",
            type: "DELETE",
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify({ id: movieId }),
            async: true,
            processData: false,
            cache: false,
            success: function (data) {
                
                alert(data);
                window.location = '/Home/Index';
            },
            error: function (xhr) {
                alert('error');
            }
        });
    });

});
