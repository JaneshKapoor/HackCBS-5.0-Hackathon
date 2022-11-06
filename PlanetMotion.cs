 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMotion : MonoBehaviour
{
    public Transform Sun;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Sun.position,transform.up,speed * Time.deltaTime);   
    }
}
