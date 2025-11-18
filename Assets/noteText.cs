using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class noteText : MonoBehaviour
{
    public TMP_InputField inputField;
    private string startingText = "Enter Text Here";
    // Start is called before the first frame update
    void Start()
    {
        inputField.text = startingText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async void testEndEdit()
    {
        int index = transform.GetSiblingIndex();
        string text = inputField.text;
        
        // write to notes
        
        
        Debug.Log($"Saved {index} : {text} to Firebase");
    }
}
