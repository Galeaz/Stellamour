using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class VisualNovel : MonoBehaviour
{
    [SerializeField] Character character;
    private DialogueRunner dialogueRunner;
    // Start is called before the first frame update
    private void Awake()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.AddCommandHandler<string>("expressionName", SetExpression);
    }

    private void SetExpression(string name)
    {
        character.SetExpression(name);
    }
}
