using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : MonoBehaviour
{

    public Player ItemCollection;
    public AudioClip PillCollect;
    public AudioSource AOS;

    


    // Start is called before the first frame update
    void Start()
    {
        ItemCollection.Tablets = 0;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           if(ItemCollection.HasBackpack == true)
            {
                ItemCollection.Tablets = ItemCollection.Tablets + 1;
                PillCounter.instance.AddStone(1);
                AOS.PlayOneShot(PillCollect);
                Destroy(gameObject);
            }
            else
            {
                ItemCollection.Tablets = ItemCollection.Tablets + 0;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
