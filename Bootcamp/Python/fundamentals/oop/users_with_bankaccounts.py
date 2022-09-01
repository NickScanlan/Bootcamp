class BankAccount:
    def __init__(self, checking, savings):
        self.checking = checking(int_rate = 0.2 * checking)
        self.savings = savings
        

 



class User:
    def __init__(self,first_name, last_name, BankAccount):
        self.first_name = first_name
        self.last_name = last_name
        self.checking = BankAccount.checking
        self.savings = BankAccount.savings
    def display_info(self):
        print(f"{self.first_name}, {self.last_name}")
        return self



        
nick = User("nick", "scan", "jfkds@fad.com", 342)
user2 = User("user", "two", "jfkds@fad.com", 432)
user3 = User("user", "three", "jfkds@fad.com", 332)

nick.display_info()
print('-------------------------------------------------------------')
user2.display_info()
print('-------------------------------------------------------------')
user3.display_info()