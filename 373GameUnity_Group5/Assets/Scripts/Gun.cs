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
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1") && Time.time > nextFireRate)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject obj;
        nextFireRate = Time.time + firerate;
        obj = Instantiate(Gbullet);
        obj.transform.position = spawn.transform.position;
       
    }
}
