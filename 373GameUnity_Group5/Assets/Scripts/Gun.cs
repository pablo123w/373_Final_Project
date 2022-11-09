using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform gun;
    public GameObject Gbullet;
    public GameObject spawn;
    public float firerate;
    private float nextFireRate;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown("1") && Time.time > nextFireRate)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
       // GameObject obj;
        nextFireRate = Time.time + firerate;
        GameObject newProjectile = Instantiate(Gbullet);
        newProjectile.transform.position = spawn.transform.position;
        newProjectile.transform.rotation = transform.rotation;
       // newProjectile.SetActive(true);
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        Destroy(newProjectile, 5f);

    }
}
