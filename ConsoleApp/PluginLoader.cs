using System.Linq;
using System.Reflection;


public class PluginLoader
{
    public void Load()
    {
        try
        {
            // Load the plugin assembly dynamically (not known at compile time)
            Assembly pluginAssembly = Assembly.LoadFrom(@"C:/Users/nagar/OneDrive/Documents/dotnet practice/DSA practice/PluginLibrary/bin/Debug/net7.0/PluginLibrary.dll");

            // // Find all types in the assembly that implement IPlugin
            // Type[] pluginTypes = pluginAssembly.GetTypes()
            //     .Where(t => typeof(IPlugin).IsAssignableFrom(t))
            //     .ToArray();

            Type iPluginType = pluginAssembly.GetType("IPlugin");

            if (iPluginType != null)
            {
                // Find all types in the assembly that implement IPlugin
                // Type[] pluginTypes = pluginAssembly.GetTypes()
                //     .Where(t => iPluginType.IsAssignableFrom(t))
                //     .ToArray();

                // Find all types implementing IPlugin
                var pluginTypes = pluginAssembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && iPluginType.IsAssignableFrom(t));

                //foreach (Type pluginType in pluginTypes)
                //{
                    // // Create an instance of the plugin using late binding
                    // IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;

                    // if (plugin != null)
                    // {
                    //     // Execute the plugin's Run method
                    //     plugin.Run();
                    // }

                    
                //}


                foreach (var pluginType in pluginTypes)
                {
                    dynamic pluginInstance = Activator.CreateInstance(pluginType);
                    if(pluginInstance != null)
                    {
                        pluginInstance.Run();
                    }
                }
            }
            else
            {
                Console.WriteLine("IPlugin interface not found in the interface assembly.");
            }

            // foreach (Type pluginType in pluginTypes)
            // {
            //     var isPluginTypeAnObject = pluginType != null ? pluginType.IsClass && pluginType.BaseType != null && pluginType.BaseType.FullName == "System.Object" : false;

            //     if(isPluginTypeAnObject)
            //     {
            //         if (Activator.CreateInstance(pluginType) is IPlugin plugin)
            //         {
            //             // Execute the plugin's Run method
            //             plugin.Run();
            //         }
            //     }
            // }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading plugin types: {ex.Message}");
        }
    }

}
