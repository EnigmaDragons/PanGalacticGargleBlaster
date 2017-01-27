using UnityEngine;
using System.Collections;

public class ReticleBehavior : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        var pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.5f);
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        transform.LookAt(new Vector3(0, 0, 0));
    }
}
