using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialougeManager : MonoBehaviour
{
    int dialougeIndex;
    
    [SerializeField] TextMeshProUGUI dialougeText;
    [TextArea]
    [SerializeField] List<string> dialouge;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialougeText.text = dialouge[dialougeIndex];
    }

    public void ChangeDialouge()
    {
        dialougeIndex++;
        if (dialougeIndex < dialouge.Count)
        {
            dialougeText.text = dialouge[dialougeIndex];
        }
    }
}
