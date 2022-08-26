console.log("page loaded...");

function playVid(vid){
    console.log("action");
    
    vid.play();
}

function pauseVid(vid){
    console.log("stop");
    vid.pause();
}