using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public static float direcao;
    float dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = direcao;
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = Vector3.left * 10 * dir;
        
    }
}
