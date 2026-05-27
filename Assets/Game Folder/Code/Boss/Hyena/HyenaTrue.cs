using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyenaTrue : MonoBehaviour
{

    public Player Jamal;
    public Transform NewCheckpoint;
    public Transform OldCheckPoint;
    public GameObject HyEna;
    public GameObject AudioPlayer;
    



    // Start is called before the first frame update
    void Start()
    {
        Jamal.HyenaFightCameraSet = false;
        AudioPlayer.gameObject.SetActive(false);


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == ("Player"))
        {
            if(Jamal.BossCanSet == true)
            {
                Jamal.HasMedkit = true;

                Jamal.HyenaFightCameraSet = true;
                OldCheckPoint.position = NewCheckpoint.position;
                HyEna.gameObject.SetActive(true);
                AudioPlayer.gameObject.SetActive(true);

                
                Destroy(gameObject);
            }


            

        }
    }
}
