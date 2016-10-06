

$( "td" ).click(function() {
  $("#overlay").slideDown();
  $("#overlay").css('display', 'inline');
  

});

$('#overlay').click(function(){
  $( this ).slideUp();
});

