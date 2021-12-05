using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Construcao : MonoBehaviour
{
    public GameObject construcao;

    private Dictionary<string, int> AtribuirRecurso(string tipo){
        switch(tipo){
            case "Gerador":
                return new Dictionary<string, int>{
                    {"arvore", 15},
                    {"pedra", 45}
                };
            case "Modulo1":
                return new Dictionary<string, int>{
                };
            case "Modulo2":
                return new Dictionary<string, int>{
                };
            case "Modulo3":
                return new Dictionary<string, int>{
                };
            case "Modulo4":
                return new Dictionary<string, int>{
                };
            case "Expansao1":
                return new Dictionary<string, int>{
                };
            case "Expansao2":
                return new Dictionary<string, int>{
                };
            case "Plantacao":
                return new Dictionary<string, int>{
                };
            case "Gera_agua":
                return new Dictionary<string, int>{
                };
            case "Dormitorio":
                return new Dictionary<string, int>{
                };
            case "Banheiro":
                return new Dictionary<string, int>{
                };
            case "Cozinha":
                return new Dictionary<string, int>{
                };
            default:
                return null;
        }
    }

    public void Construir(string tipo)
    {
        FirstPersonController player = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();

        Dictionary<string, int> recursos = AtribuirRecurso(tipo);

        foreach (var rec in recursos.Keys)
        {
            if (!player.inventario.TemSuficiente(rec, recursos[rec]))
            {
                //escreve na tela que não tem recursos suficientes
                return;
            };
        }
        
        foreach (var rec in recursos.Keys)
        {
            player.inventario.Remover(rec, recursos[rec]); //remove do inventario a quantidade gasta de recursos
        }

        Efetivar(tipo);
    }

    private void Efetivar(string tipo){
        switch(tipo){
            case "Gerador":
                construcao.SetActive(true);
                return;
            case "Modulo1":
                return;
            case "Modulo2":
                return;
            case "Modulo3":
                return;
            case "Modulo4":
                return;
            case "Expansao1":
                return;
            case "Expansao2":
                return;
            case "Plantacao":
                return;
            case "Gera_agua":
                return;
            case "Dormitorio":
                return;
            case "Banheiro":
                return;
            case "Cozinha":
                return;
            default:
                return;
        }
    }
}
