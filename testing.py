currentlvl = int(input("Type your current lvl "))
desiredlvl = int(input("Type the lvl you want to reach "))


def xpformulabeginning(lvl, end):
    tempend = end
    lvlrange = end - lvl
    temp = 0
    while tempend > 15:
        lvlrange -= 1
        tempend -= 1
        temp += 1
    xp = 0
    if end > 15:
        templvl = lvl + temp

    if temp > 0:
        xpend = xpformulaending(templvl, end)
        for i in range(lvlrange):
            xp += 1000 * (lvl + i)
        xp += xpend
        return xp

    for i in range(lvlrange):
        xp += 1000 * (lvl + i)
    return xp


def xpformulaending(lvl, end):
    lvlrange = end - lvl

    xp = 0
    for i in range(lvlrange):
        xp += 4000 * ((lvl + i+1) ** 0.5)
    return xp

xpbeginning = xpformulabeginning(currentlvl, desiredlvl)
xpending = xpformulaending(currentlvl, desiredlvl)


while True:
    if currentlvl < 15:
        print(f"The xp required to go from lvl {currentlvl} to lvl {desiredlvl} is {xpbeginning}xp")
        break
    else:
        print(f"The xp required to go from lvl {currentlvl} to lvl {desiredlvl} is {xpending}xp")
        break