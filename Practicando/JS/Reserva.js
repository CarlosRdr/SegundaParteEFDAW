function CargarListdadoReserva() {
    $.ajax({
        cache:false,
        type: "POST",
        url: "ListReserva",
        success: function (html) {
            $("#divListadoReserva").html(html);
        }
    });
}
function CargarListdadoReservas() {
    $.ajax({
     
        type: "POST",
        url: "ListReserva",
        success: function (html) {
            $("#divListadoReserva").html(html);
        }
    });
}