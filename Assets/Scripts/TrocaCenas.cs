using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCenas : MonoBehaviour
{
    public static int CenaNave;
    public static int CenaGreenvalley;
    public static int CenaWinterfell;
    public static int CenaDune;
    public static int CenaRupture;
    public static int CenaNightmare;

    bool mouseOnObject;    
    private GameObject Jogador;
    public int cena;
    [Range(0.1f, 10.0f)] private float distancia = 7.5f;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            if(cena==3){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
            else{
                SceneManager.LoadScene(cena);
            }
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

    public void MudaCena()
    {
        SceneManager.LoadScene(cena);
    }
}
