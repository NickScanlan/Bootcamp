num1 = 42 # variable declaration, number
num2 = 2.3 # variable declaration, float
boolean = True #variable declaration, boolean
string = 'Hello World' #variable declaration, string
pizza_toppings = ['Pepperoni', 'Sausage', 'Jalepenos', 'Cheese', 'Olives'] #variable declaration, list
person = {'name': 'John', 'location': 'Salt Lake', 'age': 37, 'is_balding': False} #variable declaration, dictionary 
fruit = ('blueberry', 'strawberry', 'banana') #variable declaratiom, tuple
print(type(fruit)) #print variable type(tuple)
print(pizza_toppings[1]) #print list index
pizza_toppings.append('Mushrooms') #add value (mushroom) to list
print(person['name']) #print dictionary value 
person['name'] = 'George' #change value of 'name' to George
person['eye_color'] = 'blue' #cahnge value of 'eye__color' to blue 
print(fruit[2]) #print tuple index 2

if num1 > 45: # if conditional to print if num1 is greater than or less than 45
    print("It's greater")
else:
    print("It's lower")

if len(string) < 5: #if conditional of length of variable string is less than 5
    print("It's a short word!")#if less than 5
elif len(string) > 15:
    print("It's a long word!") #too long of a word if string is greater than 15
else:
    print("Just right!") # print just right 

for x in range(5): #for loop x is in 1 - 5 
    print(x)
for x in range(2,5): #x is inbetween 2 and 4 print x
    print(x)
for x in range(2,10,3): #x is inbetween 2 and 9 but increments of 3
    print(x)
x = 0 # variable declaration x is 0 
while(x < 5): # while loop x is less than 5 
    print(x) 
    x += 1 #increment x by 1 

pizza_toppings.pop() #remove last in list of pizza_toppings
pizza_toppings.pop(1) #remove index 1 of list of pizza_toppings

print(person) #print dictionary 
person.pop('eye_color') #remove key eye color
print(person) #print dictionary person with eye color removed 

for topping in pizza_toppings: #for loop for toppings inside pizzatoppings list
    if topping == 'Pepperoni':
        continue # if topping is equal to pepperoni, continue loop 
    print('After 1st if statement')#print the string 
    if topping == 'Olives': #if topping is equal to topping 
        break #break loop 

def print_hello_ten_times(): #define funtion
    for num in range(10): #for loop for num = 0 - 9
        print('Hello')

print_hello_ten_times() #will call function 10 times because of loop within function 

def print_hello_x_times(x):
    for num in range(x):
        print('Hello')

print_hello_x_times(4) #call function 4 times 

def print_hello_x_or_ten_times(x = 10): #define function with parameter x = 10 
    for num in range(x): #for loop range of x
        print('Hello')

print_hello_x_or_ten_times() # x = 10 within function. prints hello 10 times 
print_hello_x_or_ten_times(4) # 4 does not equal to 10. will not print hello