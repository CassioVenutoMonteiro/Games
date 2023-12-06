using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadores : MonoBehaviour
{
    public GameObject[] spikeTime;
    public GameObject[] spikeContraTime;
    float contSpike;
    // Start is called before the first frame update
    void Start()
    {
        contSpike = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contSpike += Time.deltaTime;
        if (contSpike >= 3 && contSpike < 6)
        {
            for(int i = 0; i < spikeContraTime.Length; i++)
            {
                spikeContraTime[i].SetActive(true);                
            }
            for (int i = 0; i < spikeTime.Length; i++)
            {
                spikeTime[i].SetActive(false);
            }           
        }
        else if(contSpike > 6)
        {
            for (int i = 0; i < spikeContraTime.Length; i++)
            {
                spikeContraTime[i].SetActive(false);
            }
            for (int i = 0; i < spikeTime.Length; i++)
            {
                spikeTime[i].SetActive(true);                
            }
            contSpike = 0;
        }
    }
}
