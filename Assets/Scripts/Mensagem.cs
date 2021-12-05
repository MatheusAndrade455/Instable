using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour
{

    public Text texto;
    private GameObject Jogador;

    void Start()
    {
        //reconhecer o jogador
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {

    }

    //se o jogador estiver encostando no objeto, o texto irá aparecer
    public void OnTriggerEnter(Collider other)
    {
        texto.enabled = true;
    }

    //se o jogador parar de encostar no objeto, o texto irá desaparecer
    public void OnTriggerExit(Collider other)
    {
        texto.enabled = false;
    }
}
