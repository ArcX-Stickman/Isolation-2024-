using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyenaAttackScript : MonoBehaviour
{
    public Hyena HyenaBoss;

    




    // Start is called before the first frame update
    void Start()
    {
        HyenaBoss.HyenaBiteAttack = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == ("Player"))
        {
            HyenaBoss.HyenaBiteAttack = true;
            //HyenaBoss.Speed = HyenaBoss.Speed + 5;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != ("Player"))
        {
            HyenaBoss.HyenaBiteAttack = false;
            //HyenaBoss.Speed = HyenaBoss.Speed - 5;
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
