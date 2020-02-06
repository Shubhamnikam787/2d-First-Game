using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody2D circle;
    public float jumpForce = 7f;
    public string currentColor;
    public SpriteRenderer sr;
    public Color blue;
    public Color yellow;
    public Color pink;
    public Color purple;

    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1); ;
        //sr.color = pink;
        setRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            circle.velocity = Vector2.up * jumpForce;
        } 
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != currentColor) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("game over");
        }
        //Debug.Log(collision.tag);
    }

    public void setRandomColor() {
        int randm = Random.Range(0, 4);

        switch (randm) {
            case 0:
                currentColor = "blue";
                sr.color = blue;
                break;
            case 1:
                currentColor = "yellow";
                sr.color = yellow;
                break;
            case 2:
                currentColor = "purple";
                sr.color = purple;
                break;
            case 3:
                currentColor = "pink";
                sr.color = pink;
                break;
        }
    }
}
