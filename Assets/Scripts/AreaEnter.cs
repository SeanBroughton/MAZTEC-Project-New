using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{

    [SerializeField] string areaToEnterName;

    // Start is called before the first frame update
    void Start()
    {
        //Changes the Player's current position to the Area Enter's Position
        if(areaToEnterName == Player.instance.playerCurrentArea)
        {
            Player.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
