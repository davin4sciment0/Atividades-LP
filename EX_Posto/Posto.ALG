Algoritmo "Posto"
// Autor : Davi dos Santos e Erick Felipe
// Data : 08/03/2023
Var     litros, valor, conta: real
        comb: caracter

Inicio
      escreval("Digite (A) para �cool")
      escreval("Digite (G) para Gasolina")
      escreval("Digite aqui o tipo de combust�vel: ")
      leia(comb)
     	escreva ("Digite aqui a quantidade de litros: ")
	   leia(litros)
	se (comb = "A")entao
		se(litros=20)entao
			conta:=(litros*14.7)/100

			escreval("O pre�o com de desconto ser� de:",valor)
		senao
			conta:=(litros*24.5)/100
			valor:=(litros*4.90)-conta
			escreval ("O pre�o a ser pago ser� de:", valor)
		fimse
	senao
		se(litros=20)entao
			conta:=(litros*22)/100
			valor:=(litros*5.50)-conta
			escreval("O pre�o a ser pago com desconto ser� de: conta")
		senao
			conta:=(litros*33)/100
			valor:=(litros*5.50)-conta
			escreval ("O pre�o a ser pago ser� de: ", valor)
		fimse
fimse
Fimalgoritmo