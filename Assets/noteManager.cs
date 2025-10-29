using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteManager : MonoBehaviour
{
    public GameObject note;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void addNote()
    {
        GameObject newNote = Instantiate(note, transform.position, transform.rotation);
        newNote.transform.SetParent(this.transform, false);
    }
}
