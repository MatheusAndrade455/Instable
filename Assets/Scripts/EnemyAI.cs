using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //private Transform player;
    //public float dano;

    //Atacar
    //public float timeBetweenAttacks;
    //bool alreadyAttacked;


    //[Range(0.1f, 10.0f)] public float distancia = 3.5f;

    //private void Awake()
    //{
    //    player = GameObject.FindWithTag("Player").transform;
    //}

    // Start is called before the first frame update


    // Update is called once per frame
    /*void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < distancia)
            Atacar();
    }

    void Atacar()
    {
        if (!alreadyAttacked)
        {
            Arma.vida -= dano;
            Debug.Log(Arma.vida);
            alreadyAttacked = true;
            Invoke("ResetAttack", timeBetweenAttacks);
        }
    }

    void ResetAttack()
    {
        alreadyAttacked = false;
    }
    */
}
