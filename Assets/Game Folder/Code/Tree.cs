using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tree : MonoBehaviour
{
    public Player player; // Reference to the Player script
    public bool TreeGotCut; // Not used in the provided script
    public AudioClip CutSFX;

    // Start is called before the first frame update
    void Start()
    {
        player.Wood = 0; // Initialize player's wood count
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Axe")
        {
            WoodCounter.instance.AddWood(1);

            player.animPlayer.SetTrigger("Attack");
            player.Wood = player.Wood + 1; // Increase player's wood count
            player.AudioPlayer.PlayOneShot(CutSFX);
            player.AxeHp = player.AxeHp - 1;

            Destroy(gameObject); // Destroy the tree object

        }
        else
        {
            player.Wood = player.Wood + 0;
        }
    }
}
    // Update is called once per frame
   