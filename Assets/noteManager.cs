using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteManager : MonoBehaviour
{
    public GameObject note;
    public int noteCount;
    // Start is called before the first frame update
    void Start()
    {
        noteCount = transform.childCount-1;

        // user create
        NoteMethods.createUser();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addNote()
    {
        GameObject newNote = Instantiate(note, transform.position, transform.rotation);
        newNote.transform.SetParent(this.transform, false);
        newNote.transform.SetSiblingIndex(noteCount);
        noteCount++;
    }
    public void decrementNoteCont()
    {
        noteCount--;
    }
}
