using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hyena : MonoBehaviour
{
    public GameObject HyenaGameobject;
    public Player Jamal;
    public float Damage;
    public float HyenaHealth;
    public float Speed;
    public float AttackCD;
    public bool PlayerAttacked;
    public bool CanAttack;
    public bool PlayerVisible;
    public Transform HyenaPos;
    public Transform PlayerPOS;
    public Animator HyenaAnimator;
    public bool HyenaBiteAttack;
    public bool HyenaPlayerCloseAttack;
    public AudioSource AudioPlayer;
    public AudioClip BiteSFX;
    public Transform Spawn;
    public bool Hittable;
    public PlayerFist FistFromPlayer;
    public AudioClip PlayerDMG;
    public float nextAttack = 0f;

    // Attack Commands
    public bool IsCloseATK_Next;
    public bool BiteATK_Next;

    // Modes
    public bool Easy;
    public bool Medium;
    public bool Hard;
    public bool Dehydrated;

    // Start is called before the first frame update
    void Start()
    {
        HyenaHealth = 20;
        HyenaAnimator = GetComponent<Animator>();

        // Difficulty Settings
        if (Easy)
        {
            Damage = 2f;
        }
        else if (Medium)
        {
            Damage = 3f;
        }
        else if (Hard)
        {
            Damage = 3.5f;
        }
        else if (Dehydrated)
        {
            Damage = 3.7f;
        }

        HyenaGameobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Jamal.HyenaFightCameraSet)
        {
            HyenaGameobject.SetActive(true);
        }

        if (HyenaHealth <= 0)
        {
            HyenaAnimator.SetTrigger("Died");
            Speed = 0;
            Debug.Log("Hyena died. Speed set to 0.");
            return;
        }

        if (Jamal.Died)
        {
            ResetHyena();
            Debug.Log("Hyena reset after player died.");
        }

        if (HyenaBiteAttack)
        {
            HyenaAnimator.SetTrigger("Attack");
        }

        if (Jamal.PlayerHidden)
        {
            PlayerSpotted();
        }
        else
        {
            PlayerGone();
        }

        // Additional Debugging
        Debug.Log("Hyena Health: " + HyenaHealth);
        Debug.Log("PlayerHidden: " + Jamal.PlayerHidden);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with: " + collision.tag);

        if (collision.CompareTag("Player"))
        {
            if(HyenaHealth > 0)
            {
                HyenaAnimator.SetTrigger("PlayerTooClose");
                IsCloseATK_Next = true;
                PlayerVisible = true;
            }
            
        }

        if (collision.CompareTag("PlayerATK"))
        {
            if(HyenaHealth > 0)
            {
                HyenaHealth -= FistFromPlayer.DMG;
                AudioPlayer.PlayOneShot(PlayerDMG);
                Debug.Log("Hyena hit by player. Current Health: " + HyenaHealth);
            } 
            
        }

        if (collision.CompareTag("Trap"))
        {
            HyenaHealth -= 2;
            AudioPlayer.PlayOneShot(PlayerDMG);
            Debug.Log("Hyena hit by trap. Current Health: " + HyenaHealth);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerVisible = true;
        }
    }

    void PlayerSpotted()
    {
        if (PlayerVisible && HyenaHealth > 0)
        {
            Speed = 6;
            Vector3 direction = (PlayerPOS.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
            HyenaAnimator.SetBool("Moving", true);
            HyenaAnimator.SetBool("NoPlayer", false);
        }

        if (Jamal.PlayerHidden)
        {
            PlayerGone();
        }
    }

    void PlayerGone()
    {
        if (!PlayerVisible && HyenaHealth > 0)
        {
            HyenaAnimator.SetBool("NoPlayer", true);
            HyenaAnimator.SetBool("Moving", false);
            Speed = 0;
        }

        if (!Jamal.PlayerHidden && HyenaHealth > 0)
        {
            PlayerSpotted();
        }
    }

    void BiteAttack()
    {
        if (HyenaHealth > 0 && Time.time >= nextAttack)
        {
            BiteATK_Next = true;
            Jamal.PlayerHealth -= Damage;
            AudioPlayer.PlayOneShot(BiteSFX);
            Jamal.animPlayer.SetTrigger("GotHit");
            HyenaAnimator.SetBool("Moving", false);
            IsCloseATK_Next = false;
            nextAttack = Time.time + AttackCD;
        }
    }

    void AttackDoneBite()
    {
        HyenaBiteAttack = false;
    }

    void CanHite()
    {
        Hittable = true;
    }

    void CantHit()
    {
        Hittable = false;
    }

    void Dead()
    {
        Destroy(gameObject);
    }

    void TooClose()
    {
        if (HyenaHealth > 0 && IsCloseATK_Next && Time.time >= nextAttack)
        {
            if (Jamal.PlayerHealth > 0)
            {
                Jamal.PlayerHealth -= Damage;
                AudioPlayer.PlayOneShot(BiteSFX);
                Jamal.animPlayer.SetTrigger("GotHit");
                HyenaAnimator.SetBool("Moving", false);
                nextAttack = Time.time + AttackCD;
            }
        }
        if (BiteATK_Next)
        {
            BiteAttack();
        }
    }

    void ResetHyena()
    {
        HyenaPos.position = Spawn.position;
        HyenaHealth = 20;
    }


    void LoadEND()
    {
        SceneManager.LoadScene("TheEnd");
    }
}