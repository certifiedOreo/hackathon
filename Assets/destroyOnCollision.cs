using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
	 [SerializeField] private Transform car;
	private void OnCollisionEnter(Collision collision){
		if(collision.collider.name=="car")
		{
				Destroy(collision.gameObject);
		}
	
	}
    
}
