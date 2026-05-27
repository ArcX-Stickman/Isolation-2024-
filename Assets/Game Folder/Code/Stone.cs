using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    public Player ItemCollection;
    


    // Start is called before the first frame update
    void Start()
    {
        ItemCollection.Stone = 0;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           if(ItemCollection.HasBackpack == true)
            {
                ItemCollection.Stone = ItemCollection.Stone + 1;
                StoneCounter.instance.AddStone(1);
                Destroy(gameObject);
            }
            else
            {
                ItemCollection.Stone = ItemCollection.Stone + 0;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
