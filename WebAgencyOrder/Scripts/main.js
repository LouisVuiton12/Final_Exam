$(document).ready(function () {
});

function validNumber(e) {
    if (e.which < 48 || e.which > 57) {
        $(`#errmg`).html("Only number accepted!").show().fadeOut(5000);
        return false;
    }

    return true
}