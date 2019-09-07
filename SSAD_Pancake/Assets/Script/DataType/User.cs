using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{

    public string userid;
    public string email;

    public User()
    {
    }

    public User(string username, string email)
    {
        this.userid = username;
        this.email = email;

    }
}
