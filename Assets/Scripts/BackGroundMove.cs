using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {
    public float moveSpeed;
    public float moveRange;
	// Use this for initialization
    private Vector3 oldPosition;
    private GameObject obj;
	void Start () {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 5;
        moveRange = 20;

		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-1 * Time.deltaTime*moveSpeed, transform.position.y, 0));
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
