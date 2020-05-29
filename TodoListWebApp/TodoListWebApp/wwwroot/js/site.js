
function editItemExtremelyManualJQuery(event) {
    var tdMiddle = $(event.currentTarget).parent().parent().find(".todoText");
    var todo = tdMiddle.text()
    var newTextBox = $("<input>")
        .val(todo)
        .addClass("form-control")
        .attr("maxlength", 50)
    tdMiddle.text("").append(newTextBox)
}

function editItem(event) {
    $(".edit").removeClass("edit")
    $(event.currentTarget).parent().parent().toggleClass("edit")
    $(event.currentTarget).parent().parent().find("input.form-control").focus()
}

function editComplete(event) {
    $(event.currentTarget).find("form").trigger("submit")
}