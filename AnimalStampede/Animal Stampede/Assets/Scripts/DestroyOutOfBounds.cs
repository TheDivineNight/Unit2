using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object goes past the player's view ingame, destroy object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
