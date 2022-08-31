class User:
    def __init__(self,first_name, last_name, email, age, is_rewards_member = False, gold_card_points = 0):
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.age = age
        self.is_rewards_member = is_rewards_member 
        self.gold_card_points = gold_card_points
    def display_info(self):
        print(f"{self.first_name}, {self.last_name}, {self.email}, {self.age}, {self.is_rewards_member}, {self.gold_card_points}")
        return self
    def enroll(self):
        self.is_rewards_member = True
        self.gold_card_points += 200
        return self
    def spend_points(self, amount):
        self.gold_card_points -= amount 
        return self
        
nick = User("nick", "scan", "jfkds@fad.com", 342)
user2 = User("user", "two", "jfkds@fad.com", 432)
user3 = User("user", "three", "jfkds@fad.com", 332)

nick.display_info().enroll().spend_points(42).display_info() 
print('-------------------------------------------------------------')
user2.display_info().enroll().spend_points(341).display_info()
print('-------------------------------------------------------------')
user3.display_info().enroll().spend_points(12).display_info()