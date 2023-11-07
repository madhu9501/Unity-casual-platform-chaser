// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Elevator : MonoBehaviour, IEnableObjects
// { 
//     // TIME BASED MOVEMENT
//     private float _time=0;
//     private int _switchTime = 3;
//     private int _moveSpeed = 2;
//     private Coroutine _eleDownCourVar = null;
//     // Start is called before the first frame update.
//     // This Start has be converted to coroutine by making the return type IEnumerator and using the yield return new WaitForSeconds() statement.
//     IEnumerator Start()
//     {
//         enabled = false;
//         yield return new WaitForSeconds(3f);
//         enabled = true;
//     }

//     // Update is called once per frame.
//     void Update()
//     {
//         // _time is Accumulated Time.
//         _time += Time.deltaTime;

//         if( _time <= _switchTime ){
//             transform.Translate(Vector3.up * _moveSpeed * Time.deltaTime);
//         } else { // else is used to change the direction of movement
//             //  This coroutine will be active for 3 sec (i.e for several frames) while its waiting.
//             // Always check if the coroutine is called (not null) or null to avoide calling it everyframe even though its active.
//             if(_eleDownCourVar == null){
//                 //StartCorutine() activates the coroutine. _eleDownCourCar stores a data type of coroutine.
//                 _eleDownCourVar = StartCoroutine("ElevatorMoveDown");
//             }
            
//         } 
//     }

//     //Coroutine methods return IEnumerator type and uses the yield return new WaitForSeconds() 
//     IEnumerator ElevatorMoveDown(){
//         yield return new WaitForSeconds(3f);
//         _time = 0;
//         // -ve sign turns the vector negative causing it to move in opposte direction. and the -ve + -ve becomes positive. 
//         _moveSpeed = -_moveSpeed;
//         // reset the coroutine var
//         _eleDownCourVar = null;
//     }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // POSITION BASED MOVEMENT
    // private float _dist = 0;
    // private int _maxDist = 10;
    // private int _moveSpeed = 2;
    // private Coroutine _eleDownCourVar = null;
    // // Start is called before the first frame update.
    // // This Start has be converted to coroutine by making the return type IEnumerator and using the yield return new WaitForSeconds() statement.
    // IEnumerator Start()
    // {
    //     enabled = false;
    //     yield return new WaitForSeconds(3f);
    //     enabled = true;
    // }

    // // Update is called once per frame.
    // void Update()
    // {

    //     if( _dist <= _maxDist ){
    //         // Distance moved per sec, which is useful in calculating _dist.
    //         float distStep = _moveSpeed * Time.deltaTime;
    //         // Calc distance object has moved, so that if it crosses maxDist 'else' will be compiled.
    //         _dist += Mathf.Abs(distStep);
    //         transform.Translate(Vector3.up * distStep);
    //     } else { // else is used to change the direction of movement
    //         //  This coroutine will be active for 3 sec (i.e for several frames) while its waiting.
    //         // Always check if the coroutine is called (not null) or null to avoide calling it everyframe even though its active.
    //         if(_eleDownCourVar == null){
    //             //StartCorutine() activates the coroutine. _eleDownCourCar stores a data type of coroutine.
    //             _eleDownCourVar = StartCoroutine("ElevatorMoveDown");
    //         }
            
    //     } 
    // }

    // //Coroutine methods return IEnumerator type and uses the yield return new WaitForSeconds() 
    // IEnumerator ElevatorMoveDown(){
    //     yield return new WaitForSeconds(3f);
    //     _dist = 0;
    //     // -ve sign turns the vector negative causing it to move in opposte direction. and the -ve + -ve becomes positive. 
    //     _moveSpeed = -_moveSpeed;
    //     _eleDownCourVar = null;

    // }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // // POSITION BASED MOVEMENT WITH ABILITY TO ALLOW PLAYER TO MOVE ON IT USING RIGIDBODY
    // // using rigid body, else when the object is not the elevator, it will still act on elevator y axis outside elevator
    // private Rigidbody rb;
    // private float _dist = 0;
    // private int _maxDist = 10;
    // private int _moveSpeed = 2;
    // private Coroutine _eleDownCourVar = null;

    // void Awake(){
    //     
    // }
    // // This Start has be converted to coroutine by making the return type IEnumerator and using the yield return new WaitForSeconds() statement.
    // IEnumerator Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    //     enabled = false;
    //     yield return new WaitForSeconds(3f);
    //     enabled = true;
    // }

    // // Update is called once per frame.
    // void FixedUpdate()
    // {

    //     if( _dist <= _maxDist ){
    //         // Distance moved per sec, which is useful in calculating _dist.
    //         float distStep = _moveSpeed * Time.fixedDeltaTime;
    //         // Calc distance object has moved, so that if it crosses maxDist 'else' will be compiled.
    //         _dist += Mathf.Abs(distStep);
    //         Vector3 elevatorPos = rb.position;
    //         elevatorPos.y += distStep;    
    //         rb.MovePosition(elevatorPos);
    //     } else { // else is used to change the direction of movement
    //         //  This coroutine will be active for 3 sec (i.e for several frames) while its waiting.
    //         // Always check if the coroutine is called (not null) or null to avoide calling it everyframe even though its active.
    //         if(_eleDownCourVar == null){
    //             //StartCorutine() activates the coroutine. _eleDownCourCar stores a data type of coroutine.
    //             _eleDownCourVar = StartCoroutine("ElevatorMoveDown");
    //         }
            
    //     } 
    // }

    // //Coroutine methods return IEnumerator type and uses the yield return new WaitForSeconds() 
    // IEnumerator ElevatorMoveDown(){
    //     yield return new WaitForSeconds(3f);
    //     _dist = 0;
    //     // -ve sign turns the vector negative causing it to move in opposte direction. and the -ve + -ve becomes positive. 
    //     _moveSpeed = -_moveSpeed;
    //     // once called set this to null so it wont be executed in update() again
    //     _eleDownCourVar = null;

    // }

// /////////////////////////////////////////////////////////////////////////////////////////////////////////////

//     // POSITION BASED MOVEMENT WITH ABILITY TO ALLOW PLAYER TO MOVE ON IT USING RIGIDBODY
//     // using rigid body, else when the object is not the elevator, it will still act on elevator y axis outside elevator
//     private Rigidbody rb;
//     private float _dist = 0;
//     private int _maxDist = 10;
//     private int _moveSpeed = 2;
//     private Coroutine _eleDownCourVar = null;

//     void Awake(){
//         rb = GetComponent<Rigidbody>();
//         enabled = false;
//     }
//     // This Start has be converted to coroutine by making the return type IEnumerator and using the yield return new WaitForSeconds() statement.
//     private IEnumerator StartElevator()
//     {
//         yield return new WaitForSeconds(3f);
//         enabled = true;
//     }

//     // Update is called once per frame.
//     void FixedUpdate()
//     {

//         if( _dist <= _maxDist ){
//             // Distance moved per sec, which is useful in calculating _dist.
//             float distStep = _moveSpeed * Time.fixedDeltaTime;
//             // Calc distance object has moved, so that if it crosses maxDist 'else' will be compiled.
//             _dist += Mathf.Abs(distStep);
//             Vector3 elevatorPos = rb.position;
//             elevatorPos.y += distStep;    
//             rb.MovePosition(elevatorPos);
//         } else { // else is used to change the direction of movement
//             //  This coroutine will be active for 3 sec (i.e for several frames) while its waiting.
//             // Always check if the coroutine is called (not null) or null to avoide calling it everyframe even though its active.
//             if(_eleDownCourVar == null){
//                 //StartCorutine() activates the coroutine. _eleDownCourCar stores a data type of coroutine.
//                 _eleDownCourVar = StartCoroutine("ElevatorMoveDown");
//             }
            
//         } 
//     }

//     //Coroutine methods return IEnumerator type and uses the yield return new WaitForSeconds() 
//     IEnumerator ElevatorMoveDown(){
//         yield return new WaitForSeconds(3f);
//         _dist = 0;
//         // -ve sign turns the vector negative causing it to move in opposte direction. and the -ve + -ve becomes positive. 
//         _moveSpeed = -_moveSpeed;
//         // once called set this to null so it wont be executed in update() again
//         _eleDownCourVar = null;
//     }

//     public void EnableObj(){
//         StartCoroutine("StartElevator");
//     }


// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour//, IEnableObjects
{ 
    // POSITION BASED MOVEMENT WITH ABILITY TO ALLOW PLAYER TO MOVE ON IT USING RIGIDBODY
    // using rigid body, else when the object is not the elevator, it will still act on elevator y axis outside elevator
    private Rigidbody rb;
    private float _dist = 0;
    private int _maxDist = 10;
    private int _moveSpeed = 2;
    private Coroutine _eleDownCourVar = null;

    void Awake(){
        rb = GetComponent<Rigidbody>();
        enabled = false;
    }
    void Start(){
        StartCoroutine("StartElevator");
    }
    // This Start has be converted to coroutine by making the return type IEnumerator and using the yield return new WaitForSeconds() statement.
    private IEnumerator StartElevator()
    {
        yield return new WaitForSeconds(3f);
    }

    // Update is called once per frame.
    void FixedUpdate()
    {

        if( _dist <= _maxDist ){
            // Distance moved per sec, which is useful in calculating _dist.
            float distStep = _moveSpeed * Time.fixedDeltaTime;
            // Calc distance object has moved, so that if it crosses maxDist 'else' will be compiled.
            _dist += Mathf.Abs(distStep);
            Vector3 elevatorPos = rb.position;
            elevatorPos.y += distStep;    
            rb.MovePosition(elevatorPos);
        } else { // else is used to change the direction of movement
            //  This coroutine will be active for 3 sec (i.e for several frames) while its waiting.
            // Always check if the coroutine is called (not null) or null to avoide calling it everyframe even though its active.
            if(_eleDownCourVar == null){
                //StartCorutine() activates the coroutine. _eleDownCourCar stores a data type of coroutine.
                _eleDownCourVar = StartCoroutine("ElevatorMoveDown");
            }
            
        } 
    }

    //Coroutine methods return IEnumerator type and uses the yield return new WaitForSeconds() 
    IEnumerator ElevatorMoveDown(){
        yield return new WaitForSeconds(3f);
        _dist = 0;
        // -ve sign turns the vector negative causing it to move in opposte direction. and the -ve + -ve becomes positive. 
        _moveSpeed = -_moveSpeed;
        // once called set this to null so it wont be executed in update() again
        _eleDownCourVar = null;
    }

    public void EnableObj(){
        enabled = true;
    }


}