// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function Searchy() {
    let x = document.getElementById("mySearch").value;
    window.location.href = "Search?search=" + x;
}

function NoFound() {
    document.getElementById("Error").innerHTML = "Nothing Found";
}