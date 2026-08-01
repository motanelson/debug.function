using System;

class ceditor 
{
    private static String source = " ";
    public static void saves(String names,String a) 
    {
        File.WriteAllText(names,a);
    
    
    }
    public static void appends(String a) 
    {
        source = source + a;
    
    
    }
    public static String gets()
    {
        String a = "";
        a = Console.ReadLine() ;
        return a;


    }
    public static void editorloop(String names) 
    {
        source = "";
        while (true)
        {
            String a = "";
            a = gets();
            appends(a+ "\r\n");
            if (a == "") break;
        }
        saves(names, source);
    
    }
}


class coneditor {

    public static void Main(String[] args)
    {
        String s = "";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        
        Console.WriteLine("give a file name to create ? empty line to save and exit ? ");
        s= Console.ReadLine();
        ceditor.editorloop(s);
    }



}


