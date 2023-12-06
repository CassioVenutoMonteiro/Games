using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Natirar : MonoBehaviour
{
    public GameObject atirar;
    float atid;
    SpriteRenderer dir;
    float cont;
    float cont1;
    float cont2;
    Animator MeuAnimator;
    bool dano;
    public static float diracao;
    Vector3 posi;
    Quaternion rota;
    public static bool ativa;
    // Start is called before the first frame update
    void Start()
    {
        dano = false;
        MeuAnimator = GetComponent<Animator>();
        cont = 0;
        cont1 = 0;
        cont2 = 0;
        dir = this.GetComponent<SpriteRenderer>();
        EnimeGun.direcao = 1;
        posi = transform.position;
        rota = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (ativa == true)
        {
            transform.position = posi;
            transform.rotation = rota;
            ativa = false;
        }

        if (dano)
        { 
            cont2 += Time.deltaTime;
            if(cont2 > 0.2)
            {
                this.gameObject.SetActive(false);
                dano = false;
                cont2 = 0;
            }
        }
        else
        {


            if (dir.flipX == true)
            {
                atid = 1;
                EnimeGun.direcao = -1;
            }
            else
            {
                atid = -1;
                EnimeGun.direcao = 1;
            }
            cont1 += Time.deltaTime;
            if (cont1 >= 4)
            {
                cont += Time.deltaTime;
                MeuAnimator.SetBool("atacar", true);
                if (cont >= 0.210)
                {
                    Instantiate(atirar, new Vector2(transform.position.x + 1 * atid, transform.position.y), Quaternion.identity);
                    cont = 0;
                    cont1 = 0;
                    MeuAnimator.SetBool("atacar", false);
                }
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projetil"))
        {
            MeuAnimator.SetBool("dano", true);
            dano = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projetil"))
        {
            MeuAnimator.SetBool("dano", false);
        }
    }
}
