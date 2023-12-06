using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detec : MonoBehaviour
{
    public static Vector3 posiD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = posiD;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("terreno"))
        {
            Fantasma.dir = Fantasma.dir * -1;
        }
    }
}
