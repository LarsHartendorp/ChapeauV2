﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAO
{
    public class RegisterDAO : BaseDao
    {
        public void AddRowRegister(string firstname, string lastname, DateTime dateOfBirth, string email, string phoneNumber, int category, string password, string question, string answer)
        {
            // hoe moet combobox & datetimepicker
            // voorbeelden van internet
            // VALUES('"+dateTimePicker.Value.Date.ToString("yyyyMMdd")+"')
            // cmd.Parameters.Add("@Gander", comboBox1.GetItemText(comboBox1.SelectedItem));
            string query = "INSERT INTO [Employee] ([FirstName], [LastName], [DateOfBirth], [Email], [PhoneNumber], [Category], [Password], Question, Answer) VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Category, @Password, @Question, @Answer)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@FirstName", firstname);
            sqlParameters[1] = new SqlParameter("@LastName", lastname);
            sqlParameters[2] = new SqlParameter("@DateOfBirth", dateOfBirth.ToString("yyyy-MM-dd"));
            sqlParameters[3] = new SqlParameter("@Email", email);
            sqlParameters[4] = new SqlParameter("@PhoneNumber", phoneNumber);
            sqlParameters[5] = new SqlParameter("@Category", category);
            sqlParameters[6] = new SqlParameter("@Password", password);
            sqlParameters[7] = new SqlParameter("@Question", question);
            sqlParameters[8] = new SqlParameter("@Answer", answer);
            ExecuteEditQuery(query, sqlParameters);
            
            // Employee Class maken en die meegeven ipv alle parameters. 
            // comment
        }
    }
}