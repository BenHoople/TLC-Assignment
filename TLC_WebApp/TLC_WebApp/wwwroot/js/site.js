// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#form").load("/ajax/GameBoardPartial");
$("#square").click(function () {
    $(this).innerHTML("BLAH!")
    });

//$(function () {
  //  $("#form").click($(this).load("/ajax/GameBoardPartial"))
//});

