using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronAxeTrue : MonoBehaviour
{
    public CraftMenu CM;
    public Player P;
    public bool StoneAxeBeenMade;
    public CraftingPack CP;
    public GameObject IronAxe;



    // Start is called before the first frame update
    void Start()
    {
        StoneAxeBeenMade = false;
        IronAxe.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (StoneAxeBeenMade)
        {
            CP.UI.gameObject.SetActive(true);
            IronAxe.gameObject.SetActive(true);


        }
    }
}
