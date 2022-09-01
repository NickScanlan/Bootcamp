
class BankAccount:

    def __init__(self, int_rate, balance): 
        self.int_rate = int_rate
        self.balance = balance
    def deposit(self, amount):
        self.balance += amount
        return self
    
    def withdraw(self, amount):
        self.balance -= amount
        return self
    
    def display_account_info(self): 
        print(self.balance)        
        return self
    
    def yield_interest(self):
        self.balance += (self.balance * self.int_rate)
        return self


class User:
    def __init__(self,first_name, last_name, email, age):
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.age = age
        self.account = BankAccount(.12, 2000)
    def display_info(self):
        print(f"user {self.first_name}, {self.last_name}, {self.email}, {self.age}")

nick = User('nick', 'scan', 'fds@fdsa.com', 6654)

nick.account.deposit(200).display_account_info()