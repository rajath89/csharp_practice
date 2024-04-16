using System;
using System.Text;

class WeakRef
{
    /// <summary>
    /// Points to data that can be garbage collected any time.
    /// </summary>
    static WeakReference _weak;

    public static void MainMethod()
    {
        // Assign the WeakReference.
        _weak = new WeakReference(new StringBuilder("perls"));

        // See if weak reference is alive.
        if (_weak.IsAlive)
        {
            Console.WriteLine((_weak.Target as StringBuilder).ToString());
        }
        if (_weak.IsAlive)
        {
            Console.WriteLine("IsAlive1");
        }
        // Invoke GC.Collect.
        // ... If this is commented out, the next condition will evaluate true.
        GC.Collect();

        // Check alive.
        if (_weak.IsAlive)
        {
            Console.WriteLine("IsAlive2 should not be printed");
        }

        // Finish.
        Console.WriteLine("[Done]");
    }
}