using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaraMana : MonoBehaviour
{
    public static float mana;
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        mana = 1;
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.localScale = new Vector3(mana, a.transform.localScale.y, a.transform.localScale.z);
    }
}
