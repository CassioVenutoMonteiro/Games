using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnImpossivel : MonoBehaviour
{

    public GameObject inicio;
    public GameObject rodando;
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        inicio.SetActive(true);
        rodando.SetActive(false);
        pause.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Jogar()
    {

        inicio.SetActive(false);
        rodando.SetActive(true);
        Time.timeScale = 1;
        mover.MorangoMachuca = true;
        mover.CairMorango = true;
        TelaOver.ativoI = false;
    }
}
