using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenUI : MonoBehaviour
{
    public TMP_InputField inputName;
    public Button btDesigner;
    public Button btDeveloper;
    public TMP_Text textResult;

    private Image imageDesigner;
    private Image imageDeveloper;
    private Type selectedRole = null;
    private void Awake()
    {
        imageDesigner = btDesigner.GetComponent<Image>();
        imageDeveloper = btDeveloper.GetComponent<Image>();
    }

    public void ClickedDesigner()
    {
        imageDesigner.color = Color.blue; 
        imageDeveloper.color = Color.white;
        selectedRole = typeof(Designer);
    }
    
    public void ClickedDeveloper()
    {
        imageDesigner.color = Color.white; 
        imageDeveloper.color = Color.blue;
        selectedRole = typeof(Developer);
    }

    public void ClickedWork()
    {
        if (inputName.text.Length == 0)
        {
            textResult.text = "Enter name.";
            return;
        }

        if (selectedRole == null)
        {
            textResult.text = "Select role.";
            return;
        }

        var name = inputName.text;
        var isDesigner = selectedRole == typeof(Designer);
        string roleName;
        
        Worker worker;
        if (isDesigner)
        {
            worker = new Designer();
            roleName = "Designer";
        }
        else
        {
            worker = new Developer();
            roleName = "Developer";
        }

        worker.Name = name;
        var resultOfWork = worker.Work();

        var result = $"A {roleName} named {worker.Name} made {resultOfWork}.";
        textResult.text = result;
    }
}
