using UnityEngine;

public class Arma : MonoBehaviour
{
    public float dano = 10.0f;
    public float range = 30.0f;
    public Camera fpsCam;
    public ParticleSystem tiro;

    public static float vida = 100.0f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        tiro.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Mob mob = hit.transform.GetComponent<Mob>();
            if (mob != null)
            {
                mob.LevaDano(dano);
            }
        }
    }
}
