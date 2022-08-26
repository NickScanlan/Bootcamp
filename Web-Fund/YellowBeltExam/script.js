console.log("bruh")

function removeBar(id){
    console.log("BEGONE!");
    let btn = document.querySelector("#" + id);
    btn.remove();
}

function cartAlert(){
    console.log("noti");
    alert("Your cart is empty!");
}

function switchImg1(picture){
    console.log("pic2");
    picture.src = "./images/assets/succulents-1.jpg"
}

function switchImg2(picture){
    console.log("pic1");
    picture.src = "./images/assets/succulents-2.jpg"
}