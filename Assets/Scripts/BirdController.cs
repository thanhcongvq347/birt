using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {
    public float flyPower;
    GameObject obj;
	// Use this for initialization
	void Start () {
        obj = gameObject;
        flyPower = 50;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));

        }
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
    void EndGame()
    {
        Debug.Log("EndGame");
    }
}
