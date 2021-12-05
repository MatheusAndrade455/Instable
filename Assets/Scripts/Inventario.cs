using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario
{
    public static Dictionary<string, int> inventario = new Dictionary<string, int>();

    public void Adicionar(string nome, int quantidade)
    {
        if (inventario.ContainsKey(nome))
        {
            inventario[nome] += quantidade;
        }
        else
        {
            inventario.Add(nome, quantidade);
        }
    }

    public void Remover(string nome, int quantidade)
    {
        if (inventario.ContainsKey(nome))
        {
            if (inventario[nome] >= quantidade)
            {
                inventario[nome] -= quantidade;
            }

            if (inventario[nome] == 0)
            {
                inventario.Remove(nome);
            }
        }
    }

    public int GetQuantidade(string nome){
        return inventario.ContainsKey(nome) ? inventario[nome] : 0;
    }

    public bool TemSuficiente(string nome, int qtd){
        return inventario[nome]>=qtd;
    }
}