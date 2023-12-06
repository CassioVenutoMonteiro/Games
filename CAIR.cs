using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIR : MonoBehaviour
{
    public GameObject cair;
    public float r;
    public float cont;
    
    void Start()
    {
        cair.SetActive(true);
        
    }
    
    void Update()
    {
        cont += Time.deltaTime;
        r = Random.Range(transform.position.x + 3, transform.position.x - 3);

        if (cont >= 0.2){
            Instantiate(cair, new Vector2(r, transform.position.y + 8), Quaternion.identity);
            cont = 0;
        }       
    }

    void OnCollisionEnter2D(Collision2D NomeColisao)
    {
        if (NomeColisao.gameObject.CompareTag("colisor"))
        {
            transform.Translate(new Vector3(-transform.position.x, -transform.position.y, 0));
        } 
    }
}
