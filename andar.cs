using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{
    //cria as variaveis
    float velocidade;
    float mh;
    float mv;
    float qtpulo;
    float pulo;
    // executa assim que inicia
    void Start()
    {
        // atribue a variavel seu valor inicial
        velocidade = 20;
        qtpulo = 1;
        pulo = 400f;

    }

    // executa o tempo todo por frame
    void Update()
    {
        mh = Input.GetAxis("Horizontal"); // recebe 1 se apertar d e -1 se apertar a 
        mv = Input.GetAxis("Vertical"); // recebe 1 se apertar w e -1 se apertar s
        // coloca movimento no objeto em que este codigo esta
        transform.Translate(new Vector3(mh, mv, 0) * velocidade * Time.deltaTime);// Time.deltaTime: a velocidade do frame passa a não importar

        // verifica se a tecla (no caso) espaco esta precionada
        if (Input.GetKeyDown(KeyCode.Space) && qtpulo > 0)
        {
            // faz o objeto pular de uma forma mais liza do que o transform
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * pulo);
            // andar cada vez que pular, tera um pulo a menos no ar
            qtpulo--;
        }
    }
    // quando colidir o codigo que esta dentro dele e executado
    void OnCollisionEnter2D(Collision2D NomeColisao)// <- nome colisao pode ser qualquer nome
    {
        // compara se a colisao esta sendo no objeto desejado (no caso o terreno)
        if (NomeColisao.gameObject.CompareTag("terreno")) // esse tem que ser o mesmo nome da tile pallet
        {
            // toda vez que encostar no chao, a quantidade de pulo restante sera resetada de acordo com o numero abaixo
            qtpulo = 1;
        }

    }
}
