$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    console.log('paso por primera funcion');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })        
    })
    
    PlaceHolderElement.on('click', '[data-save="modal"]', function (event){
        console.log('paso por aqui');
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            console.log(actionUrl);
            PlaceHolderElement.find('.modal').modal('hide');
        })
    })
})