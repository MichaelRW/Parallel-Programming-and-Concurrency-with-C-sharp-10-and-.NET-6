

Console.WriteLine( "Hello, World!" );


var bgThread = new Thread( () => {

    while (true) {

        bool isNetworkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        Console.WriteLine( $"Is network available? Answer: {isNetworkUp}" );

        Console.WriteLine( $"Thread ID:  {System.Environment.CurrentManagedThreadId}" );
        
        Thread.Sleep( 100 );  // 100 millieseconds
    }

} );


bgThread.IsBackground = true;
    bgThread.Start();


for ( int i = 0; i < 10; i++ ) {

    Console.WriteLine( "Main thread working..." );
    Task.Delay( 500 );  // Wait 500 milliseconds;  allows background thread to do work.

}

Console.WriteLine( "Done" );

Console.ReadKey( );  // Monitor for any keyboard input;  terminated the program when detected.


