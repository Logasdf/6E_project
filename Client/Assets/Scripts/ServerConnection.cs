using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Net.Sockets;
using System.IO;


public class ServerConnection {

    public static ServerConnection GetInstance()
    {
        // not thread-safe yet.
        // and not sure if it should be a singleton class
        if(instance == null)
        {
            instance = new ServerConnection();
        }

        return instance;   
    }

    public void CreateConnection()
    {
        clientSocket = new TcpClient(ADDR, PORT);
        WriteToServer(); // test
    }

    //test
    public void WriteToServer()
    {
        string msg = "abcde\0";
        theStream = clientSocket.GetStream();
        StreamWriter writer = new StreamWriter(theStream);
        writer.Write(msg);
        writer.Flush();
    }

    private const string ADDR = "127.0.0.1";
    private const int PORT = 9910;
    private static ServerConnection instance;
    private TcpClient clientSocket;
    private NetworkStream theStream;

    private ServerConnection() { }
	
}
