// Write your Javascript code.

var $clicked = "";

$("td").click(function () {
    $("#overlay").slideDown();
    $("#overlay").css('display', 'inline');
    $('#main').css('filter', 'blur(4px)');
    $clicked = this;
   
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

$("#takehour").click(function (e) {
    // takes current count of hours from DB, 
    // adds 1
    // puts them again in the DB

    // take the id and put in the DB
    console.log($clicked.id);
});

// profile button send weekly report 
// profile button send night duty report
// a bot mail sends email to ilko
// when weekly report is sent, current hours = 0, current duty days = 0