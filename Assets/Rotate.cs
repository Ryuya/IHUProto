using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float speed = 0.3f;
    private float i = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime * speed;
        this.transform.Rotate(0f,i,0f);
    }
}
