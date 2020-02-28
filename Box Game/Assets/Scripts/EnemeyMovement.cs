
using UnityEngine;

public class EnemeyMovement : MonoBehaviour 
{
    public Rigidbody rb;
    public float ForwardForce = 75f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(ForwardForce, 0, ForwardForce * Time.deltaTime);
	}
}
