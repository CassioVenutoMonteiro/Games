using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("principal"))
        {
            win.SetActive(true);
            Time.timeScale = 0;
            TelaOver.ativoO = true;
            //SceneManager.LoadScene("nome_da_sena");
            // carrega uma nova cena ↑

        }
    }
}
