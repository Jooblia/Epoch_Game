using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCollider : MonoBehaviour
{
    public Text textBox;
    public GameObject player;
    bool enter = false;
    private PlayerMovement movement;
    void Start()
    {
        textBox.text = "";
        movement = GetComponent<PlayerMovement>();
    }   
    private void OnTriggerStay2D(Collider2D collision)
    {       
        if (Input.GetKey(KeyCode.Return))
        {

            enter = true;
            if (collision.gameObject.name == "Table")
            {
                textBox.text = "An uninteresting table.";
            }
        }
        if (enter == true)
        {
            //GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().moveSpeed = 0;
            if (Input.GetKey(KeyCode.Z))
            {
                textBox.text = "";
                //GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
                GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().moveSpeed = 5;
                enter = false;
            }
        }        
    }
}
