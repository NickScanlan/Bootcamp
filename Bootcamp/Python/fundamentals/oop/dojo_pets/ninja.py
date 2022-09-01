from pets import Pet

class Ninja:
    def __init__ (self, first_name, last_name ,treats ,pet_food):
        self.first_name = first_name
        self.last_name = last_name
        self.pet = Pet( name, type, tricks, health, energy)
        self.treats = treats 
        self.pet_food = pet_food
    
    #walk the ninjas pet play method
    def walk(self):
        print(f"{self.first_name} walked {Pet.name}")
        Pet.play()
    
    #feeds the ninjas pet from pet eat method
    def feed(self):
        print(f"{self.name} fed {Pet.name} {self.pet_food}")
        Pet.eat()
    
    #cleans the ninjas pet from pet noise method
    def bathe(self):
        print(f"{self.name} gave {Pet.name} a bath.")
        Pet.noise()

nick = Ninja('Nick', 'Scan', 'bones', 'kibble')











"""

Make an instance of a Ninja and assign them an instance of a pet to the pet attribute.

Have the Ninja feed, walk , and bathe their pet.

NINJA BONUS: Use modules to separate out the classes into different files.

SENSEI BONUS: Use Inheritance to create sub classes of pets.

Compress or zip up assignment and upload it.
"""