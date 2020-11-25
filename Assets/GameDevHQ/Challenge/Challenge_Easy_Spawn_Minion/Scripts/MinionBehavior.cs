using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 2.0f * Time.deltaTime);
        if (this.transform.position.x > 2.0f)
        {
            this.GetComponent<Renderer>().material.SetColor("_Color", Color.green) ;
        }
        if (this.transform.position.x > 5.5f)
        {
            Destroy(this, 2.0f);
        }
        
    }
}
