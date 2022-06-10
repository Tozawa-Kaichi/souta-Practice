using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genarate : MonoBehaviour
{
    [SerializeField] GameObject ass;
    [SerializeField] Transform spown;
    [SerializeField] float time11 =  5f;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > time11)
        {
            time=0;
            var x = Instantiate(ass);
            x.transform.position = this.transform.position;
        }

    }
}
