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
        dialogueRunner.AddCommandHandler<string>("expressionBustName", SetBustExpression);
        dialogueRunner.AddCommandHandler<bool>("Clear", clearExpression);
        dialogueRunner.AddCommandHandler<bool>("HeartNoHeart", showHeart);
    }

    private void SetExpression(string name)
    {
        character.SetExpression(name);
    }

    private void SetBustExpression(string name)
    {
        character.SetBustExpression(name);
    }

    private void clearExpression(bool clear)
    {
        character.disableCharacters();
    }

    private void showHeart(bool heart)
    {
        if (heart)
        {
            StartCoroutine(character.Heart());
        }
        else if (!heart)
        {
            StartCoroutine(character.noHeart());
        }
    }
}
