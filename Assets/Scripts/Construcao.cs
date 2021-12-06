using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Construcao : MonoBehaviour
{
    public bool Teste = false;

    public GameObject construcao;
    public Button botao1;
    public Button botao2;
    public Button botao3;
    public Button botao4;
    
    public Button gerador;
    public Button dormitorio;
    public Button banheiro;
    public Button agua;
    public Button cozinha;
    public Button terra;
    public Button abre01;
    public Button abre02;
    public AudioSource construindo;

    private Dictionary<string, int> AtribuirRecurso(string tipo)
    {
        switch (tipo)
        {
            case "Gerador":
                return new Dictionary<string, int>{
                    {"arvore", 15},
                    {"pedra", 45}
                };
            case "Modulo1":
                return new Dictionary<string, int>
                {
                    {"arvore", 40},
                    {"pedra", 40}
                };
            case "Modulo2":
                return new Dictionary<string, int>
                {
                    {"frozen_wood", 40},
                    {"azulita", 20},
                    {"arvore", 10},
                    {"pedra", 10}
                };
            case "Modulo3":
                return new Dictionary<string, int>
                {
                    {"rosita", 20},
                    {"fireore", 20},
                    {"azulita", 20},
                    {"ferro", 40},
                    {"arvore", 20}
                };
            case "Modulo4":
                return new Dictionary<string, int>
                {
                    {"palmeira", 70},
                    {"esmeralda", 20},
                    {"ferro", 40},
                    {"rosita", 10},
                    {"fireore", 10},
                    {"pedra", 20}
                };
            case "Expansao1":
                return new Dictionary<string, int>
                {
                    {"arvore", 120},
                    {"pedra", 120}
                };
            case "Expansao2":
                return new Dictionary<string, int>
                {
                    {"ferro", 40},
                    {"fireore", 40},
                    {"rosita", 40},
                    {"azulita", 40},
                    {"ice", 40},
                    {"esmeralda", 40},
                    {"ouro", 40}
                };
            case "Plantacao":
                return new Dictionary<string, int>
                {
                    {"arvore", 20},
                    {"frozen_wood", 20},
                    {"pedra", 10}
                };
            case "Gera_agua":
                return new Dictionary<string, int>
                {
                    {"ice", 60},
                    {"pedra", 20},
                    {"ferro", 10},
                    {"fireore", 10}
                };
            case "Dormitorio":
                return new Dictionary<string, int>
                {
                    {"perolado", 15},
                    {"palmeira", 15},
                    {"ouro", 20},
                    {"pedra", 20},
                    {"arvore", 20}
                };
            case "Banheiro":
                return new Dictionary<string, int>
                {
                    {"dead_wood", 30},
                    {"cactus", 30},
                    {"grafite", 30},
                    {"ouro", 30}
                };
            case "Cozinha":
                return new Dictionary<string, int>
                {
                    {"perolado", 20},
                    {"ouro", 20},
                    {"grafite", 20},
                    {"azulita", 20}
                };
            default:
                return null;
        }
    }

    public void Construir(string tipo)
    {
        FirstPersonController player = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();

        Dictionary<string, int> recursos = Teste ? new Dictionary<string, int>{{"arvore", 1}} : AtribuirRecurso(tipo);

        foreach (var rec in recursos.Keys)
        {
            if (!player.inventario.TemSuficiente(rec, recursos[rec]))
            {
                Debug.Log("falta material po");
                
                return;
            };
        }

        foreach (var rec in recursos.Keys)
        {
            player.inventario.Remover(rec, recursos[rec]); //remove do inventario a quantidade gasta de recursos
        }

        Efetivar(tipo);
        //Nao_some.Construir(tipo);
    }

    private void Efetivar(string tipo)
    {
        switch (tipo)
        {
            case "Gerador":                
                construcao.SetActive(true);
                construindo.Play();                
                return;
            case "Modulo1":                
                botao1.interactable = true;
                construindo.Play();                
                return;
            case "Modulo2":                
                botao2.interactable = true;
                construindo.Play();
                return;
            case "Modulo3":                
                botao3.interactable = true;
                construindo.Play();
                return;
            case "Modulo4":                
                botao4.interactable = true;
                construindo.Play();
                return;
            case "Expansao1":
                construcao.SetActive(false);
                construindo.Play();
                return;
            case "Expansao2":
                construcao.SetActive(false);
                construindo.Play();
                return;
            case "Plantacao":
                construcao.SetActive(true);
                construindo.Play();

                return;
            case "Gera_agua":
                construcao.SetActive(true);
                construindo.Play();
                return;
            case "Dormitorio":
                construcao.SetActive(true);
                construindo.Play();
                return;
            case "Banheiro":
                construcao.SetActive(true);
                construindo.Play();                
                return;
            case "Cozinha":
                construcao.SetActive(true);
                construindo.Play();
                return;
            default:
                return;
        }
    }
}
