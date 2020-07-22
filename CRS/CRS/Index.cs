﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRS
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        public Index(string UserNumber)
        {
            InitializeComponent();
            //当前登录的用户卡号
            label2.Text = UserNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Owner.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 窗体加载传递卡号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Index_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editpwd_Click(object sender, EventArgs e)
        {
            //显示修改密码框
            Editpd edit = new Editpd(this.label2.Text);
            edit.Owner = this;
            edit.Show();
            this.Hide();
        }
        /// <summary>
        /// 存入金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(this.label2.Text);
            deposit.Owner = this;
            deposit.Show();
            this.Hide();
        }
    }
}
