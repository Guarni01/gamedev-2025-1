using UnityEngine;

public class Propeller : MonoBehaviour
    
{   public float speed= 100.0f;


// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
