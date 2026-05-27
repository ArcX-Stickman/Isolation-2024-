using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    public Animator animPlayer;
    Vector2 movement;
    public Rigidbody2D rb;
    public AudioSource AudioPlayer;
    public GameObject Flashlight;
    public Light2D Light2D;
    public float PlayerHealth;
    public bool HasBackpack;
    public AudioClip StoneCollect;
    public CraftingPack packActive;
    public AudioClip Error;
    public AudioClip CutTree;
    public bool TreeGOTCut;
    public bool PlayerIsTouchingTree;
    public bool AxeCD;
    public bool EnemyTouched;
    public bool Attacking;
    public bool FistUpgrade;
    public AudioClip Upgrade;
    public GameObject SpawnPoint;
    public bool Died;
    public bool HasTOrespawn;
    public Transform PlayerPOS;
    public bool CanMove;
    public float StartHP;
    public PlayerHealthBar HealthBar;
    public bool StopRespawnFunc;
    public bool StopStop;
    public AudioClip MedkitHeal;
    public AudioClip DeathClip;
    public bool DeathAudioBeenPlayed;
    public float Vision;
    public Camera Cam;
    public float MaxVision;
    public float AxeHp;
    public bool CraftAxe;
    public AudioClip AxeBreak;
    public PlayerFist PlayerFisty;
    



    public float RealSpeed;


    //boss Fight Stuff



    //HyenaFight
    public bool HyenaFightCameraSet;
    public bool HyenaFightCamStop;
    public bool HyenaFightEndedCam;
    public bool ReturnNormalHyena;
    public bool BaitCanBeUsed;
    public bool PlayerHidden;
    public float BaitCount;
    public GameObject HyenaBait;
    public bool BaitPlaced;
    public bool BossCanSet;







    public PillCounter pillC;
    public WoodCounter WoodC;
    public StoneCounter StoneC;
    


    public bool canMove;
    public bool PlayDeathSound;
    public bool StopDeathSound;
    public float MaxSpeed;
    public GameObject DiedUI;
    


    public AudioClip Break;
    public GameObject AxeCollisioner;

    public CraftMenu CraftMenuThing;


    public CraftingPack CraftActive;
    public Tree TreePrefab;

    public bool Axe;
    public bool Cuttable;
    public bool HasMedkit;

    //Recipes For InGameItems

    //Bomb = Gunpowder and Iron
    //Shovel = Iron and Wood
    //Axe = Stone
    // medkit = wood and tablets

    public int Gunpowder;
    public int Iron;
    public int Wood;
    public int Stone;
    public int Tablets;

    //dificulty settings

    public bool EasyMode;
    public bool NormalMode;
    public bool HardMode;
    public bool Dehydrated;







    private void Start()

    {







        BossCanSet = false;

        HyenaFightCamStop = false;
        HyenaFightEndedCam = false;
        ReturnNormalHyena = false;
        HyenaFightCameraSet = false;
        PlayerFisty.PlayerSlowed = false;

        Cam.orthographicSize = MaxVision;

        Vision = MaxVision;



        MaxSpeed = 8;

        speed = MaxSpeed;
       

       if(EasyMode == true)
        {
            StartHP = 39;
        }
       else
            if(NormalMode == true)
        {
            StartHP = 30;
        }
       else
            if(HardMode == true)
        {
            StartHP = 27;
        }
       else
            if(Dehydrated == true)
        {
            StartHP = 25;
        }

       

        PlayerHealth = StartHP;


        AxeCD = false;
        Cuttable = false;
        Axe = false;
        animPlayer = GetComponent<Animator>();
        
        FistUpgrade = false;


        AxeCollisioner.gameObject.SetActive(false);
        Died = false;
        DiedUI.gameObject.SetActive(false);
        RealSpeed = MaxSpeed;

    }


   






    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);





    }


  



   





    private void Move()
    {
        rb.velocity = new Vector2(movement.x, movement.y);



    }


    public void Test()
    {
        Debug.Log("Test");
    }

    public void MedStart()
    {
        HasMedkit = false;
    }



    public void Medkit()
    {
        Debug.Log("med");
        PlayerHealth = PlayerHealth + 10;
        HasMedkit = false;
        
        


    }



    void Update()
    {


        if (Died == true)
        {
            BaitCount = 6;
            HasMedkit = true;
            AxeHp = 0;
        }




        if (HyenaFightCameraSet == true)
        {
            MaxVision = MaxVision + 15;
            HyenaFightCamStop = true;
            BaitCanBeUsed = true;
            BaitCount = 6;
            AxeHp = 0;



            


        }

        if(HyenaFightCamStop == true)
        {
            HyenaFightCameraSet = false;
        }


        if(HyenaFightEndedCam == true)
        {
            MaxVision = MaxVision - 15;
            ReturnNormalHyena = true;
        }



        


       



        if(ReturnNormalHyena == true)
        {
            HyenaFightEndedCam = false;
        }

        if(PlayerFisty.PlayerSlowed == true)
        {
            MaxSpeed = MaxSpeed - 7;
        }

        if (PlayerFisty.PlayerSlowed == false)
        {
            MaxSpeed = RealSpeed;
        }


        Cam.orthographicSize = MaxVision;

        Vision = MaxVision;


        if (AxeCD == false)
        {
            TreeGOTCut = false;

        }


        if(AxeHp <= 0)
        {
            Axe = false;
        }


        

        movement.x = Input.GetAxisRaw("Horizontal");


        movement.y = Input.GetAxisRaw("Vertical");



        if (Input.GetButtonDown("Fire1"))
        {
            if(FistUpgrade == true)
            {
                animPlayer.SetTrigger("Attack2");

            }
            else
            {
                animPlayer.SetTrigger("Attack");

            }









        }

        if(PlayerHealth <= 0)
        {
            Died = true;

        }

        if(PlayerHealth > StartHP)
        {
            PlayerHealth = StartHP;
        }


        if (movement.x == 0)
        {
            animPlayer.SetBool("Moving", false);

        }
        else
        {
            animPlayer.SetBool("Moving", true);

        }


        if(HasTOrespawn == true)
        {
            PlayerPOS.transform.position = SpawnPoint.transform.position;
            Died = false;
            CanMove = true;
            
        }

        if( Died == true)
        {
           
            
            
            HasMedkit = false;
            
            DiedUI.gameObject.SetActive(true);
            
        }

        if(CanMove == true)
        {
            PlayerHealth = StartHP;
            HasTOrespawn = false;
            StopRespawnFunc = true;
        }

        if(StopRespawnFunc == true)
        {
            CanMove = false;
        }

        if(canMove == true)
        {
            speed = MaxSpeed;
            StopDeathSound = false;
        }

        if(CraftAxe == true)
        {
            Axe = true;
        }

        if(Axe == true)
        {
            CraftAxe = false;
        }

        
        










        if (Input.GetKeyDown(KeyCode.E))
        {
            if (HasBackpack == true)
            {
                packActive.UI.gameObject.SetActive(true);
            }
            else
            {
                packActive.UI.gameObject.SetActive(false);

            }
        }


        



        if (Input.GetKeyDown(KeyCode.H))
        {
            if (HasMedkit == true)
            {
                AudioPlayer.PlayOneShot(MedkitHeal);
                animPlayer.SetTrigger("Medkit");
                HasMedkit = false;
                


            }
            else
            {
                AudioPlayer.PlayOneShot(Error);

            }
        }





        























    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Light")
        {
            Light2D.intensity = 1;
            Destroy(Flashlight);

        }

        if (other.tag == "Ground")
        {
            Cuttable = false;
            TreeGOTCut = false;
            PlayerIsTouchingTree = false;

        }

        if (other.tag == "Bag")
        {
            HasBackpack = true;
            CraftActive.CanCraft = true;
        }


        if (other.tag == "Enemy")
        {
           
            animPlayer.SetBool("GotHit", true);
            


        }


       


        if (other.tag == "ATK")
        {
            FistUpgrade = true;
            AudioPlayer.PlayOneShot(Upgrade);



        }



        //if (other.tag != "Enemy")
        {

            //DMGdealer.gameObject.SetActive(false);


        }

        if (other.tag == "Stone")
        {
            AudioPlayer.PlayOneShot(StoneCollect);
            animPlayer.SetTrigger("Attack");


        }




        if (other.tag == "Tree")
        {
            PlayerIsTouchingTree = true;


        }


        if (other.tag == "Hidden")
        {
            PlayerHidden = true;


        }


        if (other.tag != "Hidden")
        {
            PlayerHidden = false;


        }

        if (other.tag == "MusicThing")
        {
            BossCanSet = true;


        }







        if (other.tag != "Tree")
        {
            PlayerIsTouchingTree = false;


        }



        


    }



  
        







           





















        }
