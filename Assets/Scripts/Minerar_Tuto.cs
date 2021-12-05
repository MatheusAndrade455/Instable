using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minerar_Tuto : MonoBehaviour
{
    // public AudioSource minerando;
    public static int azulita_tutorial;
    bool mouseOnObject;
    bool parou = false;
    Vector3 resize = new Vector3(5.0f, 5.0f, 5.0f);
    [Range(0.1f, 10.0f)] private float distancia = 3.5f;
    private GameObject Jogador;
    public Text _text;
    public AudioSource minerando;    

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");       
    }

    void Update()
    {
        if (azulita_tutorial == 7 && parou == false)
        {
            _text.text = "Tarefas a concluir:\n\nInteraja com o computador para construir um gerador no centro da base";
            parou = true;            
        }
        if (Pc_Tuto.tutorial == true && mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            minerando.Play();
            transform.localScale = transform.localScale - resize;
            azulita_tutorial++;
            _text.text = $"Tarefas a concluir:\n\n- Pegue 7 minérios de azulita ({azulita_tutorial}/7).";
        }
    }

    private void OnMouseEnter()
    {
        mouseOnObject = true;
    }


    private void OnMouseExit()
    {
        mouseOnObject = false;
    }
}