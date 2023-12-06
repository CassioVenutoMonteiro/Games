using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBugs : MonoBehaviour
{
    public GameObject bug;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Bugs()
    {
        bug.SetActive(true);
        inicio.SetActive(false);
    }
}
