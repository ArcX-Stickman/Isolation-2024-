using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCutTree : MonoBehaviour

    
{

    public Player player;
    public bool Cutting;
    public GameObject AxeCollider;


    // Start is called before the first frame update
    void Start()
    {

        Cutting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Cutting == true)
        {
            AxeCollider.gameObject.SetActive(true);
        }
        else
        {
            AxeCollider.gameObject.SetActive(false);
        }

        if(player.PlayerIsTouchingTree == false)
        {
            AxeCollider.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            AxeCollider.gameObject.SetActive(true);

        }



    }
}
