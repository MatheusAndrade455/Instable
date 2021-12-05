using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_Jogo : MonoBehaviour
{
    bool mouseOnObject;
    private GameObject Jogador;
    public GameObject menu;
    [Range(0.1f, 10.0f)] private float distancia = 3.5f;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            menu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Jogador.GetComponent<FirstPersonController>().enabled = false;
        }
        if (Jogador.GetComponent<FirstPersonController>().enabled && Cursor.visible)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
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
