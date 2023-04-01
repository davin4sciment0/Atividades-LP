Algoritmo "Tabuada"
// Autor(a)    : Davi dos Santos e Erick Felipe
Var
   tab, num, conta: inteiro

Inicio
   escreva("Escreva a abuada que você deseja encontrar: ")
   leia (tab)
   num:= 0
   repita
         conta:= num*tab
         escreval (tab, " x", num, " =", conta)
         num:= num+1
   ate (num >10)
Fimalgoritmo