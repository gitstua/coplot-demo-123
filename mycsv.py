# we have 10 rows and 7 seats per row. select a random seat
# and print the row and seat number
import random
row = random.randint(1,10)
seat = random.randint(1,7)
print(f'Your seat is row {row} seat {seat}')
