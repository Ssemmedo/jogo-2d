using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moverPlayer : MonoBehaviour
{

    /*public float velocidade;
    
    public Animator anim;

    public static int pontuacao;

    public Text pontuacaoTela;

    public Text pontuacaoTelaSombra;

    private BoxCollider2D caixaColisao;

    private GameObject obstaculo;*/

    public Rigidbody2D rdb2D;

    //public static int moedas;

    public AudioClip efeitoSonoroMoedas;
    public AudioClip efeitoSonoroGato;
    public AudioClip efeitoSonoroItem;
    private AudioSource audioSource;

    public Text quantidadeMoedas;
    public Text quantidadeMoedasSombra;



    // Start is called before the first frame update
    void Start()
    {
        /*anim = GetComponent<Animator>();

        caixaColisao = GetComponent<BoxCollider2D>();

        pontuacao = 0;

        moedas = 0;

        obstaculo = GameObject.FindGameObjectWithTag("Obstaculos");*/

        rdb2D = GetComponent<Rigidbody2D>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rdb2D.AddForce(transform.up * 4000);

            //anim.SetTrigger("pulando");

        }
        else 
        {
            //anim.SetTrigger("correndo");
        }
    }
    /*
    void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.tag == "Obstaculos") 
        {
            Application.LoadLevel("gameover");
        }
    }

    public void adicionarMoedas() 
    {
        moedas++;

        quantidadeMoedas.text = moedas.ToString();
        quantidadeMoedasSombra.text = moedas.ToString();

        audioSource.PlayOneShot(efeitoSonoroMoedas);

    }

    public void adicionarPontos() 
    {
        pontuacao++;

        audioSource.PlayOneShot(efeitoSonoroItem);
    }*/


}
