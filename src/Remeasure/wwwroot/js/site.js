$("#recipe-input").on('change', remeasureRecipe);

function remeasureRecipe(e) {
    var recipeinput = $("#recipe-input").val();

    $.ajax({
        url: "/Home/RemeasureRecipe",
        type: 'POST',
        data: { recipe: recipeinput },
    }).done(function( data ) {
        $("#recipe-output").val(data.toString());
    });

    e.preventDefault();
}