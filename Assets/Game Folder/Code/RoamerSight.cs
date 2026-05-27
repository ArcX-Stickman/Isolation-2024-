using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class RoamerSight : MonoBehaviour
{

    public Roamer RoamComponent;
    public Player player;
   


    // Start is called before the first frame update
    void Start()
    {
        RoamComponent.inSight = false;



    }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RoamComponent.inSight = true;

        }
    }

    void Update()
    {
        if(player.Died == true)
        {
            RoamComponent.inSight = false;

        }
    }


}
