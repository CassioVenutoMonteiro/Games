using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPara : MonoBehaviour
{
    public Transform[] a;
    int posi;
    float vel;
    // Start is called before the first frame update
    void Start()
    {
        posi = 0;
        vel = 10;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position,a[posi].position,vel * Time.deltaTime);
        if (transform.position.x == a[posi].position.x && transform.position.y == a[posi].position.y)
        {
            if(posi == a.Length - 1)
            {
                posi = 0;
            }
            else
            {
                posi++;
            }
        }
    }
}
