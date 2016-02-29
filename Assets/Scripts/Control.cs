using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    
    public float speedX = 1.1f;
    public int mov = 0;
    private WaitForSeconds delay_time = new WaitForSeconds(0.00001f);
    public float velocidad = 5.4f;
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
            anim.SetFloat("speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
            float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
            float posX = (transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime));
            transform.position = new Vector2(posX, GetComponent<Rigidbody2D>().position.y);
    }





}
