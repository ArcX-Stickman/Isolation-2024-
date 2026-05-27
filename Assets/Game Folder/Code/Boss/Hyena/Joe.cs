using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joe : MonoBehaviour
{

    public Player Jamal;
    public bool HasEnoughStone;
    public Animator JoeAnim;
    public Transform JamalPOS;
    
    public float Speed;
    public bool Subtract;
    public bool StopSubtracting;



    // Start is called before the first frame update
    void Start()
    {
        JoeAnim = GetComponent<Animator>();
        HasEnoughStone = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jamal.Stone >= 20)
        {
            HasEnoughStone = true;

        }

        if(HasEnoughStone == true)
        {
            Subtract = true;
            
        }

        if(Subtract == true)
        {
            Jamal.Stone = Jamal.Stone - 20;
            StopSubtracting = true;
        }

        if(StopSubtracting == true)
        {
            Subtract = false;
            FollowPlayer();
        }
        
    }

    


    void FollowPlayer()
    {
        Vector3 direction = (JamalPOS.position - transform.position).normalized;
        transform.position += direction * Speed * Time.deltaTime;


    }


    
}
