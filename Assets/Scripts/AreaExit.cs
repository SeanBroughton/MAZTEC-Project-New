using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{

    [SerializeField] string sceneToLoad;
    [SerializeField] string areaToTransitionTo;

    void Start()
    {

    }

    void Update()
    {
        
    }

    //Triggers the level area change when the player walks over Area Exit
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            Player.instance.playerCurrentArea = areaToTransitionTo;
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
