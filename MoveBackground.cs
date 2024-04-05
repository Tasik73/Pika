using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    //[SerializeField]
    public float speed;
    public GameObject background;
    public float backLength;
    public int backsCount;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.right * speed*Time.deltaTime);
        if (transform.position.x < background.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + backLength * backsCount, transform.position.y);
        }
    }

    
}
