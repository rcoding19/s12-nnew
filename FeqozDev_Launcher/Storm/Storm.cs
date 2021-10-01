// Decompiled with JetBrains decompiler
// Type: Storm.Storm
// Assembly: Storm Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8220DCE-4A1C-4137-A742-93F03F9D81EE
// Assembly location: C:\Users\Rafael Coelho\Desktop\FeqozDev_Launcher.exe

using System;

namespace Storm
{
  internal class Storm
  {
    public static void Log(string message)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("[");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("LUXFN");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("] " + message + "\n");
    }

    public static void LogNoBreak(string message)
    {
      ConsoleColor foregroundColor = Console.ForegroundColor;
      Console.Write("[");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("LUXFN");
      Console.ForegroundColor = foregroundColor;
      Console.Write("] " + message);
    }
  }
}
