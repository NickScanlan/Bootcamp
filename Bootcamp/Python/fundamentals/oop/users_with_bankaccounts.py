class BankAccount:
    def __init__(self, checkingAmount, savingsAmount):
        rate = 0.2
        self.checking = checkingAmount(int(rate) * int(checkingAmount))
        self.savings = savingsAmount


 



class User:
    def __init__(self,first_name, last_name, BankAccount):
        self.first_name = first_name
        self.last_name = last_name
        self.checking = BankAccount.checking
        self.savings = BankAccount.savings
    def display_info(self):
        print(f"{self.first_name}, {self.last_name}")
        return self
    def make__deposit(self):
        


        
nick = User("nick", "scan", "jfkds@fad.com", 342, BankAccount (100,100))
# user2 = User("user", "two", "jfkds@fad.com", 432)
# user3 = User("user", "three", "jfkds@fad.com", 332)

nick.display_info()
print('-------------------------------------------------------------')
# user2.display_info()
# print('-------------------------------------------------------------')
# user3.display_info()


# Add a make_deposit method to the User class that calls on it's bank account's instance methods.

# Add a make_withdrawal method to the User class that calls on it's bank account's instance methods.

# Add a display_user_balance method to the User class that displays user's account balance

# SENSEI BONUS: Allow a user to have multiple accounts; update methods so the user has to specify which account they are withdrawing or depositing to

# SENPAI BONUS: Add a transfer_money(self, amount, other_user) method to the user class that takes an amount and a different User instance, and transfers money from the user's account into another user's account.