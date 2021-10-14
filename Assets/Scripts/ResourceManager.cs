using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hyphenation.Loader;
using Hyphenation; 
using UnityEngine.UI; 

public class ResourceManager : MonoBehaviour
{ 
    public FilePatternsLoader loader;
    public Hyphenator hyphenator; 
    public string text; 
    public Text result;
    public Text debugger;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            result.text = hyphenator.HyphenateText(text);
        }
    }
}
