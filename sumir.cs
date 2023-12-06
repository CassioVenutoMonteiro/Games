using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumir : MonoBehaviour
{
    public GameObject cair;
    Vector3 posi;
    Quaternion rota;
    Vector3 atuPosi;
    // Start is called before the first frame update
    void Start()
    {
        posi = transform.position;
        rota = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        atuPosi = transform.position;
        if (atuPosi[1] < -20 || atuPosi[0] > 100 || atuPosi[0] < -25)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D NomeColisao)
    {
        if (NomeColisao.gameObject.CompareTag("terreno"))
        {
            Destroy(gameObject);
        }
        if (NomeColisao.gameObject.CompareTag("colisor"))
        {
            Destroy(gameObject);
        }
        if (NomeColisao.gameObject.CompareTag("inimigo"))
        {
            Destroy(gameObject);
        }
    }
}
