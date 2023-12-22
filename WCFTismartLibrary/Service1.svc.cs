﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTismartLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        SqlConnection _connection = new SqlConnection(@"Server=(local)\SQLEXPRESS;database=DbTismartLibrary;Integrated Security=SSPI");

        public void BookReservation(Book book)
        {
            _connection.Open();
            SqlCommand sqlCmd = new SqlCommand("SpBookReservation", _connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@idBook", book.Id);
            sqlCmd.Parameters.AddWithValue("@isReserved", true);
            sqlCmd.Parameters.AddWithValue("@dateReservation", DateTime.Now);
            sqlCmd.ExecuteNonQuery();

            _connection.Close();
        }

        public Book BookSelection(int id)
        {
            _connection.Open();

            Book bookSelection = new Book();

            SqlCommand sqlCmd = new SqlCommand("SpBookSelection", _connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@idBook", id);

            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                bookSelection.Id = Int32.Parse(sqlDataReader[0].ToString());
                bookSelection.IsReserved = bool.Parse(sqlDataReader[1].ToString()); 
                bookSelection.Title = sqlDataReader[2].ToString();
                bookSelection.Code = sqlDataReader[3].ToString();
            } 

            _connection.Close();

            return bookSelection;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public User GetUser(string email)
        {
            if(email == null)
            { 
                throw new Exception("Email required");
            }

            _connection.Open();

            var user = new User();
            
            SqlCommand sqlCmd = new SqlCommand("SpUserRetrieval", _connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@email", email);

            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                user.Id = int.Parse(sqlDataReader[0].ToString());
                user.FirstName = sqlDataReader[1].ToString();
                user.LastName = sqlDataReader[2].ToString();
                user.Email = sqlDataReader[3].ToString();
                user.Password = sqlDataReader[4].ToString();
                user.isActive = bool.Parse(sqlDataReader[5].ToString());
            }

            _connection.Close();

            return user;
        }

        public bool IsValidUser(UserCredentials userCredentials)
        {
            if (userCredentials.Email == null || userCredentials.Password == null)
            {
                throw new Exception("Credentials are required");
            }

            _connection.Open();

            SqlCommand sqlCmd = new SqlCommand("SpValidateUser", _connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@email", userCredentials.Email);
            sqlCmd.Parameters.AddWithValue("@password", userCredentials.Password);

            int count = (int)sqlCmd.ExecuteScalar();

            _connection.Close();

            return count > 0;
        }

        public IEnumerable<BookReservation> ListBooksReservations()
        {
            _connection.Open();

            List<BookReservation> booksReservations = new List<BookReservation>();

            
                SqlCommand sqlCmd = new SqlCommand("SpBooksReservations", _connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    booksReservations.Add(new BookReservation()
                    {                        
                        Id = Int32.Parse(sqlDataReader[0].ToString()),
                        Code = sqlDataReader[1].ToString(),
                        Title = sqlDataReader[2].ToString(),
                        IsReserved = bool.Parse(sqlDataReader[3].ToString()),
                        DateTimeReservation = sqlDataReader[4].ToString()
                    });
                }
  
            _connection.Close();

            return booksReservations;

        }
    }
}
