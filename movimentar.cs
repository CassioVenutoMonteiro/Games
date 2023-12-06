using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar : MonoBehaviour
{
    float velocidade;
    float mh;
    float mv;
    float qtpulo;
    float pulo;
    Animator MeuAnimator;
    Vector3 posi;
    Quaternion rota;
    Vector3 atuPosi;
    //public float vida;


    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        qtpulo = 1;
        pulo = 400f;
        MeuAnimator = GetComponent<Animator>();
        posi = transform.position;
        rota = transform.rotation;
        //vida = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        mh = Input.GetAxis("Horizontal");
        mv = Input.GetAxis("Vertical");
        if(mh > 0)
        {
            MeuAnimator.SetBool("correr", true);
        }else if(mh < 0)
        {
            MeuAnimator.SetBool("correr", true);
        }
        else
        {
            MeuAnimator.SetBool("correr", false);
        }
        transform.Translate(new Vector3(mh, mv, 0) * velocidade * Time.deltaTime);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.Space) && qtpulo > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * pulo);
            qtpulo--;
            MeuAnimator.SetBool("Pulando", true);
        }
        //if(vida < 1)
        //{

        //}

        atuPosi = transform.position;
        //Debug.Log(atuPosi[1]);
        if (atuPosi[1] < -20)
        {
            transform.position = posi;
            transform.rotation = rota;
        }
    }
    void OnCollisionEnter2D(Collision2D NomeColisao)
    {
        if (NomeColisao.gameObject.CompareTag("terreno"))
        {
            qtpulo = 1;
            MeuAnimator.SetBool("NoChao", true);
            MeuAnimator.SetBool("pulando", false);
        }
        else
        {
            
            MeuAnimator.SetBool("NoChao", false);
        }
        
       
        //if (NomeColisao.gameObject.CompareTag("Strawberry_0"))
        //{
        //    vida--;
        //}
        
    }
}
