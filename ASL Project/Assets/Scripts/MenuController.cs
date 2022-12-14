using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public static string category;

    public void LearnBtn(string cat){
        category = cat;
        SceneManager.LoadScene("Learn Scene");
    }
}
