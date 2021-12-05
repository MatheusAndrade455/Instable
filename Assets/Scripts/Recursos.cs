using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recursos : MonoBehaviour
{
    public void AtualizarInventario()
    {
        GameObject Jogador = GameObject.FindWithTag("Player");
        var player = Jogador.GetComponent<FirstPersonController>();

        Dictionary<string, string> campos = new Dictionary<string, string>();

        //primeiro campo é a tag, o segundo campo é o texto
        campos.Add("arvore", "Madeira");
        campos.Add("pedra", "Pedra");
        campos.Add("azulita", "Azulita");
        campos.Add("ouro", "Ouro");
        campos.Add("rosita", "Rosita");
        campos.Add("fireore", "Minério de fogo");
        campos.Add("ferro", "Ferro");
        campos.Add("palmeira", "Palmeira");
        campos.Add("cactus", "Cactus");
        campos.Add("esmeralda", "Esmeralda");
        campos.Add("grafite", "Grafite");
        campos.Add("dead_wood", "Madeira morta");
        campos.Add("perolado", "Perolado");
        campos.Add("frozen_wood", "Madeira Congelada");
        campos.Add("ice", "Gelo");

        foreach(var item in campos.Keys){
            Text campo = GameObject.Find(item).GetComponent<Text>();

            campo.text = $"{campos[item]}: {player.inventario.GetQuantidade(item)}";
        }
    }
}