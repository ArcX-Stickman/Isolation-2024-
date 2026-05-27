using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KillTheGang : MonoBehaviour
{
    public Player playerP;
    public GameObject BigBoy;
    public GameObject UIpopup;
    public AudioClip SignHint;


    // Start is called before the first frame update
    void Start()
    {
        UIpopup.gameObject.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UIpopup.gameObject.SetActive(true);

            

            playerP.AudioPlayer.PlayOneShot(SignHint);
        }

    }



    public void ClosePopUpLTBOS()
    {
        UIpopup.gameObject.SetActive(false);

    }
}
