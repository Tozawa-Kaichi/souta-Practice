using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWin : MonoBehaviour
{
    [SerializeField] GameObject Ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ui.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ui.SetActive(true);
    }
}
