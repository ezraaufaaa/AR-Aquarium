using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PenjelasanPari(){
        SceneManager.LoadScene("PenjelasanPari");
    }

    public void PenjelasanOrca(){
        SceneManager.LoadScene("PenjelasanOrca");
    }

    public void PenjelasanTuna(){
        SceneManager.LoadScene("PenjelasanTuna");
    }

    public void PenjelasanHiu(){
        SceneManager.LoadScene("PenjelasanHiu");
    }

    public void PenjelasanDori(){
        SceneManager.LoadScene("PenjelasanDori");
    }

}
