
$(document).ready(function () {
           $(".put").on("click", function () {
            var movieId = $(this).context.id;
            $.ajax({
                url: '/Home/Edit',
                dataType: "json",
                type: "Put",
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify({ id: movieId }),
                async: true,
                processData: false,
                cache: false,
                success: function (data) {                    
                    window.location = '/Home/Index';
                    alert(data);
                    
                },
                error: function (xhr) {
                    alert('error');
                }
            });


    });
});
