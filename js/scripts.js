
$( "td" ).click(function() {
  $("#overlay").slideDown();
  $("#overlay").css('display', 'inline');
  $('#main').css('filter' , 'blur(4px)');
  //$("td").addClass("disableHover");
  $( "td" ).css({'pointer-events': 'none'});
});

$('.buttons').click(function(){
  $( '#overlay' ).slideUp();
   $('#main').css('filter' , 'blur(0px)');
   $( "td ").css({'pointer-events': 'auto'});
});



