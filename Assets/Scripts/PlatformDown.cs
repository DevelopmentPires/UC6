using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour {

    public float tremerIntensidade = 0.02f;
    public float tremerVelocidade = 0.009f;
    private float tremerFator;
    private Vector3 posicaoOriginal;
    private Quaternion rotacaoOriginal;
    public bool touchLava = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (tremerFator > 0)
        {
            transform.position = posicaoOriginal + Random.insideUnitSphere * tremerFator;
            transform.rotation = new Quaternion(
            rotacaoOriginal.x + Random.Range(-tremerFator, tremerFator) * .1f,
            rotacaoOriginal.y + Random.Range(-tremerFator, tremerFator) * .3f,
            rotacaoOriginal.z + Random.Range(-tremerFator, tremerFator) * .1f,
            rotacaoOriginal.w + Random.Range(-tremerFator, tremerFator) * .1f);
            tremerFator -= tremerVelocidade;
            rotacaoOriginal.y -= 0.01f;
        }

        if (touchLava)
        {
            rotacaoOriginal.y -= 0.01f;
            transform.Translate(-0.01f,0,0);
        }

        if (true) { } //Fazer aqui, se a plataforma se distanciar muito da lava, destroi, para não ficar voando no espaço)
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Lava")
        {
            touchLava = true;
        }

        if (collision.transform.tag != "Lava" && collision.transform.tag != "Player" && 
            collision.transform.tag != "Scenario" && collision.transform.tag != "Platforms")
        {
            Destroy(gameObject);
            Debug.Log(collision.transform.name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            posicaoOriginal = transform.position;
            rotacaoOriginal = transform.rotation;
            tremerFator = tremerIntensidade;
        }
    }
}
