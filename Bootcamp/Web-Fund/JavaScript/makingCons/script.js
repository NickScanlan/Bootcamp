console.log("hoy");

function changeName(name){
    let btn = document.querySelector('#' + name);

    btn.innerText = "Bob Marley"

}

function removeT(t){
    let btn = document.querySelector('#' + t);
    btn.remove();
}

function removeT(p){
    let btn = document.querySelector('#' + p);
    btn.remove();
}

function minusCon(num){
    document.querySelector('#' + num).innerText--;

}

function plusCon(num){
    document.querySelector('#' + num).innerText++;
}