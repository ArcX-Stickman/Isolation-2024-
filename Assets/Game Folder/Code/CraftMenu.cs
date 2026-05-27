using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftMenu : MonoBehaviour
{

    public Player PlayerItems;
    public GameObject MenuPrefab;
    public CraftingPack CraftHide;
    public AudioClip Error;
    public AudioClip Crafting;
    public GameObject DestroyStoneAxe;
    public GameObject ActiveIronAxe;
    public IronAxeTrue IronAxeCommand;
    

    public void HideCraft()
    {
        MenuPrefab.gameObject.SetActive(false);
    }

    public void CraftAxe()
    {
        if(PlayerItems.Stone >= 6)
        {
            PlayerItems.AudioPlayer.PlayOneShot(Crafting);
            PlayerItems.CraftAxe = true;
            PlayerItems.Stone = PlayerItems.Stone - 6;
            StoneCounter.instance.AddStone(-6);
            PlayerItems.AxeHp = 7;
            


        }
        else
        {
            PlayerItems.AudioPlayer.PlayOneShot(Error);
            
        }
    }


    public void Medkit()
    {
        if (PlayerItems.Tablets >= 2 && PlayerItems.Wood >= 4 )
        {
            PlayerItems.AudioPlayer.PlayOneShot(Crafting);
            PlayerItems.HasMedkit = true;
            PlayerItems.Tablets = PlayerItems.Tablets - 2;
            PlayerItems.Wood = PlayerItems.Wood - 2;

            PillCounter.instance.AddStone(-2);
            WoodCounter.instance.AddWood(-2);



        }
        else
        {
            PlayerItems.AudioPlayer.PlayOneShot(Error);
        }
    }
}
