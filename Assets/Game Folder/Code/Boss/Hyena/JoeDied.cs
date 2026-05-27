using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeDied : MonoBehaviour
{

    public bool Music;
    public Player Jamal;
    public GameObject MusicAudio;



    // Start is called before the first frame update
    void Start()
    {
        Music = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Music == true)
        {
            MusicAudio.gameObject.SetActive(true);

        }
        else
        {
            MusicAudio.gameObject.SetActive(false);
        }

        if(Jamal.HyenaFightCameraSet == true)
        {
            Music = false;
        }
        
    }
}
