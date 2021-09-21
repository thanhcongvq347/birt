using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {

    public float moveSpeed;
    public float minY;
    public float maxY;

    // Use this for initialization
    public float oldPosition;
    private GameObject obj;
    void Start()
    {
        obj = gameObject;
        oldPosition = 10;
        moveSpeed = 5;
        minY = -1;
        maxY = 1;
     


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("ResetWall"))
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY,maxY+1), 0);
    }
}
