console.log('bruh')


function upvote(num){
    console.log('I like', num)
    num = document.querySelector('#' + num);

    num.innerText++;
    console.log(num.innerText)
}