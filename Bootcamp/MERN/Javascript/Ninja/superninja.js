class Ninja {
    constructor (name, health, speed, strength){
        this.name = name;
        this.health = health;
        this.speed = 3;
        this.strength = 3;
    }
    sayName(){
        console.log("this ninjas name is " + this.name)
    }

    showStats(){
        console.log("this ninjas stats: Name: " + this.name + ", Health: " + this.health + ", Speed:" + this.speed + ", Strenth: " + this.strength)
    }

    drinkSake(){
        this.health += 10;
        return this.health;
    }
}


class Sensei extends Ninja{
    constructor(name, health){
        super(name, health = 200)
        this.wisdom = 10;
        this.speed = 10;
        this.strength = 10;

    } 

    speakWisdom(){
        console.log("bababooey")
    }


}

const ninja1 = new Ninja("Hayabusa", 100)
const sensei1 = new Sensei("sifu")

sensei1.speakWisdom();
sensei1.showStats();