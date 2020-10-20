using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_script : MonoBehaviour {
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = 7;
    }

    // Update is called once per frame
    void Update() {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        transform.position = new Vector3(x + (speed * Time.deltaTime), y, z);
    }
}
