using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnControles : MonoBehaviour
{
    public GameObject con;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Controles()
    {
        con.SetActive(true);
        inicio.SetActive(false);
    }
}
