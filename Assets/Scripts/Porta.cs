using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{

    Animator _doorAnim;

    void Start()
    {
        //declaracao de valor
        _doorAnim = this.transform.parent.GetComponent<Animator>();   
    }

    void Update()
    {
        
    }


    //se o jogador estiver encostando no objeto, a porta vai ser aberta
    public void OnTriggerEnter(Collider other)
    {
        _doorAnim.SetBool("character_nearby", true);
    }


    //se o jogador parar de encostar no objeto, a porta vai ser fechada
    public void OnTriggerExit(Collider other)
    {
        _doorAnim.SetBool("character_nearby", false);
    }
}

