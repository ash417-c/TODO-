using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteScript : MonoBehaviour
{
    public GameObject stack;
    public noteManager noteManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        stack = GameObject.FindWithTag("stack");
        noteManagerScript = stack.GetComponent<noteManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroyParentNote()
    {
        Destroy(transform.parent.gameObject);

        noteManagerScript.decrementNoteCont();
    }
}
