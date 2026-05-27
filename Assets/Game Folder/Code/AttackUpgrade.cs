using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackUpgrade : MonoBehaviour
{

    public Player player;
    public bool MeleePopup;
    public GameObject Popup;
    // Start is called before the first frame update
    void Start()
    {
        player.FistUpgrade = false;
        Popup.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (player.FistUpgrade == true)
        {
            MeleePopup = true;
            Popup.gameObject.SetActive(true);

        }

    }

    
    public void ClosePopupMelee()
    {
        Destroy(Popup);
        
    }




    }

