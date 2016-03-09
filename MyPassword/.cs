using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;


public class Server
{
    #region 
   
    private static string PORT = 8888;
    #endregion

    public Server()
    {
        

    }

    private void Initliza()
    {
        TcpListener serverSocket = new TcpListener(PORT);


    }

     static int Main(string []  args )
    {
        

    }




}