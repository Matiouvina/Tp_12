using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceRotate : MonoBehaviour
{
    public float velocidadRotate = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,velocidadRotate * Time.deltaTime);
    }
}
