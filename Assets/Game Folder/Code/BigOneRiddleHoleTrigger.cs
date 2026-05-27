using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigOneRiddleHoleTrigger : MonoBehaviour
{
    public GameObject HealthUpgrade;
    public bool IsDefeated;
    public GameObject Enemy;
    public Player AudioPlayPlayer;
    public AudioClip Reward;


    // Start is called before the first frame update
    void Start()
    {
        IsDefeated = false;
        HealthUpgrade.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hole")
        {
            AudioPlayPlayer.AudioPlayer.PlayOneShot(Reward);
            HealthUpgrade.gameObject.SetActive(true);
            Destroy(Enemy);
            
        }
    }
}
