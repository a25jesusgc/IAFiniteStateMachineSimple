# Exercicio IA Avanzada FSM Simple

Primeiro engadín ao **PlayerController** a función para lanzar bombas coa E. Para isto, creei dous *prefabs*, un para a bomba e outra para a súa explosión. Ao premer E, chámase o método **ThrowBomb** que *instancia* a bomba cunha forza cara diante do xogador (AddForce ao seu Rigidbody con dirección transform.forward do xogador). A bomba ten un novo script que é **BombController**, no cal ao pasar a súa duración a bomba explota, *instanciando* o efecto da explosión.

Unha vez engadida a mecánica de lanzar bombas, engadín un novo estado ao **GuardController**, **Reunite**.

Para facelo, engadín o novo estado no enum **States**, chameino *Reunite*, xa que se reúne co resto no seu punto de reunión.
Engadín unha nova función chamada **Reunite** para este estado no cal se move cara o punto de reunión, e, unha vez chega ata el, volve ao estado de patrullar (**Patrol**). Ademáis, engadín tamén a funcion **SetStateReunite** que notifica ao garda entrando no **State Reunite**, o cal se chama desde o *PlayerController* cando o garda está preto dunha bomba, ademáis de poñer no seu *Update* unha condición para que se esta fuxindo (volvendo ao punto de reunión) non cambie de estado.
Na escena engadín tres puntos de reunión diferentes (os Transform en ReunionPoints), e asigneille a cada garda o seu punto de reunión máis próximo, para que vaia cara el cando o xogador lance una bomba preto.