console.log("yo")


// remove button
function uploadPup(del){
    del.remove();


}


// remove cookie bar
function barRemove(id){
    let btn = document.querySelector('#' + id);

    btn.remove();

}


// change text of button
function Loginbtn(btn){
    if(btn.innerText == "Login"){
        btn.innerText = "Logout"
    }else{
        btn.innerText = "Login"
    }

}

// add likes number

function addLike(num){
    let count = document.querySelector('#' + num);

    count.innerText++;

}

// play pause mouse over

function playVideo(vid){
    vid.play();

}

function pauseVideo(vid){
    vid.pause();


}

// click button for input info without parameters or arguments

function searchPuppy(){
    let element = document.querySelector('#nameSearch');

    alert('searching for ' + element.value);
}


// value from dropdown
function chooseLocation(element){
    // alert('you are searching for doge in ' + element.value)
    
    // or you could use ==> 
    
    alert(`you are searching for doge in ${element.value}. come by anytime!`);
}

// switch photo when hovering

function switchImg(imgElement){
    imgElement.src = "./resources/anothaPuppy.jpeg"
    console.log(imgElement.src)
}

function switchImg2(imgElement){
    imgElement.src ="./resources/beagle.jpeg"
    console.log(imgElement.src)
}