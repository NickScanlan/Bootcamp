console.log("wazaaaaap");


function petDog(){
    alert("You just pet this puppy. Thats a good boy/girl!")
    // console.log("you pet this dog!")
}


function toggleLogin(btn){
    console.log("you clicked on login button!", btn);

    //btn represents the button that was clicked

    //if the buttons innner text currently says Login, then change it to logout
    if(btn.innerText === "Login"){
        //to change its text-> modify the btn.innerText to equal logout
        btn.innerText = "Logout";
    }else{
        //otherwise change it to login
        btn.innerText = "Login";
    }
}


function removeButton(btn){
    // console.log("removing something!", btn);
    btn.remove();
}