using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int maxnum;
    [SerializeField]int minnum;
    [SerializeField]TextMeshProUGUI guessText;
     int guess;
	// Use this for initialization
	//test github
    void Start () {
        guess = Random.Range(minnum, maxnum);
        guessText.text = guess.ToString();
	}

    public void OnPressLower()
    {
        maxnum = guess;
        guess = Random.Range(minnum, maxnum - 1);
        guessText.text = guess.ToString();
    }

	public void OnPressHigher()
    {
        minnum = guess;
        guess = Random.Range(minnum + 1, maxnum);
        guessText.text = guess.ToString();
    }


	// Update is called once per frame
}
