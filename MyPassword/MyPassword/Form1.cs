﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_to_Server_Click(object sender, EventArgs e)
        {
            //Socket sock = Sockets.CreateTCPSocket("www.myserver.com", 2345);
        }
    }
}
