using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollider : MonoBehaviour
{
    public Player player;
    public bool PlayerHasAxe;
    public GameObject AxeC;
    public AudioClip AxeBreak;

    private bool axeBreakSoundPlayed;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHasAxe = false;
        AxeC.gameObject.SetActive(false);
        axeBreakSoundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.Axe == true)
        {
            if (player.AxeHp > 0)
            {
                PlayerHasAxe = true;
                axeBreakSoundPlayed = false; // Reset the flag if the axe is usable
            }
        }
        else
        {
            if (player.AxeHp <= 0 && !axeBreakSoundPlayed)
            {
                player.AudioPlayer.PlayOneShot(AxeBreak);
                axeBreakSoundPlayed = true; // Ensure the sound is only played once
                PlayerHasAxe = false;
                AxeC.gameObject.SetActive(false);
            }
        }

        if (PlayerHasAxe)
        {
            AxeC.gameObject.SetActive(true);
        }
    }
}