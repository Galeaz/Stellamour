using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class Character : MonoBehaviour 
{
    [System.Serializable] // map of textures for facial expressions
    public class Expression 
    {
        public string name;
        public Image image;
    }

    [System.Serializable] // map of textures for facial expressions with bust
    public class BustExpression
    {
        public string name;
        public Image image;
    }

    // objects needed to render new textures on Character face
    [SerializeField] List<Expression> expressions = new List<Expression>();
    [SerializeField] List<BustExpression> bustExpressions = new List<BustExpression>();
    [SerializeField] Image heart;
    [SerializeField] Image heartBroken;

    // when this character is first created
    public void Awake() {
        // set initial pose and facial expression to defaults
        if (expressions.Count < 1) {
            Debug.LogError($"Character {name} has no available facial textures.");
            return;
        }

        SetExpression(name);
        Debug.Log($"Character {name} created.");

        if (bustExpressions.Count < 1)
        {
            Debug.LogError($"Character {name} has no available facial textures.");
            return;
        }

        SetBustExpression(name);
        Debug.Log($"Character {name} created.");
    }

    // moves character to location {location}>{markerName} in the scene
    public void SetExpression(string expressionName) 
    {
        disableCharacters();
        switch (expressionName)
        {
            case "Blush":
                expressions[0].image.enabled = true;
                break;
            case "Confused":
                expressions[1].image.enabled = true;
                break;
            case "Happy":
                expressions[2].image.enabled = true;
                break;
            case "Mad":
                expressions[3].image.enabled = true;
                break;
            case "Neutral":
                expressions[4].image.enabled = true;
                break;
            case "Sad":
                expressions[5].image.enabled = true;
                break;
            default:
                break;
        }
            Debug.Log($"Character {name} moved to >{expressionName}.");
    }

    public void SetBustExpression(string expressionName)
    {
        disableCharacters();
        switch (expressionName)
        {
            case "Blush":
                expressions[0].image.enabled = true;
                break;
            case "Confused":
                expressions[1].image.enabled = true;
                break;
            case "Happy":
                expressions[2].image.enabled = true;
                break;
            case "Mad":
                expressions[3].image.enabled = true;
                break;
            case "Neutral":
                expressions[4].image.enabled = true;
                break;
            case "Sad":
                expressions[5].image.enabled = true;
                break;
            default:
                break;
        }
        Debug.Log($"Character {name} moved to >{expressionName}.");
    }

    public void disableCharacters()
    {
        for (int i = 0; i <= 5; i++)
        {
            expressions[i].image.enabled = false;
            bustExpressions[i].image.enabled = false;
        }
    }

    public IEnumerator Heart()
    {
        heart.enabled = true;
        yield return new WaitForSeconds(3f);

        heart.enabled = false;
    }

    public IEnumerator noHeart()
    {
        heartBroken.enabled = true;
        yield return new WaitForSeconds(3f);

        heartBroken.enabled = false;
    }
}