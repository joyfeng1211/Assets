using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public string randomOperator;
    public int answer;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;


    public GameObject realAnswerOption;

    // Use this for initialization
    void Start()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GenerateQuestion()
    {

        int a = Random.Range(0, 31);
        int b = Random.Range(0, 31);

        int operatorNumber = Random.Range(0, 3);
        int option = Random.Range(0, 3);


        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        if (operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
        }

        if (operatorNumber == 2)
        {
            randomOperator = "*";
            answer = a * b;
        }


        if (option == 0)
        {
            realAnswerOption = option1;
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 2)).ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().realAnswerOption = option1;
            option3.GetComponent<Option>().realAnswerOption = option1;
        }
        else if (option == 1)
        {
            realAnswerOption = option2;
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 2)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<Option>().isCorrect = false;
            option1.GetComponent<Option>().realAnswerOption = option2;
            option3.GetComponent<Option>().realAnswerOption = option2;

        }
        else
        {
            realAnswerOption = option3;
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 2)).ToString();
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = true;
            option1.GetComponent<Option>().realAnswerOption = option3;
            option2.GetComponent<Option>().realAnswerOption = option3;
        }


        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";

    }
}
      



