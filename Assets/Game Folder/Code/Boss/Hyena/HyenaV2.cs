using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyenaV2 : MonoBehaviour
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
    public bool PlayerNotVisible;
    public Transform HyenaPos;
    public Transform PlayerPOS;
    public Animator HyenaAnimator;
    public bool HyenaBiteAttack;
    public bool HyenaPlayerCloseAttack;
    public AudioSource AudioPlayer;
    public AudioClip BiteSFX;
    public Transform Spawn;


    // Attack Commands
    public bool IsCloseATK_Next;
    public bool BiteATK_Next;
    public bool PlayerSpotFixer;

    // Modes
    public bool Easy;
    public bool Medium;
    public bool Hard;
    public bool Dehydrated;

    // Start is called before the first frame update
    void Start()
    {
        HyenaHealth = 30;
        HyenaAnimator = GetComponent<Animator>();
        

        // Difficulty Settings
        if (Easy)
        {
            Damage = 3;
        }
        else if (Medium)
        {
            Damage = 4;
        }
        else if (Hard)
        {
            Damage = 5;
        }
        else if (Dehydrated)
        {
            Damage = 9;
        }
    }

    void Update()
    {
        if(PlayerVisible == true)
        {

        }
        
    }


    void PlayerSpotted()
    {

    }





}
