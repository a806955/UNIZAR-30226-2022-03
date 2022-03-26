using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityNpgsql;

public class loginControlador : MonoBehaviour
{
    [SerializeField] private InputField nombreInput;
    [SerializeField] private InputField passwordInput;

    public void iniciaSesion()
    {

        var cs = "Database=rjwphrqg; " +
            "Username=rjwphrqg; " +
            "Host=balarama.db.elephantsql.com; " +
            "Port=5432; " +
            "Password=VO8gx2CjTr4hhoCG4gPZIqA0ARi1Tzjn; ";
        using var con = new NpgsqlConnection(cs);
        try
        {
            con.Open();
            Debug.Log("Conexion abierta");

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO usuarios VALUES ('" + nombreInput.text + "', '"+ passwordInput.text + "');";
            //cmd.ExecuteNonQuery();

            con.Close();
        }
        catch (Exception ex)
        {
            Debug.Log("Error con la base de datos :(" + ex);
        }
   
    }
}
