using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionUpgrade : MonoBehaviour
{

    public Player playerMax;
    public GameObject PopupVision;
    public AudioClip Upgrade;
    
    

    // Start is called before the first frame update
    void Start()
    {
        PopupVision.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerMax.MaxVision = playerMax.MaxVision + 2;
            PopupVision.gameObject.SetActive(true);
            playerMax.AudioPlayer.PlayOneShot(Upgrade);
            Destroy(gameObject);
            



        }
    }


    public void ClosePopUp()
    {
        PopupVision.gameObject.SetActive(false);
    }
}
