using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob : MonoBehaviour
{
    public float vida = 50f;
    private GameObject Player;


    private Transform player;
    public float dano;
    //Atacar
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    [Range(0.1f, 10.0f)] public float distancia = 3.5f;

    private Animator anim;

    public void LevaDano(float quant)
    {
        vida -= quant;
        if (vida <= 0f)
        {
            Morre();
        }
    }

    void Morre()
    {
        GameObject.Find("SpawnManager").GetComponent<SpawnManager>().Matar();
        Destroy(gameObject);
    }

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        GetComponent<NavMeshAgent>().destination = Player.transform.position;
        anim.SetBool("andando", true);

        if (Vector3.Distance(transform.position, Player.transform.position) < distancia)
            Atacar();
    }

    void Atacar()
    {
        if (!alreadyAttacked)
        {
            Arma.TakeDamage(dano);
            alreadyAttacked = true;
            Invoke("ResetAttack", timeBetweenAttacks);
        }
    }

    void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
