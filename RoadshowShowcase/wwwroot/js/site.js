$(function () {
    $('.project-link-toggle').click(function () {
        $('.project-details-content').not($(this).parent().next('.project-details-content')).slideUp();
        $(this).parent().next('.project-details-content').slideToggle();
    });
});