using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Nao_some : MonoBehaviour
{
    public GameObject gerador;
    public GameObject dormitorio;
    public GameObject banheiro;
    public GameObject agua;
    public GameObject cozinha;
    public GameObject terra;
    public GameObject abre01;
    public GameObject abre02;

    public Button botao1;
    public Button botao2;
    public Button botao3;
    public Button botao4;
    public Button botaogerador;
    public Button dormitorio;
    public Button banheiro;
    public Button agua;
    public Button cozinha;
    public Button terra;
    public Button abre01;
    public Button abre02;

    private Dictionary<string, GameObject> objetos;
    private Dictionary<string, GameObject> botoes;

    private static Dictionary<string, bool> construidos = new Dictionary<string, bool>{
        {"Gerador", false},
        {"Expansao1", true},
        {"Expansao2", true},
        {"Plantacao", false},
        {"Gera_agua", false},
        {"Dormitorio", false},
        {"Banheiro", false},
        {"Cozinha", false}
    };

    public static void Construir(string nome)
    {
        construidos[nome] = !construidos[nome];
    }

    void Awake()
    {
        objetos = new Dictionary<string, GameObject>{
            {"Gerador", gerador},
            {"Expansao1", abre01},
            {"Expansao2", abre02},
            {"Plantacao", terra},
            {"Gera_agua", agua},
            {"Dormitorio", dormitorio},
            {"Banheiro", banheiro},
            {"Cozinha", cozinha}
        };

        botoes = new Dictionary<string, GameObject>{
            {"Gerador", gerador},
            {"Expansao1", abre01},
            {"Expansao2", abre02},
            {"Plantacao", terra},
            {"Gera_agua", agua},
            {"Dormitorio", dormitorio},
            {"Banheiro", banheiro},
            {"Cozinha", cozinha}
        };

        foreach (var k in construidos.Keys)
        {
            if (construidos[k])
            {
                objetos[k].SetActive(true);
            }
        }
    }
}
    */