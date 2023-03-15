using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CollisionDetection : MonoBehaviour {
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            Debug.Log("Saya bersentuhan dengan Trigger");
        }
       
    }


    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("Saya tetap bersentuhan dengan TriggerStay");

    }
    
    private void OnTriggerExit2D(Collider2D collision){
        Debug.Log("Saya tidak lagi bersentuhan : ( ");
        
    }

    private void OnCollisionEnter2D(Collision2D enter) {
        Debug.Log("Saya menabrak dengan Collision");

    }

    private void OnCollisionStay2D(Collision2D stay) {
        Debug.Log("Saya tetap bertabrakan");

    }
    
    private void OnCollisionExit2D(Collision2D exit){
        Debug.Log("Saya tetap bertabrakan");

    }
}
