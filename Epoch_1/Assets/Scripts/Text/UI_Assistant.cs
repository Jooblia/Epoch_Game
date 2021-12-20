using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    private Text prompt;

    private void Awake()
    {
        prompt = GameObject.FindWithTag("Text").GetComponent<Text>();
    }
    private void Start()
    {
        prompt.text = "Ayoooo";
    }
}
