class Zoo:
    def __init__(self,zoo_name):
        self.animals=[]
        self.name=zoo_name
    def AddAnimal(self,Animal):
        self.animals.append(Animal)
class Animal:
    def __init__(self,name):
        self.name=name
        self.legs=4
        self.head=1

okc_zoo= Zoo("okc_zoo")
bunny=Animal("bunny")
okc_zoo.animals.AddAnimals("bunny")