using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nivel : MonoBehaviour
{
    public TextMeshProUGUI texto;
    string dificuldade;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mover.MorangoMachuca == true && mover.CairMorango == true)
        {
            dificuldade = "Impossivel";
        }
        else if(mover.MorangoMachuca != true && mover.CairMorango != true)
        {
            dificuldade = "Nutela";
        }
        else if (mover.MorangoMachuca != true && mover.CairMorango == true)
        {
            dificuldade = "Normal";
        }
        texto.GetComponent<TMPro.TextMeshProUGUI>().text = dificuldade;
    }
}
