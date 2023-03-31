# Multithreading
 Shows Current Thread Informations 


Background Thread

The process of the application keeps running as long as at least one foreground thread is running. If more than one foreground thread is running and the Main() method ends, the process of the application keeps active until all foreground threads finish their work.

When you create a thread with the Thread class, you can define it as either a foreground or background thread by setting the property IsBackground. The Main() method set this property of the thread t to false. After setting the new thread, the main thread just writes an end message to the console. The new thread writes a start and an end message and in between it sleeps for 2 seconds.
