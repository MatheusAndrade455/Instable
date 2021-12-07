using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    public float dano = 10.0f;
    public float range = 30.0f;
    public Camera fpsCam;
    public ParticleSystem tiro;

    public static float vida = 100.0f;

    public static Image healthBarImage;

    public static void TakeDamage(float damage){
        vida -= damage;
        Debug.Log(vida);
        UpdateHealthBar();
    }

    public static void UpdateHealthBar() {
        healthBarImage.fillAmount = Mathf.Clamp(vida / 100.0f, 0, 1f);
    }

    void Start(){
        healthBarImage = GameObject.Find("HealthBarInner").GetComponent<Image>();
    }

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
