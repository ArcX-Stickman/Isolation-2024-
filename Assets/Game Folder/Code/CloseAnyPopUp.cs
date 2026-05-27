using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CloseAnyPopUp : MonoBehaviour
{
    public GameObject CloseObject;


    public void ClosePopUp()
    {
        CloseObject.gameObject.SetActive(false);
    }
}
