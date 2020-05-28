
function register(event) {
    var password = event.target.children[3].value
    var confPass = event.target.children[4].value

    if (password != confPass) {
        event.preventDefault();
        alert("Passwords must match")
    }
    
}