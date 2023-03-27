Algoritmo "Candidato"
// Autor : Davi dos Santos e Erick Felipe
// Data : 08/03/2023

Var     js, mj, jp, juncao, ganhador, conta, cand: real


Inicio

      escreval ("Digite 1 para Maria Juruma")
      escreval ("Digite 2 para João da Silva")
      escreval ("Digite 3 para João da Pamonha")
      MJ:=0
      JS:=0
      JP:=0
      escreva("Digite o nome de seu candidato: ")
      leia(cand)
      se (cand = 1)entao
          mj = mj + 1
          senao
               se(cand = 2)entao
                  js = js + 1
                  senao
                       se(cand = 3)entao
                          jp = jp + 1
                          senao
                               escreva("Inválido")
                fimse
           fimse
      fimse
      
      enquanto (js<mj E js<jp)
		ganhador:= js
 		escreva("O ganhador momentâneo é o João da Silva")
      fimenquanto
      
     	enquanto (mj<jp E mj<js)
		ganhador:= mj
		escreva("O ganhador momentâneo é a Maria Juruma")
      fimenquanto
      
	   enquanto (jp<mj E jp<js)
		ganhador:= jp
		escreva ("O ganhador momentâneo é o João da Pamonha")
		fimenquanto
		
	   juncao:= mj + jp + js
	   conta:= (ganhador+100)/juncao
	   escreva ("O candidato tem", conta "% de", juncao "votos")

Fimalgoritmo