using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    public static float dir;
    Vector3 posiF;
    public SpriteRenderer a;
    float vida;
    public static bool ativa;
    Vector3 posi;
    Quaternion rota;
    // Start is called before the first frame update
    void Start()
    {
        dir = 1;
        a = GetComponent<SpriteRenderer>();
        vida = 10;
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
        posiF = transform.position;
        if (dir == 1)
        {
            a.flipX = false;
            Detec.posiD = new Vector3(posiF[0] - 1.5f, posiF[1] - 1.5f, 0);
        }
        else if(dir == -1)
        {
            a.flipX = true;
            Detec.posiD = new Vector3(posiF[0] + 1.5f, posiF[1] - 1.5f, 0);
        }
        GetComponent<Rigidbody2D>().velocity = Vector3.left * dir * 3;
        if(vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projetil"))
        {
            vida--;
        }
    }
}
