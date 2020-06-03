
function login() {
    var data = {
        action: "login",
        username: $("#loguser").val(),
        password: $("#logpass").val()
    }

    $.post("/User", data, (res) => {
        if (res) {
            loginSuccess(data.username)
        } else {
            $("#registerStatus")
                .text("Login failed")
                .addClass("alert-danger")
        }
    })
}

function register() {
    var data = {
        action: "register",
        username: $("#reguser").val(),
        password: $("#regpass").val()
    }

    if ($("#regpassconfirm").val() != $("#regpass").val()) {
        $("#registerStatus")
            .text("Passwords must match")
            .addClass("alert-danger")
        return
    }
    $("#registerStatus")
        .text("")
        .removeClass("alert-danger alert-warning")

    $.post("/User", data, (res) => {
        if (res) {
            // Registered Successfully
            $("#registerStatus")
                .text("Registered")
                .addClass("alert-success")
            loginSuccess(data.username)
        } else {
            // Registration failed
            $("#registerStatus")
                .text("Registration failed, username taken")
                .addClass("alert-warning")
        }
    })

}

function loginSuccess(username) {
    $("#loginBox").slideUp(400)
    $("#messageBoard").slideDown(400)
    $("h1").text(username)
    window.username = username
}


function logout() {
    $("#loginBox").slideDown(400)
    $("#messageBoard").slideUp(400)
}

$(document).ready(() => {
    if (username.length > 0) {
        // I am logged in!
        loginSuccess(username)
    } else {
        logout()
    }
})