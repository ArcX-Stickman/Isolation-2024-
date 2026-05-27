using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingPack : MonoBehaviour
{

    public bool CanCraft;
    public GameObject UI;
    public bool IsHidden;
    public SpriteRenderer Bag;


    // Start is called before the first frame update
    void Start()
    {
        CanCraft = false;
        IsHidden = true;

        if(CanCraft == false)
        {
            UI.gameObject.SetActive(false);
        }
        else
        {
            if (CanCraft == true)
            {
                UI.gameObject.SetActive(true);
                Bag.sortingOrder = -14434;

            }
        }



        if(IsHidden == true)
        {
            UI.gameObject.SetActive(false);
        }
        else
        {
            if (IsHidden == false)
            {
                UI.gameObject.SetActive(true);
            }
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
