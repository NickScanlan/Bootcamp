
# Create a BankAccount class with the attributes interest rate and balance
class BankAccount:
    # don't forget to add some default values for these parameters!
    def __init__(self, int_rate, balance): 
        # your code here! (remember, instance attributes go here)
        self.int_rate = int_rate
        self.balance = balance
        # don't worry about user info here; we'll involve the User class soon
    def deposit(self, amount):
        self.balance += amount
        return self
        # your code here
    def withdraw(self, amount):
        self.balance -= amount
        return self
        # your code here
    def display_account_info(self):
        
        # your code he 
        print(self.balance)        
        return self
    def yield_interest(self):
        # your code here
        self.balance += (self.balance * self.int_rate)
        return self



user1 = BankAccount(.25, 1000)    
user2 = BankAccount(.20, 1000)        

user1.deposit(200).deposit(200).deposit(200).withdraw(10).yield_interest().display_account_info()
user2.deposit(300).deposit(400).withdraw(30).withdraw(30).withdraw(40).withdraw(10).yield_interest().display_account_info()

""""
# NINJA BONUS: use a classmethod to print all instances of a Bank Account's info
"""