using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWin : MonoBehaviour
{
    public GameObject Ui;
    // Start is called before the first frame update
    void Start()
    {
        Ui = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Ui);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ui.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Ui.SetActive(true);
        }
    }
}
