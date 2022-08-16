using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;


namespace DataAcces
{
    public class User:ConnetionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connetion = GetConnection())
            {
                connetion.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connetion;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select a.id_usuario, a.nombre_usuario, b.rol from usuarios a, roles b where usuario = @user and contraseña =@pass and a.id_rol = b.id_rol";

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            cacheUsuario.idUser = reader.GetInt32(0);
                            cacheUsuario.nombre = reader.GetString(1);
                            cacheUsuario.rol = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public void AnyMethod()
        {
            if (cacheUsuario.rol == "supervisor")
            {
                //code..
            }
            if (cacheUsuario.rol == "cajero")
            {
                //code...
            }
        }
    }
}
