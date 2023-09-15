
mem = []
for i in range(16):
    mem.append(i * 1000)

for i in range(16, 201):
    mem.append(4000 * i ** 0.5)


print(mem)

start = int(input("matan in current level: "))
stop = int(input("mata in level du ska till: "))

if stop > len(mem):
    #lägg till mer på mem

summa = 0
for i in range(start + 1, stop+1):
    summa += mem[i]
print(summa)