using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaraVida : MonoBehaviour
{
    public static float vida = 1;
    public GameObject a;
    

    // Start is called before the first frame update
    void Start()
    {
        vida = 1;
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.localScale = new Vector3(vida, a.transform.localScale.y, a.transform.localScale.z);


    }
}
