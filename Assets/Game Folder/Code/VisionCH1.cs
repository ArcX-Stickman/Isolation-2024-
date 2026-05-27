using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCH1 : MonoBehaviour
{
    public VisionUpgrade VU;

    public float EnemyCount;

    public AudioClip Reward;


    public Player PlayerThing;

    public GameObject Vision;






    // Start is called before the first frame update
    void Start()
    {
        Vision.gameObject.SetActive(false);
        EnemyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyCount == 6)
        {
            //PlayerThing.AudioPlayer.PlayOneShot(Reward);
            Vision.gameObject.SetActive(true);
            

        }
    }
}
