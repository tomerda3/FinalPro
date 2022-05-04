﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProDoctor
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkName(textBox1.Text)== false){
                textBox4.Text = "The user name is incorrect";
                return;
            }
            if (checkName(textBox2.Text) == false){
                textBox4.Text = "The Password must be between 8 and 10 characters, to Contains at least one letter, one digit and one special character (!,#,$, etc.).";
                return;
            }
            if (checkName(textBox3.Text) == false){
                textBox4.Text = "The id number is incorrect";
                return;
            }

            /*
            Add here the user name, password and the id into the file.
            */

            Form1 start = new Form1();
            this.Hide();
            start.ShowDialog();
            this.Close();

        }

        bool checkName(string userName)
        {
            int count = 0, checkChar = 0;
            for(int i =0; i< userName.Length; i++)
            {
                if ((userName[i] >= '0' && userName[i] <= '9'))
                    count++;
                if ((userName[i] >= 'A' && userName[i] <= 'Z') || (userName[i] >= 'a' && userName[i] <= 'z'))
                    checkChar++;
            }
            if (count > 2)
                return false;

            if ((count+checkChar) != userName.Length)
                return false;

            return true;
        }

        bool checkPassword(string PassWord)
        {
            int count = 0, specialChar = 0,checknum = 0;
            for (int i = 0; i < PassWord.Length; i++)
            {
                if ((PassWord[i] >= 'A' && PassWord[i] <= 'Z') || (PassWord[i] >= 'a' && PassWord[i] <= 'z'))
                    count++;
                if (PassWord[i] == '!' || PassWord[i] == '#' || PassWord[i] == '$' || PassWord[i] == '&' || PassWord[i] == '%')
                    specialChar++;
                if (PassWord[i] >= '0' && PassWord[i] <= '9')
                    checknum++;
            }
            if (count < 1)
                return false;
            if (specialChar < 1)
                return false;
            if (checknum < 1)
                return false;
            return true;
        }
        bool checkId(string PassWord)
        {
            if (PassWord.Length > 10)
                return false;
            return true;
        }
    }
}
