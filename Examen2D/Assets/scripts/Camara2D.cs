using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2D : MonoBehaviour {

    public Transform player;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        // Movimiento de la camara
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
