using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        //{
        //    Time.timeScale = 1;
        //    pause.SetActive(false);
        //}
    }
    public void Continuar()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
