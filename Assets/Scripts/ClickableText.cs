using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ClickableText : MonoBehaviour, IPointerClickHandler
{
    public static ClickableText instance;
    
    TextMeshProUGUI answerBoxTtext;
    public int linkIndex = 7;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
       answerBoxTtext  = GetComponent<TextMeshProUGUI>();
   
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            linkIndex = TMP_TextUtilities.FindIntersectingLink(answerBoxTtext, Input.mousePosition, null);
            if(linkIndex > -1)
            {
                var linkInfo = answerBoxTtext.textInfo.linkInfo[linkIndex];
                var linkId = linkInfo.GetLinkID();
                Debug.Log(linkIndex);
            } 
        }
    }
}
