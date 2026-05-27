using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomerCanAttack : MonoBehaviour
{
    public Roamer RoamerAttack;
    public Player P122;



    // Start is called before the first frame update
    void Start()
    {
        RoamerAttack.roamerCanAttackPlayer = false;

    }



    private void Update()
    {
        if(P122.PlayerHealth <= 0)
        {
            RoamerAttack.roamerCanAttackPlayer = false;

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RoamerAttack.roamerCanAttackPlayer = true;
            P122.EnemyTouched = true;
;
        }



    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            RoamerAttack.roamerCanAttackPlayer = false;
        }
    }

}
