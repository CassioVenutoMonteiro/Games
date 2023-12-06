using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class mover : MonoBehaviour
{
    float velocidade;
    float mh;
    float mv;
    float qtpulo;
    float pulo;
    Animator MeuAnimator;
    public static Vector3 posi;
    public static Quaternion rota;
    Vector3 atuPosi;
    public GameObject cair;
    public float r;
    public float cont;
    float caindo;
    SpriteRenderer a;
    public GameObject atirar;
    public GameObject pause;
    public static float atid;
    float conta;
    float contDano;
    bool dano;
    public GameObject[] inimigos;
    //public float mortes;
    public static float morte;
    //public float vida;
    public static bool CairMorango;
    public static bool MorangoMachuca;
    public GameObject chuva;
    float contP;
    float contPa;
    public GameObject pedra;
    public AudioClip andar, jump, hit;
    bool andando,nochao;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10;
        qtpulo = 1;
        pulo = 400f;
        MeuAnimator = GetComponent<Animator>();
        posi = transform.position;
        rota = transform.rotation;
        cair.SetActive(true);
        atirar.SetActive(true);
        a = GetComponent<SpriteRenderer>();
        atid = 1;
        Atirar.direcao = -1;
        contDano = 0;
        dano = false;
        morte = 0;
        contP = 0;
        andar = GetComponent<AudioClip>();
        //jump = GetComponent<AudioBehaviour>();
        //hit = GetComponent<AudioBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MorangoMachuca)
        {
            chuva.tag = "projetil";
        }
        else
        {
            chuva.tag = "Untagged";
        }
        
        //mortes = morte;
        mh = Input.GetAxis("Horizontal");
        mv = Input.GetAxis("Vertical");
        if (mh != 0)
        {
            MeuAnimator.SetBool("correr", true);
            andando = true;
        }
        else
        {
            MeuAnimator.SetBool("correr", false);
            andando = false;
        }
        if(mv > 0)
        {
            mv = 0;
        }
        

        transform.Translate(new Vector3(mh, mv, 0) * velocidade * Time.deltaTime);

        if (mh > 0)
        {
            a.flipX = false;
            atid = 1;
            Atirar.direcao = -1;
        }
        else if (mh < 0)
        {
            a.flipX = true;
            atid = -1;
            Atirar.direcao = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space) && qtpulo > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * pulo);
            qtpulo--;
            MeuAnimator.SetBool("pular", true);
            
        }
        //if(vida < 1)
        //{

        //}

        atuPosi = transform.position;
        if (atuPosi[1] < -20 || BaraVida.vida <= 0)
        {
            transform.position = posi;
            transform.rotation = rota;
            Natirar.ativa = true;
            Fantasma.ativa = true;
            BaraVida.vida = 1;
            pedra.transform.SetPositionAndRotation(Pedra.posi, mover.rota);
            pedra.GetComponent<Animator>().SetBool("reco", true);
            Pedra.reco = true;
            Pedra.cont = 0;
            morte++;
            for(int i = 0; i < inimigos.Length; i++)
            {
                inimigos[i].SetActive(true);
            }
        }

        if (caindo > atuPosi[1])
        {
            MeuAnimator.SetBool("cair", true);
            //MeuAnimator.SetBool("pular", false);
            MeuAnimator.SetBool("subindo", false);
            
        }
        else if(caindo < atuPosi[1])
        {
            //MeuAnimator.SetBool("pular", true);
            MeuAnimator.SetBool("cair", false);
            MeuAnimator.SetBool("subindo", true);
        }
        //else
        //{
        //    MeuAnimator.SetBool("cair", false);
        //    MeuAnimator.SetBool("subindo", false);
        //}
        caindo = atuPosi[1];

        cont += Time.deltaTime;
        r = Random.Range(transform.position.x + 7, transform.position.x - 7);
        if (CairMorango)
        {
            if (cont >= 0.15)
            {
                Instantiate(cair, new Vector2(r, transform.position.y + 8), Quaternion.identity);
                cont = 0;
            }
        }
        
        conta += Time.deltaTime;
        if (Input.GetKey(KeyCode.X) && conta > 1)
        {
            Instantiate(atirar, new Vector2(transform.position.x + 1 * atid, transform.position.y), Quaternion.identity);
            conta = 0;
        }
        contPa = Time.realtimeSinceStartup;
        if (TelaOver.ativoI != true && TelaOver.ativoO != true)
        {
            if (Input.GetKey(KeyCode.P) && Time.timeScale != 0 && contPa - contP >= 0.2)
            {
                Time.timeScale = 0;
                pause.SetActive(true);
                contP = contPa;
            }
            else if (Input.GetKey(KeyCode.P) && Time.timeScale == 0 && contPa - contP >= 0.2)
            {
                Time.timeScale = 1;
                pause.SetActive(false);
                contP = contPa;
            }
        }
        
        if (conta > 1)
        {
            BaraMana.mana = 1;
        }
        else
        {
            BaraMana.mana = conta;
        }
        if (dano || atuPosi[1] < -20)
        {
            contDano += Time.deltaTime;
            if(contDano > 0.165)
            {
                dano = false;
                MeuAnimator.SetBool("dano", false);
                contDano = 0;
                BaraVida.vida -= 0.20001f;
                
            }
        }
        //if (andando == true && nochao == true)
        //{
            
            
        //}
        //else
        //{
            
        //}

    }
    void OnCollisionEnter2D(Collision2D NomeColisao)
    {
        if (NomeColisao.gameObject.CompareTag("terreno"))
        {
            qtpulo = 1;
            MeuAnimator.SetBool("NoChao", true);
            MeuAnimator.SetBool("pular", false);
            MeuAnimator.SetBool("cair", false);
            MeuAnimator.SetBool("subindo", false);
            nochao = true;
        }
        if (NomeColisao.gameObject.CompareTag("projetil") || NomeColisao.gameObject.CompareTag("inimigo"))
        {
            MeuAnimator.SetBool("dano", true);
            dano = true;
            
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("terreno"))
        {
            MeuAnimator.SetBool("NoChao", false);
            nochao = false;
        }
        
    }
}
