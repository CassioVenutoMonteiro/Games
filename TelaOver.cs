using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TelaOver : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public static bool ativoO = false;
    public static bool ativoI = true;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.GetComponent<TMPro.TextMeshProUGUI>().text = mover.morte.ToString();
    }
}
