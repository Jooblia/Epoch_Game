using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCollider : MonoBehaviour
{
    public Text textBox;
    public GameObject player;
    private PlayerMovement movement;
    void Start()
    {
        textBox.text = "";
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    bool enter = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (Input.GetKey(KeyCode.Return))
        {
            enter = true;
            if (collision.gameObject.name == "Table")
            {
                textBox.text = "An uninteresting table.";
                
                //while (!Input.GetKeyDown(KeyCode.Z))
                //{
                //    movement.enabled = false;
                //}
                //textBox.text = "";
                //movement.enabled = true;
            }
        }
        if (enter == true)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            if (Input.GetKey(KeyCode.Z))
            {
                textBox.text = "";
                GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
                enter = false;
            }
        }
        
    }
}
