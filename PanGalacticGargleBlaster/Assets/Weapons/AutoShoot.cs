using UnityEngine;
using System.Collections;

public class AutoShoot : MonoBehaviour {

    public Rigidbody Bullet;
    //public float speed = 5f;
    public double deltaTime;
    public double timePerShot;
    
    void Start()
    {
        deltaTime = 0.0;
    }
    
    void Update()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime > timePerShot)
        {
            deltaTime -= timePerShot;
            Shoot();
        }
    }

    private void Shoot()
    {
        var bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}
