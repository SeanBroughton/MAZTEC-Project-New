using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{

    [SerializeField] string sceneToLoad;

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
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
