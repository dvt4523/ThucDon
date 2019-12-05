
$(document).ready(function(){
    $('#nav-icon1').click(function(){
        $(this).toggleClass('close');
    });
});
$(document).ready(function(){
    $('#nav-icon1').hover(function(){
        $(this).toggleClass('open');
    });
});
$(document).ready(function () {
    var trigger = $('.menu-toggler'),
        overlay = $('.overlay'),
        isClosed = false;

    trigger.click(function () {
        hamburger_cross();
    });

    function hamburger_cross() {

        if (isClosed == true) {
            overlay.hide();
            isClosed = false;
        } else {
            overlay.show();
            isClosed = true;
        }
    }
});