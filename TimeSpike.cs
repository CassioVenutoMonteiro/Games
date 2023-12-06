using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpike : MonoBehaviour
{
    float cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cont = Time.deltaTime;
        if (cont > 3)
        {
            this.gameObject.SetActive(true);
        }else if(cont > 6)
        {
            this.gameObject.SetActive(false);
            cont = 0;
        }
    }
}
