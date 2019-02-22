using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSpace.Net.IDAL;
using System.Reflection;
namespace XSpace.Net.Business
{
    public class DBUtils
    {
        public static string assemblypath = "XSpace.Net.SQLDAL";
        public static IDAL.IUsers GetUserHandler()
        {
            
            Assembly assembly = Assembly.Load(assemblypath);
            return assembly.CreateInstance(assemblypath + ".Users") as IUsers;
             
        }

        public static IDAL.IManagers GetManagerHandler()
        {
            Assembly assembly = Assembly.Load(assemblypath);
            return assembly.CreateInstance(assemblypath+".Managers") as IManagers;
        }
        public static IDAL.IChannels GetChannelHandler()
        {
            Assembly assembly = Assembly.Load(assemblypath);
            return assembly.CreateInstance(assemblypath + ".Channels") as IChannels;
        }
        public static IDAL.IResources GetResourceHandler()
        {
            Assembly assembly = Assembly.Load(assemblypath);
            return assembly.CreateInstance(assemblypath + ".Resources") as IResources;
        }
    }
}
