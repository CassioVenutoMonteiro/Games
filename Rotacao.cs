using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    float velocidade;
    float r;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 1;
        r = 3;
    }

    // Update is called once per frame
    void Update()
    {
        r++;
        GetComponent<Rigidbody2D>().rotation = r / velocidade;
       
    }
}
