// Decompiled with JetBrains decompiler
// Type: Storm.Program
// Assembly: Storm Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8220DCE-4A1C-4137-A742-93F03F9D81EE
// Assembly location: C:\Users\Rafael Coelho\Desktop\FeqozDev_Launcher.exe

using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Storm
{
  public class Program
  {
    private static void Main() => new Program().Run().GetAwaiter().GetResult();

    public async Task Run()
    {
      Process.Start("https://discord.gg/pTaHEFyHjB");
      string[] FNStuff = new string[3]
      {
        "FortniteClient-Win64-Shipping_EAC.exe",
        "FortniteClient-Win64-Shipping_BE.exe",
        "FortniteLauncher.exe"
      };
      string[] strArray = FNStuff;
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        string procname = strArray[index1];
        Process[] process = Process.GetProcessesByName(procname);
        Process[] processArray = process;
        for (int index2 = 0; index2 < processArray.Length; ++index2)
        {
          Process proc = processArray[index2];
          proc.Kill();
          proc = (Process) null;
        }
        processArray = (Process[]) null;
        process = (Process[]) null;
        procname = (string) null;
      }
      strArray = (string[]) null;
      Console.Title = "FeqozDev Launcher";
      Storm.Storm.Log("Welcome to LuxFN Credits to stormfn");
      Thread.Sleep(1000);
      string TempPath = Path.GetTempPath();
      string Path1 = "";
      string version = "1";
      string path1 = System.IO.File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
      object Json = JsonConvert.DeserializeObject(path1);
      // ISSUE: reference to a compiler-generated field
      if (Program.\u003C\u003Eo__1.\u003C\u003Ep__13 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Program.\u003C\u003Eo__1.\u003C\u003Ep__13 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (IEnumerable), typeof (Program)));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, IEnumerable> target1 = Program.\u003C\u003Eo__1.\u003C\u003Ep__13.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, IEnumerable>> p13 = Program.\u003C\u003Eo__1.\u003C\u003Ep__13;
      // ISSUE: reference to a compiler-generated field
      if (Program.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Program.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "InstallationList", typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = Program.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) Program.\u003C\u003Eo__1.\u003C\u003Ep__0, Json);
      foreach (object installion in target1((CallSite) p13, obj1))
      {
        // ISSUE: reference to a compiler-generated field
        if (Program.\u003C\u003Eo__1.\u003C\u003Ep__3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Program.\u003C\u003Eo__1.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, bool> target2 = Program.\u003C\u003Eo__1.\u003C\u003Ep__3.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, bool>> p3 = Program.\u003C\u003Eo__1.\u003C\u003Ep__3;
        // ISSUE: reference to a compiler-generated field
        if (Program.\u003C\u003Eo__1.\u003C\u003Ep__2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Program.\u003C\u003Eo__1.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, string, object> target3 = Program.\u003C\u003Eo__1.\u003C\u003Ep__2.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, string, object>> p2 = Program.\u003C\u003Eo__1.\u003C\u003Ep__2;
        // ISSUE: reference to a compiler-generated field
        if (Program.\u003C\u003Eo__1.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Program.\u003C\u003Eo__1.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "AppName", typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = Program.\u003C\u003Eo__1.\u003C\u003Ep__1.Target((CallSite) Program.\u003C\u003Eo__1.\u003C\u003Ep__1, installion);
        object obj3 = target3((CallSite) p2, obj2, "Fortnite");
        if (target2((CallSite) p3, obj3))
        {
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__7 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Program)));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string> target4 = Program.\u003C\u003Eo__1.\u003C\u003Ep__7.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string>> p7 = Program.\u003C\u003Eo__1.\u003C\u003Ep__7;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__6 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string, object> target5 = Program.\u003C\u003Eo__1.\u003C\u003Ep__6.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string, object>> p6 = Program.\u003C\u003Eo__1.\u003C\u003Ep__6;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__5 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", (IEnumerable<Type>) null, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> target6 = Program.\u003C\u003Eo__1.\u003C\u003Ep__5.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> p5 = Program.\u003C\u003Eo__1.\u003C\u003Ep__5;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__4 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "InstallLocation", typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj4 = Program.\u003C\u003Eo__1.\u003C\u003Ep__4.Target((CallSite) Program.\u003C\u003Eo__1.\u003C\u003Ep__4, installion);
          object obj5 = target6((CallSite) p5, obj4);
          object obj6 = target5((CallSite) p6, obj5, "\\FortniteGame\\Binaries\\Win64");
          Path1 = target4((CallSite) p7, obj6);
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__12 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__12 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Program)));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string> target7 = Program.\u003C\u003Eo__1.\u003C\u003Ep__12.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string>> p12 = Program.\u003C\u003Eo__1.\u003C\u003Ep__12;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__11 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__11 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, int, object> target8 = Program.\u003C\u003Eo__1.\u003C\u003Ep__11.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, int, object>> p11 = Program.\u003C\u003Eo__1.\u003C\u003Ep__11;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__10 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__10 = CallSite<Func<CallSite, object, char, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Split", (IEnumerable<Type>) null, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, char, object> target9 = Program.\u003C\u003Eo__1.\u003C\u003Ep__10.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, char, object>> p10 = Program.\u003C\u003Eo__1.\u003C\u003Ep__10;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__9 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", (IEnumerable<Type>) null, typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> target10 = Program.\u003C\u003Eo__1.\u003C\u003Ep__9.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> p9 = Program.\u003C\u003Eo__1.\u003C\u003Ep__9;
          // ISSUE: reference to a compiler-generated field
          if (Program.\u003C\u003Eo__1.\u003C\u003Ep__8 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Program.\u003C\u003Eo__1.\u003C\u003Ep__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "AppVersion", typeof (Program), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj7 = Program.\u003C\u003Eo__1.\u003C\u003Ep__8.Target((CallSite) Program.\u003C\u003Eo__1.\u003C\u003Ep__8, installion);
          object obj8 = target10((CallSite) p9, obj7);
          object obj9 = target9((CallSite) p10, obj8, '-');
          object obj10 = target8((CallSite) p11, obj9, 1);
          version = target7((CallSite) p12, obj10);
        }
      }
      if (System.IO.File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.old"))
        System.IO.File.Move(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe.old");
      if (System.IO.File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.old"))
        System.IO.File.Move(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe.old");
      WebClient webClient = new WebClient();
      await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/888449099614027796/890679754037018654/FortniteClient-Win64-Shipping_EAC.exe", TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe");
      await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/888449099614027796/890679743811297280/FortniteClient-Win64-Shipping_BE.exe", TempPath + "\\FortniteClient-Win64-Shipping_BE.exe");
      if (!System.IO.File.Exists(TempPath + "\\FeqozDev.dll"))
        await webClient.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/888449099614027796/890682524102168617/FeqozDev.dll", TempPath + "\\FeqozDev.dll");
      if (!System.IO.File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe"))
      {
        System.IO.File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
      }
      else
      {
        System.IO.File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
        System.IO.File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
      }
      if (!System.IO.File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe"))
      {
        System.IO.File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
      }
      else
      {
        System.IO.File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
        System.IO.File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
      }
      if (!System.IO.File.Exists(Path1 + "\\FeqozDev.dll"))
      {
        System.IO.File.Move(TempPath + "\\FeqozDev.dll", Path1 + "\\FeqozDev.dll");
      }
      else
      {
        System.IO.File.Delete(Path1 + "\\FeqozDev.dll");
        System.IO.File.Move(TempPath + "\\FeqozDev.dll", Path1 + "\\FeqozDev.dll");
      }
      ProcessStartInfo Proc = new ProcessStartInfo();
      Proc.CreateNoWindow = true;
      Proc.FileName = "cmd.exe";
      Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch";
      Process.Start(Proc);
      Storm.Storm.Log("LuxFN working on fn v" + version);
      Thread.Sleep(1000);
      Storm.Storm.Log("Launching Fortnite...");
      Console.ReadLine();
      FNStuff = (string[]) null;
      TempPath = (string) null;
      Path1 = (string) null;
      version = (string) null;
      path1 = (string) null;
      Json = (object) null;
      webClient = (WebClient) null;
      Proc = (ProcessStartInfo) null;
    }
  }
}
