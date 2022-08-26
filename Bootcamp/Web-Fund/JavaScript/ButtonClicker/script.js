console.log("chum");

function toggleLogin(loginbtn){

    if(loginbtn.innerText == "Login"){
        loginbtn.innerText = "Logout";
    }else{
        loginbtn.innerText = "Login";
    }
}


function removebtn(btn){
    // console.log("lol", btn)

    btn.remove();
}