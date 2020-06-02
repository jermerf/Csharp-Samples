
function login() {
    var data = {
        action: "login",
        username: $("#loguser").val(),
        password: $("#logpass").val()
    }

    $.post("/User", data, (res) => {
        console.log(res)
    })
}

function register() {
    var data = {
        action: "register",
        username: $("#reguser").val(),
        password: $("#regpass").val()
    }

    $.post("/User", data, (res) => {
        console.log(res)
    })
}