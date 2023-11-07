using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
//     ENEMY MOVEMENT/FOLLOW PLAYER
//     private GameObject playerObj;
//     private Rigidbody rb;
//     private float speed = 30f;

//     void Awake(){
//         rb = GetComponent<Rigidbody>();
        
//     }
//     // Start is called before the first frame update
//     void Start()
//     {  
//         playerObj = GameObject.Find("Player");
//     }

//     // Update is called once per frame
//     void Update(){
//         if(transform.position.y < -15){
//             Destroy(gameObject);
//         }       
//     }
//     void FixedUpdate()
//     {
//         Vector3 moveTowards = (playerObj.transform.position - transform.position).normalized;
//         moveTowards.y = 0;
//         rb.AddForce(moveTowards * speed);
//     }




/////////////////////////////////////////////////////////////////////////////////////////////////////////

//     ENEMY MOVEMENT/FOLLOW PLAYER, ENEMY BOOST (AS IN VIDEO USING RB.ADDFORCE STATEMENT)
//     private GameObject playerObj;
//     private Rigidbody rb;
//     private float speed = 30f;
       // to check if the object is ready to attack AGAIN!
//     private bool isRecharged;
//     // One way to comunicate with other component part-1/2
//     //private DrawCircles drawCircles;

//     void Awake(){
//         // One way to comunicate with other component part-2/2
//         //drawCircles = gameObject.GetComponent<DrawCircles>();
//         rb = GetComponent<Rigidbody>();
//         isRecharged = true;
        
//     }
//     // Start is called before the first frame update
//     void Start()
//     {  
//         playerObj = GameObject.Find("Player");
//     }

//     // Update is called once per frame
//     void Update(){
//         if(transform.position.y < -15){
//             Destroy(gameObject);
//         }       
//     }
//     void FixedUpdate()
//     {
//         var fm = ForceMode.Acceleration;
//         // Didnt normalize here for the if statemengt coming next
//         Vector3 moveTowards = playerObj.transform.position - transform.position;
//         moveTowards.y = 0;
//         // if statement to check if the enemy is clser to player to boost its power
//         if(Mathf.Abs(moveTowards.magnitude) < gameObject.GetComponent<DrawCircles>().radius && isRecharged){
//             isRecharged = 
//             rb.AddForce(moveTowards.normalized * speed *2, ForceMode.Impulse);
//             Invoke(nameof(Recharge), 2f);
//         }
//         rb.AddForce(moveTowards.normalized * speed);
//     }

//     void Recharge(){
//         isRecharged = true;
//     }


/////////////////////////////////////////////////////////////////////////////////////////////////////////

//     ENEMY MOVEMENT/FOLLOW PLAYER AND ENEMY BOOST (MY WAY BY ONLY VARYING FORCEMODE)
    private GameObject playerObj;
    private Rigidbody rb;
    private float speed = 30f;
    private float boostSpeed;
    private bool isRecharged;
    // One way to comunicate with other component part-1/2
    //private DrawCircles drawCircles;

    void Awake(){
        // One way to comunicate with other component part-2/2
        //drawCircles = gameObject.GetComponent<DrawCircles>();
        rb = GetComponent<Rigidbody>();
        isRecharged = true;
        
    }
    // Start is called before the first frame update
    void Start()
    {  
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update(){
        if(transform.position.y < -15){
            Destroy(gameObject);
        }       
    }
    void FixedUpdate()
    {
        var fm = ForceMode.Acceleration;
        // Didnt normalize here for the if statemengt coming next
        Vector3 moveTowards = playerObj.transform.position - transform.position;
        moveTowards.y = 0;
        // if statement to check if the enemy is clser to player to boost its power
        if(Mathf.Abs(moveTowards.magnitude) < gameObject.GetComponent<DrawCircles>().radius && isRecharged){
            isRecharged = false;
            fm = ForceMode.Impulse;
            // Invoke(nameof(Recharge, 2f))
            Invoke("Recharge", 2f);
        }else{
            fm = ForceMode.Acceleration;
        }
        rb.AddForce(moveTowards.normalized * speed, fm);

    }

    void Recharge(){
        isRecharged = true;
    }

}
