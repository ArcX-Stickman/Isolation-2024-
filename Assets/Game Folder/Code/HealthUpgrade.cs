using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrade : MonoBehaviour
{

    public Player playerMax;
    public GameObject PopupHP;
    public AudioClip Upgrade;

    // Start is called before the first frame update
    void Start()
    {
        PopupHP.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerMax.StartHP = playerMax.StartHP + 4;
            playerMax.AudioPlayer.PlayOneShot(Upgrade);
            PopupHP.gameObject.SetActive(true);
            Destroy(gameObject);



        }
    }


    public void ClosePopUp()
    {
        PopupHP.gameObject.SetActive(false);
    }
}
