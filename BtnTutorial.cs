using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTutorial : MonoBehaviour
{
    public GameObject tut;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Tutorial()
    {
        tut.SetActive(true);
        inicio.SetActive(false);
    }
}
