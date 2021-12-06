using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Minerar_Jogo : MonoBehaviour
{

    bool mouseOnOre;
    private GameObject Jogador;
    public AudioSource minerando;
    public AudioSource quebrando;

    public Dictionary<string, float> tamanhos;

    private string[] keysQuebrando = new string[]{
        "arvore",
        "palmeira",
        "cactus",
        "dead_wood",
        "frozen_wood"
    };

    private string[] keysMinerando = {
        "pedra",
        "azulita",
        "ouro",
        "rosita",
        "fireore",
        "ferro",
        "esmeralda",
        "grafite",
        "perolado",
        "ice"
    };

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");

        tamanhos = new Dictionary<string, float>();

        tamanhos.Add("arvore", 0.5f);
        tamanhos.Add("pedra", 0.5f);
        tamanhos.Add("azulita", 8.0f);
        tamanhos.Add("ouro", 5.0f);
        tamanhos.Add("rosita", 4.5f);
        tamanhos.Add("fireore", 7.5f);
        tamanhos.Add("ferro", 0.5f);
        tamanhos.Add("palmeira", 0.5f);
        tamanhos.Add("cactus", 0.5f);
        tamanhos.Add("esmeralda", 4.0f);
        tamanhos.Add("grafite", 0.021f);
        tamanhos.Add("dead_wood", 0.0042f);
        tamanhos.Add("perolado", 1.0f);
        tamanhos.Add("frozen_wood", 0.5f);
        tamanhos.Add("ice", 1.5f);
    }

    void TocarSom(string nome)
    {
        if(keysQuebrando.Contains(nome)) quebrando.Play();
        else if(keysMinerando.Contains(nome)) minerando.Play();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 2.5f) && Input.GetKeyDown(KeyCode.F))
        {
            var player = Jogador.GetComponent<FirstPersonController>();

            string nome = hit.transform.tag;

            if (tamanhos.ContainsKey(nome))
            {
                TocarSom(nome);

                player.inventario.Adicionar(nome, 1);

                float tam = tamanhos[nome];

                if (tam != 0)
                {
                    if (
                        tam * 1.2 >= hit.transform.localScale.x ||
                        tam * 1.2 >= hit.transform.localScale.y ||
                        tam * 1.2 >= hit.transform.localScale.z
                    )
                    {
                        Destroy(hit.transform.gameObject);
                    }
                    else
                    {
                        hit.transform.localScale -= new Vector3(tam, tam, tam);
                    }
                }
                else Destroy(hit.transform.gameObject);
            }
        }
    }
}
