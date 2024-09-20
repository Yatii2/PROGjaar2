
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;

    private Color GetRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        return new Vector3(x, y, z);
    }
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
            Color randColor = GetRandomColor();
            Vector3 randPos = GetRandomPosition();
            CreateBall(randColor, randPos);

        }

    }


    private float elapsedTime = 0f;
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            Color randColor = GetRandomColor();
            Vector3 randPos = GetRandomPosition();
            GameObject ball = CreateBall(randColor, randPos);

            DestroyBall(ball);
            elapsedTime = 0f;
            }
        
    }
    void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }
}
