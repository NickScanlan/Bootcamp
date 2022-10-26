class Ninja {
    constructor (name, health){
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


const ninja1 = new Ninja("Hayabusa", 100)
ninja1.sayName();
ninja1.showStats();
console.log("------------------------------")
ninja1.drinkSake();
ninja1.showStats();