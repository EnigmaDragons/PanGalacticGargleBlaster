using UnityEngine;
using System.Collections;

public class MagicaruRotatoCamera : MonoBehaviour {

    public float speed = 0.1f;

	// Use this for initialization
	void Start () {
        tag = "MainCamera";
	}

    Vector3 GetTranslation()
    {
        var position = transform.position;
        var translation = new Vector3();

        if(Input.GetKey(KeyCode.A))
        {
            translation.x = -speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            translation.y = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            translation.x = speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            translation.y = speed;
        }

        return translation;
    }
	
	// Update is called once per frame
	void Update() {
        transform.Translate(GetTranslation());
        transform.LookAt(new Vector3(0, 0, 0));
	}
}
