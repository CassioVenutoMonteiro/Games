using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnVoltar : MonoBehaviour
{
    public GameObject voltar;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Voltar()
    {
        voltar.SetActive(false);
        inicio.SetActive(true);
    }
}
