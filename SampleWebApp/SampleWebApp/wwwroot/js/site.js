// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function showModal() {
    setTimeout( () => {
        $("#staticBackdrop").modal("toggle")
    }, 3000)
}

function getWeather() {
    $("#weatherModal").modal("show")

    let url = "https://api.openweathermap.org/data/2.5/weather"

    let data = {
        appid: "6565d5a438410f02d391a6dee21a7eed",
        q: $("#city").val()
    }

    // AJAX Request - Request data from online
    $.get(url, data, (response) => {
        let niceTemp = Math.round(response.main.temp - 273.15) + "&deg;"
        let niceWind = response.wind.speed + " km/h"
        $("#temperature").html(niceTemp)
        $("#wind").text(niceWind)

        if (response.clouds.all < 20) {
            $("#weather").attr("src", "/img/sun.jpg")
        } else if (response.clouds.all < 50) {
            $("#weather").attr("src", "/img/cloud.jpg")
        } else {
            $("#weather").attr("src", "/img/rain.png")
        }
    })
}

function cityChanged() {
    if ($("#city").val() == "") {
        $("#weatherButton").addClass("disabled")
    } else {
        $("#weatherButton").removeClass("disabled")
    }
}

function getThisCode() {
    $.get("/js/site.js", (response) => {
        alert(response)
    })

}