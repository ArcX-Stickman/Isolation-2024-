using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DiedScript : MonoBehaviour
{
    public Player playermanag;
    public GameObject UIhide;


    // Start is called before the first frame update
    void Start()
    {
        UIhide.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void RespawnButton()
    {
        playermanag.DeathAudioBeenPlayed = false;
        playermanag.HasTOrespawn = true;
        UIhide.gameObject.SetActive(false);
        

        
    }
}
