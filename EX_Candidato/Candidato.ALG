Algoritmo "Candidato"
// Autor : Davi dos Santos e Erick Felipe
// Data : 08/03/2023

Var     js, mj, jp, juncao, ganhador, conta, cand: real
        resposta: caracter


Inicio

      escreval ("Digite 1 para Maria Juruma")
      escreval ("Digite 2 para Jo�o da Silva")
      escreval ("Digite 3 para Jo�o da Pamonha")
      mj:=0
      js:=0
      jp:=0
      escreva("Digite o nome de seu candidato: ")
      leia(cand)
      se (cand = 1)entao
          mj := mj + 1
          senao
               se(cand = 2)entao
                  js := js + 1
                  senao
                       se(cand = 3)entao
                          jp := jp + 1
                          senao
                               escreva("Inv�lido")
                fimse
           fimse
      fimse
      escreval ("Deseja votar mais uma vez? Digite s/n")
      leia (resposta)
      
      enquanto (resposta = "s")faca
               escreva("Digite o nome de seu candidato: ")
               leia(cand)
               se (cand = 1)entao
                  mj := mj + 1
               senao
                    se(cand = 2)entao
                            js := js + 1
                    senao
                       se(cand = 3)entao
                               jp := jp + 1
                       senao
                            escreva("Inv�lido")
                       fimse
                    fimse
               fimse
               escreval ("Deseja votar mais uma vez? Digite s/n")
               leia (resposta)
      fimenquanto
      
      se (js>mj)e(js>jp)entao
		    ganhador:= js
 		    escreva("O ganhador moment�neo � o Jo�o da Silva")
      senao
           se(mj>jp)e(mj>js)entao
              ganhador:= mj
              escreva("O ganhador moment�neo � a Maria Juruma")
           senao
                se(jp>mj) E (jp>js)entao
                   ganhador:= jp
                   escreva ("O ganhador moment�neo � o Jo�o da Pamonha")
                fimse
           fimse
      fimse
		
	   juncao:= mj + jp + js
	   conta:= (ganhador+100)/juncao
      escreval ("O candidato tem ",conta," % de ", juncao,"�votos")

Fimalgoritmo