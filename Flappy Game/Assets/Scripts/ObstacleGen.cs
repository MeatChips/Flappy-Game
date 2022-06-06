using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGen : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int genRate = 100;

    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if(timer >= genRate)
        {
            timer = 0;
            GameObject newObstacle = Instantiate(obstaclePrefab, new Vector2(obstaclePrefab.transform.position.x, obstaclePrefab.transform.position.y + Random.Range(-2f, 2f)), obstaclePrefab.transform.rotation);
            Destroy(newObstacle, 10f);
        }
    }
}
