using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reco : MonoBehaviour
{
    public GameObject prin;
    public GameObject over;
    public GameObject inicio;
    public GameObject[] inimigos;
    public GameObject pedra;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Recomecar()
    {
        prin.transform.SetPositionAndRotation(mover.posi, mover.rota);
        pedra.transform.SetPositionAndRotation(Pedra.posi, mover.rota);
        pedra.GetComponent<Animator>().SetBool("reco", true);
        Pedra.reco = true;
        Pedra.cont = 0;
        //pedraA.SetBool("reco", true);
        Natirar.ativa = true;
        Fantasma.ativa = true;
        BaraVida.vida = 1;
        mover.morte = 0;
        for (int i = 0; i < inimigos.Length; i++)
        {
            inimigos[i].SetActive(true);
            Debug.Log(i);
        }
        inimigos[2].SetActive(true);
        over.SetActive(false);
        TelaOver.ativoO = false;
        inicio.SetActive(true);
        TelaOver.ativoI = true;
    }
}
