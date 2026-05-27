using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyenaVision : MonoBehaviour
{
    public Hyena HyenaBoss;
    public HyenaV2 Hyena;
    public Player Jamal;





    // Start is called before the first frame update
    void Start()
    {
        HyenaBoss.PlayerVisible = false;
        


    }

    // Update is called once per frame
    void Update()
    {


        if(Jamal.PlayerHidden == true)
        {
            HyenaBoss.PlayerVisible = false;
        }



        if (Jamal.PlayerHidden == false)
        {
            HyenaBoss.PlayerVisible = true;
        }




    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            HyenaBoss.PlayerVisible = true;

            if (Jamal.PlayerHidden == true)
            {
                HyenaBoss.PlayerVisible = true;
                HyenaBoss.Speed = 6;

                Debug.Log("Working");
            }




        }



    }



    void LookForPlayer()
    {

    }





}
