class Pet:
    #constructor
    def __init__ (self, name, type, tricks, health, energy):
        self.name = name    
        self.type = type
        self.tricks = tricks
        self.health = health
        self.energy = energy
    
    
    #increase pet energy by 25
    def sleep(self):
        self.energy = self.energy + 25
        print(f"{self.name} has slept. Energy is now at {self.energy}. was at {self.energy - 25}")
        return self
    #increase the pets energy by 5 and health by 10
    def eat(self):
        self.energy = self.energy + 5
        self.health = self.health + 10
        print(f"{self.name} ate. Energy is now at {self.energy} and Health is at {self.health}. Was at {self.energy - 5} energy and {self.health - 10} health.")
        return self
    
    #increase pet health by 5
    def play(self):
        self.health = self.health + 5
        print(f"{self.name} played and is now at {self.health} health. Health was at {self.health - 5}")
        return self
    
    #prints out the pet sound
    def noise(self):
        print(f"{self.name} said 'rip'")
