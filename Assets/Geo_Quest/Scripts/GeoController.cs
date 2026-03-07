using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
Color red = new Color(1f, 0f, 0f);
Color green = new Color(0f, 1f, 0f);
Color blue = new Color(0f, 0f, 1f);

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Secen2";
    string hello = "Hello ";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string world = "World";
        Debug.Log(hello + world);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel= SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;

                   public class ColorSwitcher : MonoBehaviour
    {
        Renderer rend;

        void Start()
        {
            rend = GetComponent<Renderer>();
        }

        void Update()
        {
           
        }
    }
}


/*
 if (Input.GetKeyDown(KeyCode.W))
{
   transform.position   +=  new Vector3(0, 1, 0);
}
if (Input.GetKeyDown(KeyCode.S))
{
   transform
*/
