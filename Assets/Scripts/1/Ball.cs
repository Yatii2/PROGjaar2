
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    private GameObject CreateBall(Color c, Vector3 position)
    {
        {
            GameObject ball = Instantiate(prefab, position, Quaternion.identity);
            Material material = ball.GetComponent<MeshRenderer>().material;
            material.SetColor("_Color", c);

            
            return ball;

        }
    }
    private void Start()
    {
        for (int i = 0; i < 100; i++) 
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);
            float x = Random.Range(0f, 1f);
            float y = Random.Range(0f, 1f);
            float z = Random.Range(0f, 1f);
            Vector3 randPos = new Vector3(x, y, z);

            CreateBall(randColor, randPos);

           

        }
        
    }




    private float elapsedTime = 0f;
    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        Vector3 randPos = new Vector3(x, y, z);

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {

            GameObject ball = CreateBall(randColor, randPos);

            DestroyBall(ball);

            elapsedTime = 0f;

        }
    }
    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }
}
