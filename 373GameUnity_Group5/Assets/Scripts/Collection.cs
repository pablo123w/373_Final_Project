using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    public int collect;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        collect = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject gh;
        if(other.gameObject.tag == "RedOrb")
        {
            gh = other.gameObject;
            collect++;
            UpdateText();
            Destroy(gh);
        }
    }
    public void UpdateText()
    {
        score.text = "RedOrbs:  " + collect;
    }
}
