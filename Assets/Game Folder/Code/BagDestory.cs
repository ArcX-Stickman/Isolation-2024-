using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BagDestory : MonoBehaviour
{
    public GameObject Bag;
    public Player ActivePackPlayer;
    public CraftingPack ActivePack2;
    public SpriteRenderer BagHide;
    public Light2D Light2D;



    // Start is called before the first frame update
    void Start()
    {
        Bag.gameObject.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ActivePackPlayer.HasBackpack = true;
            ActivePack2.CanCraft = true;

            Light2D.intensity = 0;

            

            BagHide.sortingOrder = -33;
            

        }
    }
}
