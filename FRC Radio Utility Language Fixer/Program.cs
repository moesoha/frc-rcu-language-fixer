using System;
using System.Net.NetworkInformation;

namespace FRC_Radio_Utility_Language_Fixer{
	class Program{
		static void Main(string[] args){
			System.Console.WriteLine("This is a hack for the language issue of FRC Radio Configuration Utility in non-English Windows.");
			System.Console.WriteLine("GitHub Repo: https://github.com/moesoha/frc-rcu-language-fixer");
			System.Console.WriteLine("by Soha Jin from China in 2018");
			
			NetworkInterface[] networkInterfaces=NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface adapter in networkInterfaces){
				System.Console.WriteLine();
				IPInterfaceProperties interfaceProperties=adapter.GetIPProperties();
				System.Console.WriteLine(adapter.NetworkInterfaceType+" adapter "+adapter.Name+":");
				
				string macstr=adapter.GetPhysicalAddress().ToString();
				string[] mac=new string[macstr.Length/2+(macstr.Length%2==0?0:1)];
				for(int i=0;i<mac.Length;i++){
					mac[i]=macstr.Substring(i*2,i*2+2>macstr.Length?1:2);
				}
				System.Console.WriteLine("   Physical Address. . . . . . . . . : "+(String.Join("-",mac))); // 只有在有一个合法的MAC的时候才会被列入列表
			}

			System.Console.WriteLine();
		}
	}
}
