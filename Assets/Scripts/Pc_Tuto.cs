using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pc_Tuto : MonoBehaviour
{
    bool mouseOnObject;    
    public AudioSource construindo;
    public AudioSource nave_pousando;
    public Text missao;
    public Text dica;
    public static bool tutorial = false;
    private GameObject Jogador;
    public GameObject gera;
    public GameObject nave;
    [Range(0.1f, 10.0f)] private float distancia = 3.5f;

    void Start()
    {
        missao.enabled = false;
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Minerar_Tuto.azulita_tutorial == 7 && mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            construindo.Play();
            nave_pousando.PlayDelayed(3);
            gera.SetActive(true);
            nave.SetActive(true);
            missao.text = "Tarefas a concluir:\n\nEntre na Nave";
        }
        if (Minerar_Tuto.azulita_tutorial != 7 && mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            missao.enabled = true;
            dica.enabled = false;
            tutorial = true;
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