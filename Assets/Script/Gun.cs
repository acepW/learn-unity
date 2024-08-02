using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform BulletSpawnPoint;
    public GameObject BulletPreFab;
    public float BulletSpeed = 10;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) )
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        var bullet = Instantiate(BulletPreFab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * BulletSpeed;
    }
}
