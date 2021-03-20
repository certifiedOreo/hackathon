using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseTheif : MonoBehaviour
{
	// public GameObject player;
	  [SerializeField] private Transform player;
 
	    // Use this for initialization
	    void Start () {
         
	    }
     
	    // Update is called once per frame
	    void Update () {
	       // transform.LookAt(player.transform);
	        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
	        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
	        transform.position += transform.forward * 10f * Time.deltaTime;
	    }
	}
   