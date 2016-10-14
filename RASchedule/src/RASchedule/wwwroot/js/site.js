// Write your Javascript code.


$("td").click(function () {
    $("#overlay").slideDown();
    $("#overlay").css('display', 'inline');
    $('#main').css('filter', 'blur(4px)');
    //$("td").addClass("disableHover");
    $("td").css({ 'pointer-events': 'none' });
});

$('.buttons').click(function () {
    $('#overlay').slideUp();
    $('#main').css('filter', 'blur(0px)');
    $("td ").css({ 'pointer-events': 'auto' });
});

$(document).keydown(function (e) {
    // ESCAPE key pressed
    if (e.keyCode == 27) {
        $('#overlay').slideUp();
        $("td ").css({ 'pointer-events': 'auto' });
    }
});
