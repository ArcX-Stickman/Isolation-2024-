using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHealthPopUpExtra : MonoBehaviour
{


    public GameObject PopupHP;
    public AudioClip Upgrade;


    

   

   

    public void ClosePopUp()
    {
        PopupHP.gameObject.SetActive(false);
    }
}
