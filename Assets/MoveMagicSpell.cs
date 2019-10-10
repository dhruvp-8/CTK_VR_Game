using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMagicSpell : MonoBehaviour
{
    public float speed = 1.0f;
    GameObject spell = null;
    Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        spell = GameObject.Find("Water_magic_spell");

        Debug.Log(spell.transform.position);
        v = spell.transform.position;
        //target = spell.transform;

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        //Debug.Log("Hello");
        //Debug.Log(Camera.main.transform.position);
        
        spell.transform.position = Vector3.MoveTowards(spell.transform.position, new Vector3(3.05f, 1.91f, 0.112f), step);
        if(Vector3.Distance(spell.transform.position, new Vector3(3.05f, 1.91f, 0.112f)) < 0.001f)
        {
            spell.transform.position = v;
        }
    }
}
