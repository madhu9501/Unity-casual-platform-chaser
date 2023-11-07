// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;

// public class PlayerMovement : MonoBehaviour, IEnableObjects
// {
    // // PLAYER MOVEMENT
    // public float moveSpeed;
    // private Rigidbody rb;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     // Read Input
    //     // i/p is either in between -1 and 1, hence will give smooth transition so the player will not stop immediately 
    //     //float horMove = Input.GetAxisRaw("Horizontal");
    //     //float verMove = Input.GetAxisRaw("Vertical");
    //     // GetAxisRaw will stop the player movement immediately i/p is either -1, 0 or 1, no in between
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input
    //     Vector3 direction = new Vector3(horMove, 0f,verMove);
    //     // normalize = direction is represnted with magnitude of one
    //     direction.Normalize();
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(rb.position + direction * Time.fixedDeltaTime * moveSpeed);

    // }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR
    // public float moveSpeed;
    // private Rigidbody rb;
    // private GameObject elevatorObj;
    // private float elevatorOffsetY;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     // Read Input
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input
    //     Vector3 direction = new Vector3(horMove, 0f,verMove);
    //     // normalize = direction is represnted with magnitude of one.
    //     direction.Normalize();
    //     // Get player pos in a var so you can manipulate y position.
    //     Vector3 playerPos = rb.position; 
    //     // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
    //     if( elevatorObj != null){
    //         playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY; 
    //     }  
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed);
    // }

    // void OnTriggerEnter(Collider other){
    //     // Check if the trigger is from elevator.
    //     if(other.CompareTag("ElevatorTrigger")){
    //         // Get elevator game object
    //         elevatorObj = other.gameObject;
    //         // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
    //         elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
    //     }        
    // }

    // void OnTriggerExit(Collider other){
    //     // If the player exits the elevator null the elevator object and the offset
    //     if(other.CompareTag("ElevatorTrigger")){
    //         elevatorObj = null;
    //         elevatorOffsetY = 0;
    //     }
    // }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //  // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR AND LOOK ROTATION
    // public float moveSpeed;
    // private Rigidbody rb;
    // private GameObject elevatorObj;
    // private float elevatorOffsetY;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     // Read Input
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input. normalized = direction is represnted with the magnitude of one.
    //     Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
    //     // Get player pos in a var so you can manipulate y position.
    //     Vector3 playerPos = rb.position; 
    //     // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
    //     if( elevatorObj != null){
    //         playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
    //     }  
    //     // Cuz rotation only if object is moving, if not dont rotate (includes reseting the angle when movement stops.). 
    //     //    This if statement will make the player face the direction at which it stopped.
    //     if(direction != Vector3.zero){
    //     // Get angle that the object should be facing in quaterniton. 
    //     // Quaternion playerRot = Quaternion.LookRotation(direction, Vector3.up);
    //     Quaternion playerRot = Quaternion.LookRotation(direction);
    //     // Alter the speed of the rotation. Initial angle, final angle and rate of change of angle. 
    //     playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
    //     // change the angle of the rb.
    //     rb.MoveRotation(playerRot);
    //     }
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed);
    // }

    // void OnTriggerEnter(Collider other){
    //     // Check if the trigger is from elevator.
    //     if(other.CompareTag("ElevatorTrigger")){
    //         // Get elevator game object
    //         elevatorObj = other.gameObject;
    //         // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
    //         elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
    //     }        
    // }

    // void OnTriggerExit(Collider other){
    //     // If the player exits the elevator null the elevator object and the offset
    //     if(other.CompareTag("ElevatorTrigger")){
    //         elevatorObj = null;
    //         elevatorOffsetY = 0;
    //     }
    // }

    
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR, LOOK ROTATION, destroy hero
    // public float moveSpeed;
    // public Camera playerCam;
    // private Rigidbody rb;
    // private GameObject elevatorObj;
    // private float elevatorOffsetY;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     // Read Input
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input. normalized = direction is represnted with the magnitude of one.
    //     Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
    //     // Get player pos in a var so you can manipulate y position.
    //     Vector3 playerPos = rb.position; 
    //     // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
    //     if( elevatorObj != null){
    //         playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
    //     }  
    //     // Cuz rotation only if object is moving, if not dont rotate (includes reseting the angle when movement stops.). 
    //     //    This if statement will make the player face the direction at which it stopped.
    //     if(direction != Vector3.zero){
    //     // Get angle that the object should be facing in quaterniton. 
    //     // Quaternion playerRot = Quaternion.LookRotation(direction, Vector3.up);
    //     Quaternion playerRot = Quaternion.LookRotation(direction);
    //     // Alter the speed of the rotation. Initial angle, final angle and rate of change of angle. 
    //     playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
    //     // change the angle of the rb.
    //     rb.MoveRotation(playerRot);
    //     }
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed);
        
    //     // if(transform.position.y < -15f){
    //     //     Destroy(gameObject);
    //     // }

    // }

    // void OnTriggerEnter(Collider other){
    //     // Check if the trigger is from elevator.
    //     if(other.CompareTag("ElevatorTrigger")){
    //         // Get elevator game object
    //         elevatorObj = other.gameObject;
    //         // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
    //         elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
    //     }        
    // }

    // void OnTriggerExit(Collider other){
    //     // If the player exits the elevator null the elevator object and the offset
    //     if(other.CompareTag("ElevatorTrigger")){
    //         elevatorObj = null;
    //         elevatorOffsetY = 0;
    //     }
    // }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR, LOOK ROTATION, POWER UP
    // public float moveSpeed;
    // public Camera playerCam;
    // private Rigidbody rb;
    // private GameObject elevatorObj;
    // private float elevatorOffsetY;
    // private float speedModifyer;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    //     speedModifyer =1;
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     // Read Input
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input. normalized = direction is represnted with the magnitude of one.
    //     Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
    //     // Get player pos in a var so you can manipulate y position.
    //     Vector3 playerPos = rb.position; 
    //     // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
    //     if( elevatorObj != null){
    //         playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
    //     }  
    //     // Cuz rotation only if object is moving, if not dont rotate (includes reseting the angle when movement stops.). 
    //     //    This if statement will make the player face the direction at which it stopped.
    //     if(direction != Vector3.zero){
    //     // Get angle that the object should be facing in quaterniton. 
    //     // Quaternion playerRot = Quaternion.LookRotation(direction, Vector3.up);
    //     Quaternion playerRot = Quaternion.LookRotation(direction);
    //     // Alter the speed of the rotation. Initial angle, final angle and rate of change of angle. 
    //     playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
    //     // change the angle of the rb.
    //     rb.MoveRotation(playerRot);
    //     }
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed * speedModifyer);
        
    //     // if(transform.position.y < -15f){
    //     //     Destroy(gameObject);
    //     // }

    // }

    // private IEnumerator PowerCountDown(){
    //     yield return new WaitForSeconds(10);
    //     speedModifyer = 1;
    // }

    // private void OnCollisionEnter(Collision collision){
    //     if(collision.gameObject.CompareTag("Power")){
    //         Destroy(collision.gameObject);
    //         speedModifyer = 2;
    //         StartCoroutine(PowerCountDown());

    //     }

    //     if(collision.gameObject.CompareTag("Enemy") && speedModifyer > 1){
    //         Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
    //         Vector3 impactDir = collision.transform.position - transform.position;
    //         rbEnemy.AddForce(impactDir * 50, ForceMode.Impulse);
    //     }
    // }

    // void OnTriggerEnter(Collider other){
    //     // Check if the trigger is from elevator.
    //     if(other.CompareTag("ElevatorTrigger")){
    //         // Get elevator game object
    //         elevatorObj = other.gameObject;
    //         // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
    //         elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
    //     }        
    // }

    // void OnTriggerExit(Collider other){
    //     // If the player exits the elevator null the elevator object and the offset
    //     if(other.CompareTag("ElevatorTrigger")){
    //         elevatorObj = null;
    //         elevatorOffsetY = 0;
    //     }
    // }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR, LOOK ROTATION, POWER UP, RESTART GAME ON PLAYER FALL
    // public float moveSpeed;
    // public Camera playerCam;
    // public UnityEvent restartGame;


    // private Rigidbody rb;
    // private GameObject elevatorObj;
    // private float elevatorOffsetY;
    // private float speedModifyer;
    
    // // Start is called before the first frame update
    // void Awake()
    // {
    //     rb = GetComponent<Rigidbody>();
    //     speedModifyer =1;
    // }

    // // FixedUpdate is called once per frame
    // void FixedUpdate()
    // {
    //     if(transform.position.y < -10f){
    //         restartGame.Invoke();
    //     }
    //     // Read Input
    //     float horMove = Input.GetAxisRaw("Horizontal");
    //     float verMove = Input.GetAxisRaw("Vertical");
    //     // Get direction from the input. normalized = direction is represnted with the magnitude of one.
    //     Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
    //     // Get player pos in a var so you can manipulate y position.
    //     Vector3 playerPos = rb.position; 
    //     // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
    //     if( elevatorObj != null){
    //         playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
    //     }  
    //     // Cuz rotation only if object is moving, if not dont rotate (includes reseting the angle when movement stops.). 
    //     //    This if statement will make the player face the direction at which it stopped.
    //     if(direction != Vector3.zero){
    //     // Get angle that the object should be facing in quaterniton. 
    //     // Quaternion playerRot = Quaternion.LookRotation(direction, Vector3.up);
    //     Quaternion playerRot = Quaternion.LookRotation(direction);
    //     // Alter the speed of the rotation. Initial angle, final angle and rate of change of angle. 
    //     playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
    //     // change the angle of the rb.
    //     rb.MoveRotation(playerRot);
    //     }
    //     // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
    //     rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed * speedModifyer);

    // }

    // private IEnumerator PowerCountDown(){
    //     yield return new WaitForSeconds(10);
    //     speedModifyer = 1;
    // }

    // private void OnCollisionEnter(Collision collision){
    //     if(collision.gameObject.CompareTag("Power")){
    //         Destroy(collision.gameObject);
    //         speedModifyer = 2;
    //         StartCoroutine(PowerCountDown());

    //     }

    //     if(collision.gameObject.CompareTag("Enemy") && speedModifyer > 1){
    //         Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
    //         Vector3 impactDir = collision.transform.position - transform.position;
    //         rbEnemy.AddForce(impactDir * 50, ForceMode.Impulse);
    //     }
    // }

    // void OnTriggerEnter(Collider other){
    //     // Check if the trigger is from elevator.
    //     if(other.CompareTag("ElevatorTrigger")){
    //         // Get elevator game object
    //         elevatorObj = other.gameObject;
    //         // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
    //         elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
    //     }        
    // }

    // void OnTriggerExit(Collider other){
    //     // If the player exits the elevator null the elevator object and the offset
    //     if(other.CompareTag("ElevatorTrigger")){
    //         elevatorObj = null;
    //         elevatorOffsetY = 0;
    //     }
    // }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

//     // PLAYER MOVEMENT, ABILITY TO MOVE ON ELEVATOR, LOOK ROTATION, POWER UP, RESTART GAME ON PLAYER FALL, PLAYER DEOESNT MOVE TILL GAME STARTS
//     public float moveSpeed;
//     public Camera playerCam;
//     public UnityEvent restartGame;


//     private Rigidbody rb;
//     private GameObject elevatorObj;
//     private float elevatorOffsetY;
//     private float speedModifyer;
    
//     // Start is called before the first frame update
//     void Awake()
//     {
//         enabled= false;
//         rb = GetComponent<Rigidbody>();
//         speedModifyer =1;
//     }

//     // FixedUpdate is called once per frame
//     void FixedUpdate()
//     {
//         if(transform.position.y < -10f){
//             restartGame.Invoke();
//         }
//         // Read Input
//         float horMove = Input.GetAxisRaw("Horizontal");
//         float verMove = Input.GetAxisRaw("Vertical");
//         // Get direction from the input. normalized = direction is represnted with the magnitude of one.
//         Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
//         // Get player pos in a var so you can manipulate y position.
//         Vector3 playerPos = rb.position; 
//         // if the player is on top of elevator manipulate player y pos wrt elevator y pos, to avoid plaer from bouncing on the way down
//         if( elevatorObj != null){
//             playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
//         }  
//         // Cuz rotation only if object is moving, if not dont rotate (includes reseting the angle when movement stops.). 
//         //    This if statement will make the player face the direction at which it stopped.
//         if(direction != Vector3.zero){
//         // Get angle that the object should be facing in quaterniton. 
//         // Quaternion playerRot = Quaternion.LookRotation(direction, Vector3.up);
//         Quaternion playerRot = Quaternion.LookRotation(direction);
//         // Alter the speed of the rotation. Initial angle, final angle and rate of change of angle. 
//         playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
//         // change the angle of the rb.
//         rb.MoveRotation(playerRot);
//         }
//         // Move the body in the direction with moveSpeed units per 0.02s (fixdDeltaTime)
//         rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed * speedModifyer);

//     }

//     private IEnumerator PowerCountDown(){
//         yield return new WaitForSeconds(10);
//         speedModifyer = 1;
//     }

//     private void OnCollisionEnter(Collision collision){
//         if(collision.gameObject.CompareTag("Power")){
//             Destroy(collision.gameObject);
//             speedModifyer = 2;
//             StartCoroutine(PowerCountDown());

//         }

//         if(collision.gameObject.CompareTag("Enemy") && speedModifyer > 1){
//             Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
//             Vector3 impactDir = collision.transform.position - transform.position;
//             rbEnemy.AddForce(impactDir * 50, ForceMode.Impulse);
//         }
//     }

//     void OnTriggerEnter(Collider other){
//         // Check if the trigger is from elevator.
//         if(other.CompareTag("ElevatorTrigger")){
//             // Get elevator game object
//             elevatorObj = other.gameObject;
//             // Get the distance between elevtor and player to maintain the distance bw then so the player dosent bounce on the way down.
//             elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
//         }        
//     }

//     void OnTriggerExit(Collider other){
//         // If the player exits the elevator null the elevator object and the offset
//         if(other.CompareTag("ElevatorTrigger")){
//             elevatorObj = null;
//             elevatorOffsetY = 0;
//         }
//     }

//     public void EnableObj(){
//         enabled = true;
//     }

// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] private Camera playerCam;
    public UnityEvent restartGame;


    private Rigidbody rb;
    private GameObject elevatorObj;
    private float elevatorOffsetY;
    private float speedModifyer;
    float horMove;
    float verMove;
    
    void Awake()
    {
        enabled= false;
        rb = GetComponent<Rigidbody>();
        speedModifyer =1;
    }

    void Update(){
        if(transform.position.y < -10f){
            restartGame.Invoke();
        }
        horMove = Input.GetAxisRaw("Horizontal");
        verMove = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer(){
        Vector3 direction = new Vector3(horMove, 0f,verMove).normalized;
        Vector3 playerPos = rb.position; 
        if( elevatorObj != null){
            playerPos.y = elevatorObj.transform.position.y + elevatorOffsetY;
        }  
        if(direction != Vector3.zero){
        Quaternion playerRot = Quaternion.LookRotation(direction);
        playerRot = Quaternion.RotateTowards(transform.rotation, playerRot, 540 * Time.fixedDeltaTime);
        rb.MoveRotation(playerRot);
        }
        rb.MovePosition(playerPos + direction * Time.fixedDeltaTime * moveSpeed * speedModifyer);

    }

    private IEnumerator PowerCountDown(){
        yield return new WaitForSeconds(10);
        speedModifyer = 1;
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Power")){
            Destroy(collision.gameObject);
            speedModifyer = 2;
            StartCoroutine(PowerCountDown());

        }

        if(collision.gameObject.CompareTag("Enemy") && speedModifyer > 1){
            Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 impactDir = collision.transform.position - transform.position;
            rbEnemy.AddForce(impactDir * 50, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("ElevatorTrigger")){
            elevatorObj = other.gameObject;
            elevatorOffsetY = transform.position.y - elevatorObj.transform.position.y; 
        }        
    }

    void OnTriggerExit(Collider other){
        if(other.CompareTag("ElevatorTrigger")){
            elevatorObj = null;
            elevatorOffsetY = 0;
        }
    }

    public void EnableObj(){
        enabled = true;
    }

}