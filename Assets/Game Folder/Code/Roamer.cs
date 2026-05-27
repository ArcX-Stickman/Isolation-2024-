using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Roamer : MonoBehaviour
{
    public Player playerHealth;
    public float enemySpeed;
    public Collider2D sight;
    public float roamerHP;
    public Rigidbody2D roamRb;
    public Transform playerPosition;
    public bool inSight;
    public float startingHealth;
    public bool roamerCanAttackPlayer;
    public Animator roamerAnimation;
    public Player jamalAnimation;
    public AudioSource soundSourceRoamer;
    public AudioClip hitPlayer;
    public float attackCooldown = 1;
    public float nextAttack = 0f;
    public bool PlayerHanHit;
    public float Damage;
    public bool visionCH1=false;
    public AudioClip Damaged;
    public AudioSource AudioPlayer;
    


    // Start is called before the first frame update
    void Start()
    {
        roamerHP = startingHealth;
        visionCH1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleAttack();
        if (roamerHP <= 0)
        {
            playerHealth.Stone = playerHealth.Stone + 2;
            StoneCounter.instance.AddStone(2);

            visionCH1 = true;
            Destroy(gameObject);
        }
    }

    void HandleMovement()
    {
        if (inSight)
        {
            Vector3 direction = (playerPosition.position - transform.position).normalized;
            transform.position += direction * enemySpeed * Time.deltaTime;
        }
        else
        {
            roamerHP = startingHealth;
        }
    }

    void HandleAttack()
    {
        if (roamerCanAttackPlayer && Time.time >= nextAttack)
        {
            playerHealth.PlayerHealth -= Damage;
            roamerAnimation.SetTrigger("Attack");
            jamalAnimation.animPlayer.SetBool("GotHit", true);
            soundSourceRoamer.PlayOneShot(hitPlayer);
            nextAttack = Time.time + attackCooldown;
        }
        else
        {
            playerHealth.PlayerHealth = playerHealth.PlayerHealth + 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerATK"))
        {
            AudioPlayer.PlayOneShot(Damaged);
        }
    }




    private void FixedUpdate()
    {
    }
}