Algoritmo "Posto"
// Autor : Davi dos Santos e Erick Felipe
// Data : 08/03/2023
Var     litros, valor, conta: real
        comb: caracter

Inicio
      escreval("Digite (A) para Ácool")
      escreval("Digite (G) para Gasolina")
      escreval("Digite aqui o tipo de combustível: ")
      leia(comb)
     	escreva ("Digite aqui a quantidade de litros: ")
	   leia(litros)
	se (comb = "A")entao
		se(litros=20)entao
			conta:=(litros*14.7)/100

			escreval("O preço com de desconto será de:",valor)
		senao
			conta:=(litros*24.5)/100
			valor:=(litros*4.90)-conta
			escreval ("O preço a ser pago será de:", valor)
		fimse
	senao
		se(litros=20)entao
			conta:=(litros*22)/100
			valor:=(litros*5.50)-conta
			escreval("O preço a ser pago com desconto será de: conta")
		senao
			conta:=(litros*33)/100
			valor:=(litros*5.50)-conta
			escreval ("O preço a ser pago será de: ", valor)
		fimse
fimse
Fimalgoritmo