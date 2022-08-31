class User:
    def __init__(self, first_name, last_name, email, age):
        self.fist_name = first_name
        self.last_name = last_name
        self.email = email
        self.age = age
        self.is_rewards_member = False
        self.gold_card_points = 0
   
    def display_info(self):
        
        

    def enroll(self):
        if self.is_rewards_member == True:
            self.gold_card_points = (self.gold_card_points + 200)

user1 = User('nick', 'scan', 'lfdjlfs@jfkdls.com', 854)

