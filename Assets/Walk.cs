using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    public float speed = 0.4f;

	// Use this for initialization
	void Start () {
        Debug.Log("Comienzo aqui");
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");

        float posX = (transform.position.x + (horizontal * speed * Time.deltaTime));
        transform.position = new Vector2(posX, 0);
        
    }
}
