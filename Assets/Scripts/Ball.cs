using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    private void CreateBall()
    {
        Instantiate(prefab);
        new Vector3(0,5,0);
    }

    private float elapsedTime = 0f;
 
    void Start()
    { 
    }
    

    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            CreateBall();
            elapsedTime = 0f;
        }

    }
}
