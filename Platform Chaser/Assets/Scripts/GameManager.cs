// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;
// using UnityEngine.SceneManagement;

// public class GameManager : MonoBehaviour
// {
//     public GameObject gameUi;
//     public UnityEvent EnableMeth; 

//     private SpawnManager spawnManager;

//     // Start is called before the first frame update
//     void Start()
//     {
//         spawnManager = FindObjectOfType<SpawnManager>();
//         var elevator = FindObjectsOfType<Elevator>();

//         for(int i=0; i<elevator.Length; i++){
//             EnableMeth.AddListener(elevator[i].EnableObj);
//         }
//     }

//     // Public method to make it accessible in the button inspector
//     public void StartGame()
//     {
//         EnableMeth.Invoke();
//         spawnManager.StartSpawning();
//         gameUi.SetActive(false);
//     }

//     public void RestartGame()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//     }
    
    
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameUi;
    public UnityEvent EnableMeth; 

    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        var elevator = FindObjectsOfType<Elevator>();

        for(int i=0; i<elevator.Length; i++){
            EnableMeth.AddListener(elevator[i].EnableObj);
        }
    }

    // Public method to make it accessible in the button inspector
    public void StartGame()
    {
        EnableMeth.Invoke();
        //spawnManager.StartSpawning();
        //Or subscribe above method to the event
        gameUi.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}