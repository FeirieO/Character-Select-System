using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public Character[] characters;
    public Transform Spot;

    private List<GameObject> characterList;
    private int currentCharacter;

    void Start()
    {
        characterList = new List<GameObject>();

        foreach (var character in characters)
        {
            GameObject gameObject = Instantiate(character.Player, Spot.position, Quaternion.identity);
            gameObject.SetActive(false);
            gameObject.transform.SetParent(Spot);
            characterList.Add(gameObject);
        }

        ShowCharacterList();
    }

    void ShowCharacterList()
    {
        characterList[currentCharacter].SetActive(true);
    }

    public void OnClickNext()
    {
        characterList[currentCharacter].SetActive(false);

        if (currentCharacter < characterList.Count - 1)
        {
            ++currentCharacter;
        }
        else
        {
            currentCharacter = 0;
        }

        ShowCharacterList();
    }

    public void OnClickPrev()
    {
        characterList[currentCharacter].SetActive(false);

        if (currentCharacter == 0)
        {
            currentCharacter = characterList.Count - 1;
        }
        else
        {
            currentCharacter = currentCharacter - 1;
        }

        ShowCharacterList();
    }
}
