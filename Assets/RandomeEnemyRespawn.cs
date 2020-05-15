using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomeEnemyRespawn : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load ("Prefabs/Test_98vertex");

        for (int x = 0; x < 250; x++)
        {
            var x_pos = (float)Random.Range(-125,125);
            var z_pos = (float)Random.Range(0,250);
            // プレハブを元にオブジェクトを生成する
                GameObject instance = (GameObject) Instantiate(obj,
                    new Vector3(x_pos, 0.0f, z_pos),
                    Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
