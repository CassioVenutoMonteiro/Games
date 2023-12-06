using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInv : MonoBehaviour
{
    float cont;
    Vector3 posi;
    // Start is called before the first frame update
    void Start()
    {
        posi = transform.position;
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {

        cont += Time.deltaTime;

        if (cont <= 3)
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.left * 3;
        }
        else if (cont <= 6)
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.right * 3;
        }
        else
        {
            cont = 0;
            transform.position = posi;
        }
    }
}
