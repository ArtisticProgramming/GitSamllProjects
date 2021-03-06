﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyCheckingInEntityFrameworkWinForm
{
    public partial class Form1 : Form
    {
        public byte[] currentRowVersion { get; set; }

        public User user { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ConcurrencyCheckingInEntityFrameworkDBEntities())
            {
                db.Users.Add(new User() { Id = 1, Name = "Ali", Age = 10 });
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new ConcurrencyCheckingInEntityFrameworkDBEntities())
            {
                var item = db.Users.FirstOrDefault();
                user = item;
                textBox1.Text = item.Name;
                textBox2.Text = string.Join("", item.RowVersion);
                currentRowVersion = item.RowVersion;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new ConcurrencyCheckingInEntityFrameworkDBEntities())
            {
                //var model = db.Users.F irstOrDefault();

                user.Name = textBox1.Text;

                db.Entry(user).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw ex;
                }

                //------------------------------------Second Way----------------------------------------------------
                //var model = db.Users.AsNoTracking().FirstOrDefault();
                //user.Name = textBox1.Text;
                //user.Age = model.Age;
                //db.Entry(user).State = EntityState.Modified;
                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (DbUpdateConcurrencyException ex)
                //{
                //    throw ex;
                //}
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
