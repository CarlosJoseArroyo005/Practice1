using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    [SerializeField] int score = 0;

    private void Awake()
    {
        int numGameCtrl FindObjectOfType<GameController>().Length;
        if (numGameCtrl > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}

    public void Addscore()
    }
        Score = Score + 1;
    }
}






