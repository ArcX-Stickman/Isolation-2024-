using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFist : MonoBehaviour
{
    public float DMG;
    public Collider2D Fist;
    public GameObject PrefabFist;
    public AudioClip DMGsfx;
    public AudioSource SourceOfAudio;
    public bool PlayerSlowed;
    public Player Jamal;

    void Start()
    {
        Fist = GetComponent<Collider2D>();
        Fist.enabled = false;
        Fist.isTrigger = true;
        PrefabFist.gameObject.SetActive(false);
    }

    public void Punch()
    {
        PrefabFist.gameObject.SetActive(true);
        Fist.enabled = true;
        Jamal.PlayerHidden = false;

        if(PlayerSlowed == true)
        {
            PlayerSlowed = false;
        }


        
    }

    public void StopAttack()
    {
        Fist.enabled = false;
        PrefabFist.gameObject.SetActive(false);
    }

    void OnDrawGizmos()
    {
        if (Fist != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(Fist.bounds.center, Fist.bounds.size);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Roamer roamer = collision.GetComponent<Roamer>();

            Hyena hyena = collision.GetComponent<Hyena>();

            if (Fist.enabled == true)
            {
                roamer.roamerHP -= DMG;


                if(hyena.HyenaHealth >= 0)
                {
                    hyena.HyenaHealth -= DMG;

                }

                Debug.Log("Hit");


                // Play damage sound effect
                SourceOfAudio.PlayOneShot(DMGsfx);

                // Disable the fist collider to prevent continuous damage
                Fist.enabled = false;
                PrefabFist.gameObject.SetActive(false);


             




            }
            else
            {
                Fist.enabled = false;
            }
        }
    }

    void Update()
    {
        // Update logic, if needed
    }
}