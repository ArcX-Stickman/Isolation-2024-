using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAnimation : MonoBehaviour
{
    public AxeCollider Func;
    public GameObject Axe;
    public bool CD;
    public Player PlayerFUNC;


    // Start is called before the first frame update
    void Start()
    {
        Func.PlayerHasAxe = false;
        Axe.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Func.PlayerHasAxe == true)
        {
            Axe.gameObject.SetActive(true);
        }
        else
        {
            Axe.gameObject.SetActive(true);

        }



        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Func.PlayerHasAxe == true)
            {
                Axe.gameObject.SetActive(true);

                if(PlayerFUNC.PlayerIsTouchingTree == false)
                {
                    Axe.gameObject.SetActive(false);

                }
            }
            else
            {
                Axe.gameObject.SetActive(false);

            }
        }
    }
}
