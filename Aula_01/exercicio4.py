import math
alt = int(input("Digite altura:" ))
base = int(input("Digite a base:" ))

area = alt * base
perimetro = (2*base) + (2*alt)
diagonal = math.sqrt(base**2 + alt**2)

print("Área: ",area, "Perimetro: ",perimetro, "Diagonal: ",diagonal) 