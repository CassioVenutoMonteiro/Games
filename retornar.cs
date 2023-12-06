using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retornar : MonoBehaviour
{
    Quaternion rota;
    Vector3 posi;
    Vector3 atuPosi;
    
    void Start()
    {
        posi = transform.position;
        rota = transform.rotation;
    }

    void Update()
    {
        atuPosi = transform.position;
        //Debug.Log(atuPosi[1]);
        if (atuPosi[1] < -20)
        {
            transform.position = posi;
            transform.rotation = rota;
        }
    }
}
