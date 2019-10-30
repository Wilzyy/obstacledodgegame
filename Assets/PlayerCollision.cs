using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter(PlayerCollision col)
    {
        if (col.gameObject.name == "Obstacle 1") {
            Debug.Log("Collsion Detected");
        }



    

    
}
