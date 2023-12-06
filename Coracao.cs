using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coracao : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BaraVida.vida <= 0.799999)
        {
            GetComponent<PolygonCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("principal"))
        {
            if (BaraVida.vida <= 0.799999)
            {
                this.gameObject.SetActive(false);
                BaraVida.vida += 0.20001f;
            } 
        }
    }
}
