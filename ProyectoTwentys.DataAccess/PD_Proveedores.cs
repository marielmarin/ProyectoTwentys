﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoTwentys.DataAccess
{
    public class PD_Proveedores
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedor"; //PROCEDIMIENTO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
   

        public void Insertar(int cedulaJuridica, string nombre, int telefono, string direccion)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Actualizar(int cedulaJuridica, string nombre, int telefono, string direccion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedor";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable Buscar(int cedulaJuridica)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", cedulaJuridica);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


    }
}
