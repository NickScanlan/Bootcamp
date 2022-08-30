#countdown
def countDown(num):
    arr = []
    for i in range(num, -1, -1):
        arr.append(i)
    return arr

print(countDown(12))

# Print and Return

def pnr(a_list):
    print(a_list[0])
    return a_list[1]

pnr(["a", "b"])

# first plus length

def fplusl(a_list):
    return a_list[0] + len(a_list)

print(fplusl([1, 2, 3, 4, 5, 6]))

# Values Greater than Second

def values_greater_than_second(a_list):
    arr = []
    for i in range(len(a_list)):
        if a_list[i] > a_list[1]:
            arr.append(a_list[i])
    print(len(arr))
    return arr

print(values_greater_than_second([5,2,7,1,2,3,4,5]))


#This Length, That Value 

def this_length_that_value(size, value):
    arr = []
    for i in range(0, size):
        arr.append(value)
    return arr

print(this_length_that_value(13, 0))