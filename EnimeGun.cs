using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimeGun : MonoBehaviour
{
    public static float direcao;
    // Start is called before the first frame update
    void Start()
    {
        direcao = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Rigidbody2D>().velocity = Vector3.left * 3 * direcao;
    }
}
