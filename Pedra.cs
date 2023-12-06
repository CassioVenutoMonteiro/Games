using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour
{
    public Transform a;
    float vel;
    public static Vector3 posi;
    public static float cont;
    float dir;
    float contAtaque;
    Animator pedraA;
    public static bool reco;
    // Start is called before the first frame update
    void Start()
    {
        vel = 3;
        posi = transform.position;
        contAtaque = 0;
        pedraA = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cont += Time.deltaTime;
        contAtaque -= Time.deltaTime;
        dir = contAtaque > 0 ? -1 : 1;
        if(cont >= 1 && reco)
        {
            pedraA.SetBool("reco", false);
            reco = false;
        }
        else if(cont >= 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, a.position * dir, vel * Time.deltaTime);
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("principal"))
        {
            contAtaque = 5;
        }
    }
}
